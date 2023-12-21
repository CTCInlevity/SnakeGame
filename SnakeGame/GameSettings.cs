using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public static class GameSettings
    {
        public static int ShakeDuration { get; set; } = 2000;
        public static int BoostSpeed { get; set; } = 40;
        public static double WallDensity { get; set; } = .005;
        public static bool WallFatality { get; set; } = false;
    }
}
