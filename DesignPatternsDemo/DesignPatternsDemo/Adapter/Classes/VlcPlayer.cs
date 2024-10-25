namespace DesignPatternsDemo.Adapter.Classes
{
    // Adaptee: VLC Player
    public class VlcPlayer
    {
        public void PlayVlc(string fileName)
        {
            Console.WriteLine("Playing VLC file. Name: " + fileName);
        }
    }
}
