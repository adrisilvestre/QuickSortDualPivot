using System;
using System.Collections.Generic;
using System.Text;
using QuickSortDualPivot.Utilities;

namespace QuickSortDualPivot.Sorting
{
    public  class SortingArr
    {
        private int leftAux;
        private int rightAux;

        /// <summary>method <c>DualQuickSort</c> Sorts the input array using the Double QuickSort Algorithm.</summary>
        public int[] DualQuickSort(ref int[] dataToBeSort)//Wrapper del método Sort
        {
            Sort(ref dataToBeSort, 0, dataToBeSort.Length - 1);

            return dataToBeSort;
        }
        private void Sort(ref int[] dataToBeSort, int lowerBound, int upperBound)
        {
            if (upperBound<=lowerBound)
            {
                return;
            }

            Partition(dataToBeSort, ref lowerBound, ref upperBound);

            this.Sort(ref dataToBeSort, lowerBound, leftAux - 1);
            this.Sort(ref dataToBeSort, leftAux + 1, rightAux - 1);
            this.Sort(ref dataToBeSort, rightAux + 1, upperBound);
            
        }
        private void Partition(int[] dataToBeSort, ref int lowerBound, ref int upperBound)
        {
            int leftPivot = dataToBeSort[lowerBound];
            int rightPivot = dataToBeSort[upperBound];

            /*Si el pivote izquierdo es mayor que el derecho debe hacerse 
            un swap preliminar y reasignar los valores*/
            if (leftPivot > rightPivot)
            {
                SortingUtilities.Swap(dataToBeSort, upperBound, lowerBound);
                leftPivot = dataToBeSort[lowerBound];
                rightPivot = dataToBeSort[upperBound];

            }
            else if (leftPivot == rightPivot) //si los pivotes son de igual tamaño debe incremetarse el límite inferior
            {
                while ( leftPivot == rightPivot )
                {
                    if(lowerBound > upperBound)
                    {
                        break;
                    }

                    leftPivot = dataToBeSort[lowerBound + 1];
                    lowerBound++;
                }
            }


             int refCompare = lowerBound + 1; //variable de referencia para comparar valores.
             leftAux = lowerBound + 1; //variable auxiliar para intercambiar al comparar el primer pivote.
             rightAux = upperBound - 1; //variable auxiliar para intercambiar al comparar el segundo pivote

            while (refCompare <= rightAux)
            {

                if (SortingUtilities.More(leftPivot, dataToBeSort[refCompare]))
                {
                    SortingUtilities.Swap(dataToBeSort, refCompare++, leftAux);
                    leftAux++;
                    refCompare++;
                }
                else if (SortingUtilities.Less(rightPivot, dataToBeSort[refCompare]))
                {
                    SortingUtilities.Swap(dataToBeSort, refCompare, rightAux);
                    rightAux--;
                }
                else
                {
                    refCompare++;
                }

            }

            leftAux--;
            rightAux++;
            SortingUtilities.Swap(dataToBeSort, lowerBound, leftAux);
            SortingUtilities.Swap(dataToBeSort, upperBound, rightAux);
        }
    }
}
