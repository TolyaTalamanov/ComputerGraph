using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TalamanovBatanina_2
{
    class VerticalWavesFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
        {

            double resultR;
            double resultG;
            double resultB;


            int newX = (int)(x + 20 * Math.Sin(2 * Math.PI*x / 30));
            if (newX < 0 || newX >= sourseImage.Width)
            {
                Color sourceColor = sourseImage.GetPixel(x, y);
                resultR = sourceColor.R;
                resultG = sourceColor.G;
                resultB = sourceColor.B;

            }
            else
            {
                Color sourceColor = sourseImage.GetPixel(newX, y);
                resultR = sourceColor.R;
                resultG = sourceColor.G;
                resultB = sourceColor.B;
            }
            

            return Color.FromArgb(Clamp((int)resultR, 0, 255),
                                  Clamp((int)resultG, 0, 255),
                                   Clamp((int)resultB, 0, 255));

        }
    }
}
