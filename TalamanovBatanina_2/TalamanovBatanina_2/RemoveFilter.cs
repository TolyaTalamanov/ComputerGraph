using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TalamanovBatanina_2
{
    class RemoveFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
        {
            int k = 100;
            double resultR; 
            double resultG; 
            double resultB;  
            if (x + k < sourseImage.Width)
            {
                Color sourceColor = sourseImage.GetPixel(x + k, y);

                 resultR = sourceColor.R;
                 resultG = sourceColor.G;
                 resultB = sourceColor.B;
            }
            else
            {
                resultR = 0;
                resultG = 0;
                resultB = 0;

            }
            return Color.FromArgb(Clamp((int)resultR, 0, 255),
                                  Clamp((int)resultG, 0, 255),
                                   Clamp((int)resultB, 0, 255));

        }
    }
}
