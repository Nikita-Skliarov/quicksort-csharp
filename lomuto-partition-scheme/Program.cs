namespace lomuto_partition_scheme;
using Lomuto = QuicksortLib.LomutoQuickSortClass;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("╔══════════════════════════════════╗");
        Console.WriteLine("║        WELCOME TO QUICKSORT      ║");
        Console.WriteLine("║     (Lomuto Partition Scheme)     ║");
        Console.WriteLine("╚══════════════════════════════════╝");

        Console.WriteLine("\nWould you like to:");
        Console.WriteLine("1️⃣  Input your own array");
        Console.WriteLine("2️⃣  Generate a random array");
        Console.Write("Enter 1 or 2: ");

        int[] arr;
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("\nEnter numbers separated by spaces: ");
            arr = Console.ReadLine()
                .Split(' ')
                .Where(s => int.TryParse(s, out _))
                .Select(int.Parse)
                .ToArray();
        }
        else
        {
            Random random = new Random();
            Console.Write("\nEnter the size of the random array: ");
            int size = int.Parse(Console.ReadLine());
            arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(1, 1000);
            }

            Console.WriteLine("\nGenerated random array: " + string.Join(", ", arr));
        }

        Console.WriteLine("\n Original array: " + string.Join(", ", arr));
        Lomuto.QuickSort(arr, 0, arr.Length - 1);
        Console.WriteLine("\n Sorted array: " + string.Join(", ", arr));
        Console.WriteLine("\n Thank you for using QuickSort!");
    }
}
