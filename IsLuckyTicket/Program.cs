using System;

public class Program
{
    public static bool isLucky(int n)
    {
        int ticketLength = Math.Abs(n).ToString().Length;

        int firstHalfSum = 0;
        int secondHalfSum = 0;

        // Convert the integer to a string
        string stringValue = n.ToString();

        char[] nCharArray = stringValue.ToCharArray();

        for (int i = 0; i < ticketLength; i++)
        {
            // first half sum
            if (i <= (ticketLength/2) - 1)
            {
                firstHalfSum += nCharArray[i];
            }
            // second half sum
            else
            {
                secondHalfSum += nCharArray[i];
            }
        }

        return firstHalfSum == secondHalfSum;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(isLucky(1212));
    }
}