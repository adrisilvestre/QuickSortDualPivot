using System;
using QuickSortDualPivot.Generator;
using QuickSortDualPivot.Sorting;
using QuickSortDualPivot.Utilities;

namespace QuickSortDualPivot
{
    public class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Ingrese el tamaño del arreglo: ");
            size = Convert.ToInt32(Console.ReadLine());

            //Inicialización del arreglo con valores arbitrarios
            RandomArrayGenerator randomArr = new RandomArrayGenerator();
            int[] myArray = randomArr.GenerateRandomArray(size);

            ArrayPrinting printer = new ArrayPrinting();
            Console.WriteLine("Arreglo inicial: ");
            printer.PrintIntArray(myArray);
            Console.WriteLine();

            //Llamada a QuickSort de doble pivote
            SortingArr quickSorting = new SortingArr();
            quickSorting.DualQuickSort(ref myArray);

            //Impresión del arreglo ordenado
            Console.WriteLine("Arreglo ya ordenado:");
            printer.PrintIntArray(myArray);


            Console.ReadKey();

            
        }
    }
}
