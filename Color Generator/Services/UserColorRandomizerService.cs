using Color_Generator.Models;
using Color_Generator.Stores;
using System;

namespace Color_Generator.Services
{
    public static class UserColorRandomizerService
    {
        private static readonly Random _rand = new();

        public static void Randomize(SettingsStore settingsStore, UserColor userColor)
        {
            if (!settingsStore.AlphaIsLocked)
                userColor.A = _rand.Next(0, 255);

            if (!settingsStore.RedIsLocked)
                userColor.R = _rand.Next(0, 255);

            if (!settingsStore.GreenIsLocked)
                userColor.G = _rand.Next(0, 255);

            if (!settingsStore.BlueIsLocked)
                userColor.B = _rand.Next(0, 255);
        }
    }
}
