using System.Text;

public class Program
{
    public static string ReverseInParentheses(string inputString)
    {
        StringBuilder result = new StringBuilder();
        Stack<StringBuilder> stack = new Stack<StringBuilder>();

        foreach (char c in inputString)
        {
            if (c == '(')
            {
                // Push the current result to the stack and reset the result for the new content inside parentheses
                stack.Push(result);
                result = new StringBuilder();
            }
            else if (c == ')')
            {
                // Pop the previous result from the stack, reverse the current result, and append it
                StringBuilder prevResult = stack.Pop();
                char[] reversedChars = result.ToString().ToCharArray();
                Array.Reverse(reversedChars);
                prevResult.Append(reversedChars);
                result = prevResult;
            }
            else
            {
                // Append the character to the current result
                result.Append(c);
            }
        }

        return result.ToString();
    }



    public static void Main(string[] args)
    {
        //Console.WriteLine(ReverseInParentheses("foo(bar)baz"));
        Console.WriteLine(ReverseInParentheses("foo(bar)baz(blim)"));
    }
}