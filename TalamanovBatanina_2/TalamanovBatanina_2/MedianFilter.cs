using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace TalamanovBatanina_2
{
    class MedianFilter : Filters
    {
        private Color medianColor;
        private int size;

        public MedianFilter(int size = 3)
        {
            this.size = size;
        }
        protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
        {
            return medianColor;
        }

        public Bitmap processImage(Bitmap sourseImage)
        {
            Bitmap resultImage = new Bitmap(sourseImage.Width, sourseImage.Height);

            var arrayR = new List<int>();
            var arrayG = new List<int>();
            var arrayB = new List<int>();

            
           
            

            for (int y = size / 2; y < sourseImage.Height - size / 2; y++)
            {
                

                for (int x = size / 2; x < sourseImage.Width - size / 2; x++)
                {
                    arrayR.Clear();
                    arrayG.Clear();
                    arrayB.Clear();

                    for (int j = -size / 2; j <= size / 2; j++)
                    {
                        for (int i = -size / 2; i <= size / 2; i++)
                        {
                            arrayR.Add(sourseImage.GetPixel(x + i, y + j).R);
                            arrayG.Add(sourseImage.GetPixel(x + i, y + j).G);
                            arrayB.Add(sourseImage.GetPixel(x + i, y + j).B);
                        }
                    }

                    arrayR.Sort();
                    arrayG.Sort();
                    arrayB.Sort();

                    medianColor = Color.FromArgb(arrayR.ElementAt(size / 2), arrayG.ElementAt(size / 2), arrayB.ElementAt(size / 2));

                    resultImage.SetPixel(x - size / 2, y - size / 2, calculateNewPixelColor(sourseImage, x - size / 2,y - size / 2));
                }
            }
            return resultImage;

        }

    }
}
