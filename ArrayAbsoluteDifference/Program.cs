public class Program
{
    public int MaxAbsoluteDifference(int[] inputArray)
    {
        int maxDiff = 0;
        for(int i = 0; i < inputArray.Length - 1; i++)
        {
            int diff = Math.Abs(inputArray[i] - inputArray[i + 1]);
            if(diff > maxDiff)
            {
                maxDiff = diff;
            }
        }
        return maxDiff;
    }
}