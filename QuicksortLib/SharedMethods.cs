namespace QuicksortLib;

public class SharedMethods
{
    public static void Swap(int[] array, int index1, int index2)
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