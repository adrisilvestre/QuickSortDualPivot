

namespace QuickSortDualPivot.Utilities
{
    public static class SortingUtilities
    {
        public static bool More(int number1, int number2)
        {
            return number1 > number2;
        }
        public static bool Less(int number1, int number2)
        {
            return number1 < number2;
        }
        public static void Swap(int[] data, int firstIndex, int secondIndex)
        {
            int temporaryNumber = data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = temporaryNumber;
        }
    }
}
