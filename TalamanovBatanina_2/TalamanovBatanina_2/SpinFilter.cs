using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TalamanovBatanina_2
{
    class SpinFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
        {
            
            int x0 = sourseImage.Width / 2,
                y0 = sourseImage.Height / 2;
            double spin = Math.PI / 6;

            double resultR;
            double resultG;
            double resultB;

            int newX = (int)((x - x0) * Math.Cos(spin) - (y - y0) * Math.Sin(spin) + x0);
            int newY = (int)((x - x0) * Math.Sin(spin) + (y - y0) * Math.Cos(spin) + y0);

            if (newX < 0 || newX >= sourseImage.Width || newY < 0 || newY >= sourseImage.Height)
            {
                resultR = 0;
                resultG = 0;
                resultB = 0;
            }
            else
            {
                Color sourceColor = sourseImage.GetPixel(newX, newY);


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
