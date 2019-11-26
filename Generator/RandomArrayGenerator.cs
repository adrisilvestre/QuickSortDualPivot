using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSortDualPivot.Generator
{
    public class RandomArrayGenerator
    {
       

        public int[] NumArray;
        public int ArraySize;
        public void Initializer()
        {
            Random random = new Random();
            for (var a = 0; a < NumArray.Length-1; a++)
            {
                NumArray[a] = random.Next(1, 99);
            }
               
        }
    }
}
