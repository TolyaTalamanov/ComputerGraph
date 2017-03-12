using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TalamanovBatanina_2
{
    class BrightnessFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
        {
            int k = 50;
            Color sourceColor = sourseImage.GetPixel(x, y);
            double resultR = sourceColor.R + k;
            double resultG = sourceColor.G + k;
            double resultB = sourceColor.B + k;

            return Color.FromArgb(Clamp((int)resultR, 0, 255),
                                 Clamp((int)resultG, 0, 255),
                                 Clamp((int)resultB, 0, 255));



        }
    }
}
