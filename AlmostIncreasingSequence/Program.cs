using System.Collections;

public class Program
{
    public static bool AlmostIncreasingSequence(int[] sequence)
    {
        int count = 0; // Count of non-strictly increasing points
        int n = sequence.Length;

        for (int i = 1; i < n; i++)
        {
            if (sequence[i] <= sequence[i - 1])
            {
                count++;

                // If there are more than one non-strictly increasing points, return false
                if (count > 1)
                    return false;

                // If we have 3 elements or more in the array, we need to check if removing
                // the current element or the previous element would result in a strictly increasing sequence.
                if (i >= 2 && sequence[i] <= sequence[i - 2])
                {
                    // If removing the current element results in a non-strictly increasing sequence,
                    // we set the current element to the value of the previous element.
                    sequence[i] = sequence[i - 1];
                }
            }
        }

        return true;
    }

    public static void Main(string[] args)
    {
        int[] sequence = { 1, 3, 2 };
        Console.WriteLine(AlmostIncreasingSequence(sequence));
    }

}