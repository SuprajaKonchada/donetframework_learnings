namespace DesignPatternsDemo

{
    /// <summary>
    /// Seaded restricts the inheritance
    /// </summary>
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly object obj = new object();

        /// <summary>
        /// Public property is used to return only one instance of the class
        /// leveraging on the private property
        /// </summary>
        public static Singleton GetInstance
        {
            get
            {
                // double checking of instance == null is called double checked locking.
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;
            }
        }
        /// <summary>
        /// private constructor ensures that objects is not
        /// instantiated other than with in the class itself
        /// </summary>
        private Singleton()
        {
            counter++;
            Console.WriteLine("counter value " + counter.ToString());
        }
        /// <summary>
        /// public method which can be invoked through the singleton instance.
        /// </summary>
        /// <param name="message"></param>
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
