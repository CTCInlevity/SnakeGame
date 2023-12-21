using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SnakeGame
{
    internal class Audio
    {
        public readonly static MediaPlayer GameOver = LoadAudio("death.wav");
        public readonly static MediaPlayer FoodPickup = LoadAudio("foodpickup.wav");
        public readonly static MediaPlayer GameLoop = LoadAudio("music.mp3");
        public readonly static MediaPlayer SpeedUp = LoadAudio("speed.mp3");
        public readonly static MediaPlayer SlowDown = LoadAudio("slow.mp3");

        private static MediaPlayer LoadAudio(string filename, double volume = 1, bool autoReset = true, bool repeat = false)
        {
            MediaPlayer player = new();
            player.Open(new Uri($"Assets/{filename}", UriKind.Relative));
            player.Volume = volume;

            if (autoReset)
            {
                player.MediaEnded += Player_MediaEnded;
            }

            if (repeat)
            {
                player.MediaEnded += Player_MediaEnded;
            }
            return player;
        }

        private static void Player_MediaEnded(object sender, EventArgs e)
        {
            MediaPlayer m = sender as MediaPlayer;
            m.Stop();
            m.Position = new TimeSpan(0);
        }

        private static void PlayerRepear_MediaEnded(object sender, EventArgs e)
        {
            MediaPlayer m = sender as MediaPlayer;
            m.Stop();
            m.Position = new TimeSpan(0);
            m.Play();
        }
    }
}
