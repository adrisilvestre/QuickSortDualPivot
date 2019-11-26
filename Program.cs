using System;
using QuickSortDualPivot.Generator;
using QuickSortDualPivot.Sorting;

namespace QuickSortDualPivot
{
    public class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Ingrese el tamaño del arreglo: ");
            size = Convert.ToInt32(Console.ReadLine());

            /*int[] myArray = new int[size];
            Random random = new Random();
            for (var a = 0; a < size - 1; a++)
            {
                myArray[a] = random.Next(1, 99);
            }*/
            int[] array2 = new int[10] { 10, 5, 7, 4, 15, 96, 33, 50, 11, 8 };
           

            SortingArr quickSorting = new SortingArr();

            int[] sortedArray = quickSorting.DualQuickSort(array2);

            Console.ReadKey();

            
        }
    }
}
