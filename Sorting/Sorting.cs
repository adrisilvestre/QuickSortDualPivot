using System;
using System.Collections.Generic;
using System.Text;
using QuickSortDualPivot.Utilities;

namespace QuickSortDualPivot.Sorting
{
    public  class SortingArr
    {
        public int[] DualQuickSort(int[] dataToBeSort)
        {
            Sort(dataToBeSort, 0, dataToBeSort.Length - 1);

            return dataToBeSort;
        }
        private void Sort(int[] dataToBeSort, int lowerBound, int upperBound)
        {
            if (upperBound<=lowerBound)
            {
                return;
            }

            int leftPivot=0;
            int rightPivot;
            rightPivot = Partition(dataToBeSort, lowerBound, upperBound, leftPivot);
            this.Sort(dataToBeSort, lowerBound, leftPivot - 1);
            this.Sort(dataToBeSort, leftPivot + 1, rightPivot - 1);
            this.Sort(dataToBeSort, rightPivot + 1, upperBound);
            
        }
        private int Partition(int[] dataToBePartitioned, int lowerBound, int upperBound,int leftPivot)
        {
            if (SortingUtilities.More(dataToBePartitioned[lowerBound] , dataToBePartitioned[upperBound]))
            {
                SortingUtilities.Swap(dataToBePartitioned, lowerBound, upperBound);
            }
            int l = lowerBound + 1;
            int h = upperBound - 1, o = lowerBound + 1, v = dataToBePartitioned[lowerBound], 
                b = dataToBePartitioned[upperBound];

            while (o <= h)
            {
                if (dataToBePartitioned[o] < v)
                {
                    SortingUtilities.Swap(dataToBePartitioned, o, l);
                    l++;
                }
                else if (dataToBePartitioned[o] >= b)
                {
                    while (dataToBePartitioned[h] >= b)
                    {
                        h--;
                    }
                    SortingUtilities.Swap(dataToBePartitioned,o,h);
                    h--;
                    if (dataToBePartitioned[o] < v)
                    {
                        SortingUtilities.Swap(dataToBePartitioned, o, l);
                        l++;
                    }
                }
                o++;

            }
            l--;
            h--;
            SortingUtilities.Swap(dataToBePartitioned, lowerBound, l);
            SortingUtilities.Swap(dataToBePartitioned, upperBound, h);

            leftPivot = l;
            return h;
        }
    }
}
