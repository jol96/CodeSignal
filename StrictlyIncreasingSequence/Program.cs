public class Program
{
    // array = [1,1,5,4]
    // decalre varaible moves 
    // value = array[i+1] - array[i]
    // if value == 0 add 1 to moves
    // if value < 0


    public static int StrictlyIncreasing(int[] inputArray)
    {
        int totalMoves = 0;

        for (int i = 0; i < inputArray.Length - 1; i++) // Updated loop condition to avoid unnecessary last element handling
        {
            int diffBetweenElements = inputArray[i + 1] - inputArray[i];

            if (diffBetweenElements <= 0)
            {
                int movesNeededToMakeIncreasing = 1 - diffBetweenElements;
                inputArray[i + 1] += movesNeededToMakeIncreasing;
                totalMoves += movesNeededToMakeIncreasing;
            }
        }

        Console.WriteLine($"Increasing Array:");
        foreach (var input in inputArray)
        {         
            Console.WriteLine($"{input}");
        }

        return totalMoves;
    }

    public static void Main()
    {
        int[] inputArray = { 1, 1, 1 };

        Console.WriteLine(StrictlyIncreasing(inputArray));
    }

}