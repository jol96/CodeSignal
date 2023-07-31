public class Program
{
    public static string[] AllLongestStrings(string[] inputArray)
    {
        // input array of strings
        // loop through the string array and check the length of each string
        // have a variable called lengestStringLength set to zero. 
        // check if each string is longer or equal to longestStringLength
        // if true add the string to array of strings to be returned

        int longestStringLength = 0;
        List<string> longestStringsList = new List<string>();

        for(int i = 0; i < inputArray.Length; i++)
        {
            if (longestStringLength < inputArray[i].Length)
            {
                // set new longestStringLength
                longestStringLength = inputArray[i].Length;

                // remove all the old strings from array list if a new longest is found
                if(longestStringsList.Count != 0)
                {
                    for(int j = 1; j <= i; j++)
                    {
                        longestStringsList.Remove(inputArray[j - 1]);
                    }  
                }
                // add the new longest   
                longestStringsList.Add(inputArray[i]);
            }
            else if(longestStringLength == inputArray[i].Length)
            {
                longestStringsList.Add(inputArray[i]);
            }
        }

        return longestStringsList.ToArray();
    }

    public static void Main(string[] args)
    {
        string[] strings = { "aba", "aa", "ad", "vcd", "aba" };
        string[] strings2 = { "abc","eeee","abcd","dcd" };

        Console.WriteLine(String.Join("\n", AllLongestStrings(strings2)));
    }
}