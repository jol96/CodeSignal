using System.Text.RegularExpressions;

public class Program
{
    public static bool IsIPv4Address(string inputString)
    {
        string pattern = @"\b(0\d|\d0)\d*\b";
        Regex regex = new(pattern);
        List<bool> checkedValues = new List<bool>(); 
        string[] inputStringSpilt = inputString.Split(new char[] { '.' });

        if(inputStringSpilt.Length != 4)
        {
            return false;
        }

        foreach(string value in inputStringSpilt)
        {
            if(int.TryParse(value, out int intValue) && !regex.IsMatch(value))
            {
                bool isInIPv4Range = intValue >= 0 && intValue <= 255;
                checkedValues.Add(isInIPv4Range);
            }
            else
            {
                return false;
            }
        }

        return !checkedValues.Contains(false);
    }

    public static void Main()
    {
        Console.WriteLine(IsIPv4Address("01.233.161.131"));
    }
}