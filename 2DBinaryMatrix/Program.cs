public class Program
{
    // You have a 2D binary matrix that's filled with 0s and 1s. In the matrix, find the largest square that contains only 1s and return its area.
    // Example
    // For
    // matrix = [
    //    ['1', '0', '1', '1', '1'],
    //    ['1', '0', '1', '1', '1'],
    //    ['1', '1', '1', '1', '1'],
    //    ['1', '0', '0', '1', '0'],
    //    ['1', '0', '0', '1', '0']
    // ]
    // the output should be
    // solution(matrix) = 9.


    public static int MaximalSquare(char[][] matrix)
    {
        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            return 0;

        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int maxSquareSide = 0;
        int[] dp = new int[cols + 1];

        for (int i = 1; i <= rows; i++)
        {
            int prev = 0;
            for (int j = 1; j <= cols; j++)
            {
                int temp = dp[j];
                var value = matrix[i - 1][j - 1];

                // checking if the current cell in the matric equals 1
                if (matrix[i - 1][j - 1] == '1')
                {
                    var test = Math.Min(Math.Min(dp[j], dp[j - 1]), prev) + 1;
                    dp[j] = Math.Min(Math.Min(dp[j], dp[j - 1]), prev) + 1;
                    // 1st iteration dp[1] = (min of ((min of 0, 0 = 0), 0)) + 1 = 1
                    // 3rd iteration dp[3] = (min of ((min of 0, 0 = 0), 0)) + 1 = 1
                    maxSquareSide = Math.Max(maxSquareSide, dp[j]);
                }
                else
                {
                    dp[j] = 0;
                }
                prev = temp;
            }
        }

        return maxSquareSide * maxSquareSide;
    }


    public static void Main(string[] args)
    {
        char[][] matrix = new char[][] {
            new char[] { '1', '0', '1', '1', '1' },
            new char[] { '1', '0', '1', '1', '1' },
            new char[] { '1', '1', '1', '1', '1' },
            new char[] { '1', '0', '0', '1', '0' },
            new char[] { '1', '0', '0', '1', '0' }
        };

        char[][] matrix2 = new char[][] {
            new char[] { '1', '1', '1', '1' },
            new char[] { '1', '1', '1', '1' },
            new char[] { '1', '1', '1', '1' },
            new char[] { '1', '1', '1', '1' }
        };

        int result = MaximalSquare(matrix2);
        Console.WriteLine("Largest square area containing only 1s: " + result);
    }
}