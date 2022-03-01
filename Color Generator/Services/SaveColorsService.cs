using Color_Generator.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Media;

namespace Color_Generator.Services
{
    public class SaveColorsService
    {
        private readonly int _bmpWidth;
        private readonly int _bmpHeight;
        private readonly string _savePath;

        public SaveColorsService(int bmpWidth, int bmpHeight, string savePath)
        {
            _bmpWidth = bmpWidth;
            _bmpHeight = bmpHeight;
            _savePath = savePath;
        }

        public void Save(ObservableCollection<UserColor> pinnedColors)
        {
            foreach (UserColor color in pinnedColors)
            {
                using (Bitmap bmp = new(_bmpWidth, _bmpHeight))
                {
                    using (Graphics gfx = Graphics.FromImage(bmp))
                    {
                        System.Drawing.Color c = System.Drawing.Color.FromArgb(255, color.R, color.G, color.B);
                        gfx.FillRectangle(new SolidBrush(c), new Rectangle(new Point(0, 0), new Size(bmp.Width, bmp.Height)));
                    }

                    bmp.Save($"{_savePath}{color.R}-{color.G}-{color.B}.png");
                }
            }
        }
    }
}
