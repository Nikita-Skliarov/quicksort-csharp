namespace QuicksortLib;
using static QuicksortLib.SharedMethods;

public class LomutoQuickSortClass
{
    public static void QuickSort(int[] array, low, high)
    {
        if (low < high)
        {
            int partitionIndex = PartitionSort(array, low, high);
            QuickSort(array, low, partitionIndex);
            QuickSort(array, partitionIndex + 1, high);
        }
    }

    private static int PartitionSort(int[] array, low, high)
    {
        
    }
}