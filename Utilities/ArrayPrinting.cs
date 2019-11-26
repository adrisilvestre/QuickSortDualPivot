using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSortDualPivot.Utilities
{
    public class ArrayPrinting
    {
        public void PrintIntArray(int[] myArray)
        {
            Console.Write("[");
            for (int i = 0; i < myArray.Length; i++)
            {
                if (i == 0)
                    Console.Write(myArray[i]);
                else
                    Console.Write($", {myArray[i]}");
            }
            Console.Write("]");
        }
    }
}
