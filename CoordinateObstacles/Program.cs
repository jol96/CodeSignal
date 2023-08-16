public class Program
{
    public static int MinJumpsToAvoidObstacles(int[] inputArray)
    {
        // sort array in ascending order
        // check first element value
        // check if first element value+1 exists in the array
        // if not, set minjump to first element value + 1
        // if it does, continue to the next element and repeat

        int n = 2;
        while (inputArray.Any(_ => _ % n < 1))
        {
            n++;
        }
        return n;
    }

    public static void Main()
    {
        int[] inputArray = { 5, 3, 6, 7, 9 };
        MinJumpsToAvoidObstacles(inputArray);
    }
}