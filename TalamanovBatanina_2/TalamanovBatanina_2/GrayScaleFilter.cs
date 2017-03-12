using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TalamanovBatanina_2
{
    class GrayScaleFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
        {
            Color sourceColor = sourseImage.GetPixel(x, y);
            double resultR = sourceColor.R * 0.36;
            double resultG = sourceColor.G * 0.53;
            double resultB = sourceColor.B * 0.11;
            double intensity = resultR + resultG + resultB;

            return Color.FromArgb(Clamp((int)intensity, 0, 255), 
                                  Clamp((int)intensity,0,255),
                                   Clamp((int)intensity,0,255));
                                            



             
        }
    }
}
