using Color_Generator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Generator.Stores
{
    public class ColorStore : ObservableObject
    {
        public List<UserColor> Colors { get; } = new List<UserColor>();

        public int Total => Colors.Count;

        public event EventHandler ColorsChanged;

        public void AddColor(UserColor color)
        {
            Colors.Add(color);
            UpdateStore();
        }

        public void ClearColors()
        {
            Colors.Clear();
            UpdateStore();
        }

        private void UpdateStore()
        {
            ColorsChanged?.Invoke(this, null);
            OnPropertyChanged(nameof(Total));
        }
    }
}
