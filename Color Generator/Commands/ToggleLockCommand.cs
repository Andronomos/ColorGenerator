using Color_Generator.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Generator.Commands
{
    public class ToggleLockCommand : CommandBase
    {
        private readonly SettingsStore _settingsStore;

        public ToggleLockCommand(SettingsStore settingsStore)
        {
            _settingsStore = settingsStore;
        }

        public override void Execute(object parameter)
        {
            switch(parameter.ToString().ToLower())
            {
                case "a":
                    _settingsStore.AlphaIsLocked = !_settingsStore.AlphaIsLocked;
                    break;
                case "r":
                    _settingsStore.RedIsLocked = !_settingsStore.RedIsLocked;
                    break;
                case "g":
                    _settingsStore.GreenIsLocked = !_settingsStore.GreenIsLocked;
                    break;
                case "b":
                    _settingsStore.BlueIsLocked = !_settingsStore.BlueIsLocked;
                    break;
            }
        }
    }
}
