namespace QuicksortLib;

public class SharedMethods
{
    /// <summary>
    /// Swaps two elements in the given array.
    /// </summary>
    /// <param name="array">The array in which elements will be swapped.</param>
    /// <param name="index1">The index of the first element to swap.</param>
    /// <param name="index2">The index of the second element to swap.</param>
    public static void Swap(int[] array, int index1, int index2)
    {
        // Swap variables using Tuples
        (array[index1], array[index2]) = (array[index2], array[index1]);
    }
}