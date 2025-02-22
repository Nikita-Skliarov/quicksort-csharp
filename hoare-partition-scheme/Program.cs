namespace hoare_partition_scheme;

class Program
{
    private static readonly Random Random =  new Random();
    
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
        int left = low -1 ;
        int right = high;
        int pivotIndex= Random.Next(low, high);
        int pivot = array[pivotIndex]; 

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

            if (left  >= right) return right;

            // Otherwise, swap elements
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
    static void Main(string[] args)
    {
        int[] arr = { 1, 4, 6, 7, 3, 2, 5 };
        Console.WriteLine("Original array: " + string.Join(", ", arr));

        QuickSort(arr, 0, arr.Length - 1);

        Console.WriteLine("Sorted array: " + string.Join(", ", arr));
    }
}