public class Program
{
    public static bool Palindrone(string text)
    {
        char[] textArr = text.ToCharArray();
        var textArrLastElementIndex = textArr.Length - 1;
        bool isPalindrone = false;
        int halfOfTextArr = (textArr.Length / 2);

        for (int i = 0; i <= halfOfTextArr; i++)
        {
            var firstHalfValue = textArr[i];
            var secondHalfValue = textArr[textArrLastElementIndex];


            if (firstHalfValue != secondHalfValue)
            {
                //Console.WriteLine($"textArr[{i}] value {textArr[i]} is not equal to textArr[{textArrLastElementIndex}] {textArr[textArrLastElementIndex]}");
                isPalindrone = false;
                Console.WriteLine($"{text} is not a palindron");
                break;
            }
            else if (firstHalfValue == secondHalfValue)
            {
                //Console.WriteLine($"textArr[{i}] value {textArr[i]} is equal to textArr[{textArrLastElementIndex}] {textArr[textArrLastElementIndex]}");
                textArrLastElementIndex--;
                if (i == halfOfTextArr)
                {
                    Console.WriteLine($"{text} is a palindron");
                    isPalindrone = true;
                }
                else
                {
                    continue;
                }
            }
        }

        return isPalindrone;
    }

    public static void Main(string[] args)
    {
        Palindrone("aaabbaaa");

    }
}