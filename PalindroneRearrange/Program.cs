public class Program
{
    // count character frequency
    // if the length of the string is even then each character should appear an even amount of times
    // if the length is odd then at most one character can appear an odd amount of times, the rest should be even.


    public static bool CanFormPalindrone(string inputString)
    {
        Dictionary<char, int> charFreq = new Dictionary<char, int>();
        foreach(char c in inputString)
        {
            if (charFreq.ContainsKey(c))
                charFreq[c]++;  
            else
                charFreq[c] = 1;      
        }

        // count number of characters with odd count
        int oddCount = 0;
        foreach (int freq in charFreq.Values)
        {
            if(freq % 2 != 0)
                oddCount++;
        }

        // check palindrone props
        if (inputString.Length % 2 == 0 && oddCount == 0)
            return true;
        if (inputString.Length % 2 != 0 && oddCount == 1)
            return true;

        return false;
    }
}