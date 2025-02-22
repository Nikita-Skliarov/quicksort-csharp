namespace QuicksortLib;

public static class HoareQuickSortClass
{
    private static readonly Random Random = new Random();

    public static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = PartitionSort(array, low, high);
            QuickSort(array, low, partitionIndex); // Sort left side
            QuickSort(array, partitionIndex + 1, high); // Sort right side
        }
    }

    private static int PartitionSort(int[] array, int low, int high)
    {
        int pivotIndex = Random.Next(low, high + 1); // Fix: Ensure pivot is within range
        int pivot = array[pivotIndex];

        int left = low - 1; // Fix: Start before low
        int right = high + 1; // Fix: Start after high

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

            if (left >= right) return right; // Fix: Return right as partition index

            Swap(array, left, right);
        }
    }

    private static void Swap(int[] array, int index1, int index2)
    {
        // Define temp variable
        int temp = 0;

        // Save first number to temp
        temp = array[index1];

        // Make switch
        array[index1] = array[index2];
        array[index2] = temp;
    }
}