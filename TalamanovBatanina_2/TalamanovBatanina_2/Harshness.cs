using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TalamanovBatanina_2
{
    class Harshness : MatrixFilter
    {
        public void createHarhnessFilter()
        {
            kernel = new float[3, 3] { { -1, -1, -1 }, { -1, 9, -1 }, { -1, -1, -1 } };
        }
        public Harshness()
        {
            createHarhnessFilter();
        }        
    }
}
