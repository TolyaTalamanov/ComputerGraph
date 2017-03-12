using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TalamanovBatanina_2
{
    class EmbossingFilter : MatrixFilter
    {
        public EmbossingFilter()
        {
            kernel = new float[3, 3];
                       
            kernel[0, 0] = 0;
            kernel[0, 1] = 1;
            kernel[0, 2] = 0;

            kernel[1, 0] = 1;
            kernel[1, 1] = 0;
            kernel[1, 2] = -1;

            kernel[2, 0] = 0;
            kernel[2, 1] = -1;
            kernel[2, 2] = 0;

            float norm = 2;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    kernel[i, j] /= norm;


        }

        protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
        {
            int coef = 50;
            
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idx = Clamp(x + k, 0, sourseImage.Width - 1);
                    int idy = Clamp(y + l, 0, sourseImage.Height - 1);
                    Color neighborColor = sourseImage.GetPixel(idx, idy);
                    resultR += neighborColor.R * kernel[k + radiusX, l + radiusY];
                    resultG += neighborColor.G * kernel[k + radiusX, l + radiusY];
                    resultB += neighborColor.B * kernel[k + radiusX, l + radiusY];
                }
            }
            return Color.FromArgb(
                Clamp((int)(resultR + coef), 0, 255),
                Clamp((int)(resultG + coef), 0, 255),
                Clamp((int)(resultB + coef), 0, 255)
            );
        }
    }
}
