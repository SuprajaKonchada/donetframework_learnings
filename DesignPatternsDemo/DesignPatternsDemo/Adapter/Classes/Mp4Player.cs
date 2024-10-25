namespace DesignPatternsDemo.Adapter.Classes
{
    // Adaptee: MP4 Player
    public class Mp4Player
    {
        public void PlayMp4(string fileName)
        {
            Console.WriteLine("Playing MP4 file. Name: " + fileName);
        }
    }
}
