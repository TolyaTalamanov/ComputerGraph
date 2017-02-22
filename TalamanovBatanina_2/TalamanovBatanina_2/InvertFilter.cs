using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TalamanovBatanina_2
{
    class InvertFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
        {
            Color sourseColor = sourseImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(255 - sourseColor.R,
                                               255 - sourseColor.G,
                                               255 - sourseColor.B);
            return resultColor;
        }
    }
}
