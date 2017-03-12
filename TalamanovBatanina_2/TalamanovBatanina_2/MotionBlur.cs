using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TalamanovBatanina_2
{
    class MotionBlur : MatrixFilter
    {
        public void createMotionBlurKernel(int radius)
        {
            int size = 2 * radius + 1;
            kernel = new float[size, size];
            float norm = (1f / size);
            for (int i = -radius; i <= radius; i++)
            {
                for (int j = -radius; j <= radius; j++)
                {
                    if (i == j)
                        kernel[i + radius, j + radius] = norm;
                    else
                        kernel[i + radius, j + radius] = 0;                  
                    
                }
            }
            
        }
        public MotionBlur(int radius)
        {
            createMotionBlurKernel(radius);
        }
    }
}
