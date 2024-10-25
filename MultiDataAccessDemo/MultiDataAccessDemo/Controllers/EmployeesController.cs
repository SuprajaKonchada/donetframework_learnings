using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Data;
using MultiDataAccessDemo.Data;
using MultiDataAccessDemo.Models;

namespace MultiDataAccessDemo.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly string connectionString;

        public EmployeesController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }


        /// <summary>
        /// Entity Framework Example using LINQ
        /// </summary>
        /// <returns></returns>
        public IActionResult EntityFrameworkExample()
        {
            // Using LINQ with Entity Framework to filter employees older than 25
            var employees = _context.Employees.Where(e => e.Age > 25).ToList();
            return View(employees);
        }

        /// <summary>
        /// Dapper Example using LINQ
        /// </summary>
        /// <returns></returns>
        public IActionResult DapperExample()
        {
            List<Employee> employees;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Employees";
                var allEmployees = connection.Query<Employee>(query).ToList();

                // LINQ to filter employees older than 25
                employees = allEmployees.Where(e => e.Age > 25).ToList();
            }

            return View(employees);
        }

        /// <summary>
        /// ADO.NET Example using LINQ with DataSet and DataTable
        /// </summary>
        /// <returns></returns>
        public IActionResult AdoNetExample()
        {
            DataSet ds = new DataSet();
            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Employees";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(ds);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];

                    // Convert DataTable to List<Employee> using LINQ
                    employees = (from DataRow row in dt.Rows
                                 select new Employee
                                 {
                                     FirstName = row["FirstName"].ToString(),
                                     LastName = row["LastName"].ToString(),
                                     Age = int.Parse(row["Age"].ToString()),
                                     Designation = row["Designation"].ToString()
                                 }).Where(e => e.Age > 25).ToList();
                }
            }

            return View(employees);
        }

        /// <summary>
        /// ADO.NET Example using SqlDataReader and SqlCommand
        /// </summary>
        /// <returns></returns>
        public IActionResult AdoNetDataReaderExample()
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Employees WHERE Age > @Age";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Age", 25);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee
                            {
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Age = Convert.ToInt32(reader["Age"]),
                                Designation = reader["Designation"].ToString()
                            };
                            employees.Add(employee);
                        }
                    }
                }
            }

            return View("Employees", employees);
        }


        /// <summary>
        /// LINQ to Objects Example
        /// </summary>
        /// <returns></returns>
        public IActionResult LinqExample()
        {
            // Sample in-memory data for LINQ to Objects
            var employees = new List<Employee>
            {
                new Employee { FirstName = "Supraja", LastName = "Konchada", Age = 22, Designation = "Manager" },
                new Employee { FirstName = "Sanjay", LastName = "Konchada", Age = 17, Designation = "Developer" },
                new Employee { FirstName = "Sujatha", LastName = "Konchada", Age = 40, Designation = "Analyst" },
                new Employee { FirstName = "Satish", LastName = "Konchada", Age = 48, Designation = "HR" }
            };

            // LINQ query to filter employees older than 25
            var filteredEmployees = employees.Where(e => e.Age > 25).ToList();

            return View(filteredEmployees);
        }
    }
}
