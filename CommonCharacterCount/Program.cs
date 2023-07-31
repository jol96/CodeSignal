public class Program
{
    public static int CommonCharacterCount(string st1, string st2)
    {
        // Create dictionaries to count character occurrences
        Dictionary<char, int> charCount1 = new Dictionary<char, int>();
        Dictionary<char, int> charCount2 = new Dictionary<char, int>();

        // Count character occurrences in the first string (s1)
        foreach (char c in st1)
        {
            if (charCount1.ContainsKey(c))
                charCount1[c]++;
            else
                charCount1[c] = 1;
        }

        // Count character occurrences in the second string (s2)
        foreach (char c in st2)
        {
            if (charCount2.ContainsKey(c))
                charCount2[c]++;
            else
                charCount2[c] = 1;
        }

        // Calculate the number of common characters
        int commonCount = 0;
        foreach (var kvp in charCount1)
        {
            if (charCount2.TryGetValue(kvp.Key, out int countInS2))
            {
                commonCount += Math.Min(kvp.Value, countInS2);
            }
        }

        return commonCount;
    } 

    public static void Main(string[] args)
    {
        string s1 = "aabcc";
        string s2 = "adcaa";
        int result = CommonCharacterCount(s1, s2);
        Console.WriteLine(result); // Output: 3
    }
}