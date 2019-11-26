using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSortDualPivot.Generator
{
    public class RandomArrayGenerator
    {
        /// <summary>method <c>GenerateRandomArray</c> Fills the desired size array with 
        /// random numbers.</summary>
        public int[] GenerateRandomArray(int size)
        {
            int[] NumArray= new int[size];
            Random random = new Random();

            for (var a = 0; a < size - 1; a++)
            {
                NumArray[a] = random.Next(1, 99);
            }

            return NumArray;   
        }
    }
}
