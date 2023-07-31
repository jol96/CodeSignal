public class Program
{
    public static int[] SortByHeight(int[] a)
    {
        int[] sortedNonNegatives = a.Where(num => num != -1).OrderBy(num => num).ToArray();

        int currentIndex = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != -1)
            {
                a[i] = sortedNonNegatives[currentIndex];
                currentIndex++;
            }
        }

        Console.WriteLine("Sorted Array:");
        foreach (int num in a)
        {
            Console.Write(num + " ");
        }

        return a;
    }

    public static void Main(string[] args)
    {
        int[] a = { -1, 150, 190, 170, -1, -1, 160, 180 };

        // Print the sorted array
        SortByHeight(a);
    }
}