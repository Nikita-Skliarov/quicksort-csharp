using static QuicksortLib.SharedMethods;

namespace QuicksortLib
{
    public static class HoareQuickSortClass
    {
        private static readonly Random Random = new Random();

        /// <summary>
        /// Sorts the given array using Hoare's partitioning QuickSort algorithm.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        /// <param name="low">The starting index of the array segment.</param>
        /// <param name="high">The ending index of the array segment.</param>
        public static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = PartitionSort(array, low, high);
                QuickSort(array, low, partitionIndex); // Sort elements before partition
                QuickSort(array, partitionIndex + 1, high); // Sort elements after partition
            }
        }

        /// <summary>
        /// Partitions the array segment using Hoare's partitioning scheme.
        /// </summary>
        /// <param name="array">The array to partition.</param>
        /// <param name="low">The starting index of the segment.</param>
        /// <param name="high">The ending index of the segment.</param>
        /// <returns>The index where the partition is made.</returns>
        private static int PartitionSort(int[] array, int low, int high)
        {
            int pivotIndex = Random.Next(low, high + 1);
            int pivot = array[pivotIndex];

            int left = low - 1;
            int right = high + 1;

            while (true)
            {
                do
                {
                    left++;
                } while (array[left] < pivot);

                do
                {
                    right--;
                } while (array[right] > pivot);

                if (left >= right) 
                    return right; // Return the partition index

                Swap(array, left, right);
            }
        }
    }
}
