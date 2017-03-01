using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel

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
        public Bitmap processImage(Bitmap sourseImage, BackgroundWorker worker )
        {
           Bitmap resultImage = new Bitmap(sourseImage.Width, sourseImage.Height);
            for (int i = 0; i < sourseImage.Width; i++){

                for(int k = 0; k < sourseImage.Width;i++ )
                {
                    worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                    if(worker.CancellationPending)
                        return null;
                }


                for (int j = 0; j < sourseImage.Height; j++){ 
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourseImage, i, j));
                    return resultImage;
                }
            }


        }

        protected abstract Color calculateNewPixelColor(Bitmap sourseImage, int x, int y);

       
        
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
