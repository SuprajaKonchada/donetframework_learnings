using DesignPatternsDemo.Adapter.Interfaces;

namespace DesignPatternsDemo.Adapter.Classes
{
    // Adapter: Translates the IMediaPlayer interface to Adaptee's interface
    public class MediaAdapter : IMediaPlayer
    {
        private VlcPlayer _vlcPlayer;
        private Mp4Player _mp4Player;

        public MediaAdapter(string audioType)
        {
            if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
            {
                _vlcPlayer = new VlcPlayer();
            }
            else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                _mp4Player = new Mp4Player();
            }
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
            {
                _vlcPlayer.PlayVlc(fileName);
            }
            else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                _mp4Player.PlayMp4(fileName);
            }
        }
    }
}
