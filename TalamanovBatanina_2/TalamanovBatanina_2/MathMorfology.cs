using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TalamanovBatanina_2
{
    static class MathMorfology
    {
        static public Bitmap Erosion(Bitmap sourceImage, bool[,] matr)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            int MH = matr.GetLength(0);
            int MW = matr.GetLength(1);

            int minR;
            int minG;
            int minB;

            Color sourceColor;

            for (int y = MH / 2; y < sourceImage.Height - MH / 2; y++)
            {
                for (int x = MW / 2; x < sourceImage.Width - MW / 2; x++)
                {
                    sourceColor = sourceImage.GetPixel(x - MH / 2, y - MW / 2);
                    minR = sourceColor.R;
                    minG = sourceColor.G;
                    minB = sourceColor.B;

                    for (int j = -MH / 2; j <= MH / 2; j++)
                    {
                        for (int i = -MW / 2; i <= MW / 2; i++)
                        {
                            if (matr[i + MH / 2, j + MW / 2])
                            {
                                if (sourceImage.GetPixel(x + i, y + j).R < minR)
                                {
                                    minR = sourceImage.GetPixel(x + i, y + j).R;
                                }
                                if (sourceImage.GetPixel(x + i, y + j).G < minG)
                                {
                                    minG = sourceImage.GetPixel(x + i, y + j).G;
                                }
                                if (sourceImage.GetPixel(x + i, y + j).B < minB)
                                {

                                    minB = sourceImage.GetPixel(x + i, y + j).B;
                                }
                            }
                        }
                    }
                    resultImage.SetPixel(x - MH / 2, y - MW / 2, Color.FromArgb(minR, minG, minB));
                    
                }
            }
            return resultImage;

        }

        static public Bitmap Dilation(Bitmap sourceImage, bool[,] matr)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            int MH = matr.GetLength(0);
            int MW = matr.GetLength(1);

            int maxR;
            int maxG;
            int maxB;

            Color sourceColor;

            for (int y = MH / 2; y < sourceImage.Height - MH / 2; y++)
            {
                for (int x = MW / 2; x < sourceImage.Width - MW / 2; x++)
                {
                    sourceColor = sourceImage.GetPixel(x - MH / 2, y - MW / 2);
                    maxR = sourceColor.R;
                    maxG = sourceColor.G;
                    maxB = sourceColor.B;

                    for (int j = -MH / 2; j <= MH / 2; j++)
                    {
                        for (int i = -MW / 2; i <= MW / 2; i++)
                        {
                            if (matr[i + MH / 2, j + MW / 2])
                            {
                                if (sourceImage.GetPixel(x + i, y + j).R > maxR)
                                {
                                    maxR = sourceImage.GetPixel(x + i, y + j).R;
                                }
                                if (sourceImage.GetPixel(x + i, y + j).G > maxG)
                                {
                                    maxG = sourceImage.GetPixel(x + i, y + j).G;
                                }
                                if (sourceImage.GetPixel(x + i, y + j).B > maxB)
                                {

                                    maxB = sourceImage.GetPixel(x + i, y + j).B;
                                }
                            }

                        }
                    }
                    resultImage.SetPixel(x - MH / 2, y - MW / 2, Color.FromArgb(maxR, maxG, maxB));

                }
            }
            return resultImage;

        }
    }

}
