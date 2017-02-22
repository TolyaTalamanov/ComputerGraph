using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TalamanovBatanina_2
{
    abstract class Filters
    {
        public Bitmap processImage(Bitmap sourseImage)
        {
            Bitmap resultImage = new Bitmap(sourseImage.Width, sourseImage.Height);

            for (int i = 0; i < sourseImage.Width; i++)
                for (int j = 0; j < sourseImage.Height; j++)
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourseImage, i, j));

                    return resultImage;
        }

        protected abstract Color calculateNewPixelColor(Bitmap sourseImage, int x, int y);

        public Bitmap processImage(Bitmap sourseImage);
        
        public int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

    }
}
