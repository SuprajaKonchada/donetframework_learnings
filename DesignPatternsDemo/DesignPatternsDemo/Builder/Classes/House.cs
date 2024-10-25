namespace DesignPatternsDemo.Builder.Classes
{
    public class House
    {
        public string Walls { get; set; }
        public string Floor { get; set; }
        public string Door { get; set; }
        public string Windows { get; set; }
        public string Roof { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"House Details:\nWalls: {Walls}\nFloor: {Floor}\nDoor: {Door}\nWindows: {Windows}\nRoof: {Roof}");
        }
    }
}
