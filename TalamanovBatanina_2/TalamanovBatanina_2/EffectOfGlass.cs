using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TalamanovBatanina_2
{
    class EffectOfGlass : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
        {

            double resultR;
            double resultG;
            double resultB;
            Random randomX = new Random();
            Random randomY = new Random();

            int newY = (int)((x + (randomX.Next(1) - 0.5) * 10));
            int newX = (int)((y + (randomY.Next(1) - 0.5) * 10));



            if (newY < 0 || newY >= sourseImage.Height || newX < 0 || newX >= sourseImage.Width)
            {
                Color sourceColor = sourseImage.GetPixel(x, y);
                resultR = sourceColor.R;
                resultG = sourceColor.G;
                resultB = sourceColor.B;

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
    

