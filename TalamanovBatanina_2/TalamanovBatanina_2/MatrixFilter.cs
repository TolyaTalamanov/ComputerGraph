using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TalamanovBatanina_2
{
    class MatrixFilter:Filters
    {
        protected float[,] kernel = null;
        protected MatrixFilter() { }
        public MatrixFilter(float[,] kernel)
        {
            this.kernel = kernel;
        }
        protected override Color  calculateNewPixelColor(Bitmap sourseImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            for(int l = -radiusY;l <= radiusY;l++)
            {
                for(int k = -radiusX; k <= radiusX;k++)
                {
                    int idx = Clamp(x + k,0,sourseImage.Width -1);
                    int idy = Clamp(y + l,0,sourseImage.Height -1);
                    Color neighborColor = sourseImage.GetPixel(idx,idy);
                    resultR += neighborColor.R * kernel[k + radiusX,l + radiusY];
                    resultG += neighborColor.G * kernel[k + radiusX,l + radiusY];
                    resultB += neighborColor.B * kernel[k + radiusX,l + radiusY];
                }
            }
            return Color.FromArgb(
                Clamp((int)resultR,0,255),
                Clamp((int)resultG,0,255),
                Clamp((int)resultB,0,255)
            );

 	
        } 
    }
}
