using Color_Generator.Models;
using System;

namespace Color_Generator.Services
{
    public static class UserColorRandomizerService
    {
        private static readonly Random _rand = new();

        public static void Randomize(UserColor userColor)
        {
            int r = _rand.Next(0, 255);
            int g = _rand.Next(0, 255);
            int b = _rand.Next(0, 255);

            userColor.R = r;
            userColor.G = g;
            userColor.B = b;
        }
    }
}
