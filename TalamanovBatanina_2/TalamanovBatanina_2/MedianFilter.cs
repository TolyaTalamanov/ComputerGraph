using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

class MyColor : IComparable
{
    public int R;
    public int G;
    public int B;
    public MyColor(int R, int G, int B)
    {
        this.R = R;
        this.G = G;
        this.B = B;
    }

    public int CompareTo(object obj)
    {
        return R + G + B;
    }
}

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

            //var arrayR = new List<int>();
            //var arrayG = new List<int>();
            //var arrayB = new List<int>();
            var arrayColor = new List<MyColor>();
            int R;
            int G;
            int B;
            MyColor color;





            for (int y = size / 2; y < sourseImage.Height - size / 2; y++)
            {
                

                for (int x = size / 2; x < sourseImage.Width - size / 2; x++)
                {
                    arrayColor.Clear();
                    //arrayR.Clear();
                    //arrayG.Clear();
                    //arrayB.Clear();

                    for (int j = -size / 2; j <= size / 2; j++)
                    {
                        for (int i = -size / 2; i <= size / 2; i++)
                        {
                            R = sourseImage.GetPixel(x + i, y + j).R;
                            G = sourseImage.GetPixel(x + i, y + j).R;
                            B = sourseImage.GetPixel(x + i, y + j).R;
                            color = new MyColor(R, G, B);
                            arrayColor.Add(color);
                            //    arrayR.Add(sourseImage.GetPixel(x + i, y + j).R);
                            //    arrayG.Add(sourseImage.GetPixel(x + i, y + j).G);
                            //    arrayB.Add(sourseImage.GetPixel(x + i, y + j).B);
                            //}
                        }
                    }
                        arrayColor.Sort();


                    //arrayR.Sort();
                    //arrayG.Sort();
                    //arrayB.Sort();

                    medianColor = Color.FromArgb(arrayColor.ElementAt(size / 2).R , arrayColor.ElementAt(size / 2).G, arrayColor.ElementAt(size / 2).B);

                    resultImage.SetPixel(x - size / 2, y - size / 2, calculateNewPixelColor(sourseImage, x - size / 2,y - size / 2));
                }
            }
            return resultImage;

        }

    }
}
