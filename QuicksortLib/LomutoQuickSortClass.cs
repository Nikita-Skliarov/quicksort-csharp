namespace QuicksortLib;
using static QuicksortLib.SharedMethods;

public class LomutoQuickSortClass
{
    /// <summary>
    /// Sorts the given array using Lomuto's partitioning QuickSort algorithm.
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    /// <param name="low">The starting index of the array segment.</param>
    /// <param name="high">The ending index of the array segment.</param>
    public static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = PartitionSort(array, low, high);
            QuickSort(array, low, partitionIndex - 1); // Sort elements before partition
            QuickSort(array, partitionIndex + 1, high); // Sort elements after partition
        }
    }
    
    /// <summary>
    /// Partitions the array segment using Lomuto's partitioning scheme.
    /// </summary>
    /// <param name="array">The array to partition.</param>
    /// <param name="low">The starting index of the segment.</param>
    /// <param name="high">The ending index of the segment.</param>
    /// <returns>The index where the partition is made.</returns>
    private static int PartitionSort(int[] array, int low, int high)
    {
        int pivot = array[high];
        int scanner = low;

        for (int i = low; i < high; i++)
        {
            if (array[i] < pivot)
            {
                Swap(array, i, scanner);
                scanner++;
            }
        }

        Swap(array, scanner, high);
        return scanner;
    }
}