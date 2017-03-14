using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TalamanovBatanina_2
{
    class AutoSelvesFilter : Filters
    {
        int MaxR;
        int MaxG;
        int MaxB;
        int MinR;
        int MinG;
        int MinB;

        private void setMaxRGB(Bitmap sourceImage)
        {
            int maxr = 0;
            int maxg = 0;
            int maxb = 0;

            int minr = 255;
            int ming = 255;
            int minb = 255;

            MyColor color;

            int R;
            int G;
            int B;


            var list = new List<MyColor>();

            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    R = sourceImage.GetPixel(i, j).R;
                    G = sourceImage.GetPixel(i, j).G;
                    B = sourceImage.GetPixel(i, j).B;
                    color = new MyColor(R, G, B);
                    list.Add(color);
                    
                    //if (sourceImage.GetPixel(i, j).R < maxr)
                    //    maxr = sourceImage.GetPixel(i, j).R;
                    //if (sourceImage.GetPixel(i, j).G < maxg)
                    //    maxg = sourceImage.GetPixel(i, j).G;
                    //if (sourceImage.GetPixel(i, j).B < maxb)
                    //    maxb = sourceImage.GetPixel(i, j).B;

                    //if (sourceImage.GetPixel(i, j).R > minr)
                    //    minr = sourceImage.GetPixel(i, j).R;
                    //if (sourceImage.GetPixel(i, j).G > ming)
                    //    ming = sourceImage.GetPixel(i, j).G;
                    //if (sourceImage.GetPixel(i, j).B > minb)
                    //    minb = sourceImage.GetPixel(i, j).B;
                }
            }

            list.Sort();

            MaxR = list.ElementAt((sourceImage.Width - 1)*(sourceImage.Height-  1)).R;
            MaxG = list.ElementAt((sourceImage.Width - 1) * (sourceImage.Height - 1)).G;
            MaxB = list.ElementAt((sourceImage.Width - 1) * (sourceImage.Height - 1)).B;

            MinR = list.ElementAt(0).R;
            MinG = list.ElementAt(0).G;
            MinB = list.ElementAt(0).B;
        }


        protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
        {
            int R = (sourseImage.GetPixel(x, y).R - MinR) * (255 / (MaxR - MinR));
            int G = (sourseImage.GetPixel(x, y).G - MinG) * (255 / (MaxG - MinG));
            int B = (sourseImage.GetPixel(x, y).B - MinB) * 255 / (MaxB - MinB);
            return Color.FromArgb(Clamp(R,0,255),Clamp(G,0,255),Clamp(B,0,255));
        }
        public override Bitmap processImage(Bitmap sourseImage, BackgroundWorker worker)
        {
            setMaxRGB(sourseImage);
            return base.processImage(sourseImage, worker);
        }
    }
}
