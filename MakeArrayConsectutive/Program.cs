using System.Collections;

public class Program
{
    public static int[] MakeArrayConsecutive(int[] statues)
    {
        // Sorting the array from lowest to highest
        var sortedStatues = statues.OrderBy(num => num).ToArray();

        // get first and last elements of array
        var smallestStatue = sortedStatues[0];
        var largestStatue = sortedStatues[sortedStatues.Length - 1];

        ArrayList missingStatues = new ArrayList();

        Console.WriteLine($"smallestStatue {smallestStatue} \n largestStatue {largestStatue}");

        for (int i = smallestStatue + 1; i < largestStatue; i++)
        {
            bool containsStatue = Array.Exists(sortedStatues, element => element == i);

            if (!containsStatue)
            {
                missingStatues.Add(i);
                Console.WriteLine("Statue array does not contains statue of height " + i + ". Adding to missingStatues ArrayList.");
            }
            else
            {
                Console.WriteLine("Statue array contains statue of height " + i + ": " + containsStatue);
            }
        }

        int[] missingStatuesArray = missingStatues.Cast<int>().ToArray();

        Console.WriteLine($"Missing statues:");
        foreach (int statue in missingStatuesArray)
        {
            Console.WriteLine(statue);
        }

        return missingStatuesArray;
    }

    public static void Main(string[] args)
    {
        int[] inputArray = { 6, 2, 3, 8 };
        MakeArrayConsecutive(inputArray);
    }
}