public class Program
{
    public static int MatrixElementSum(int[][] matrix)
    {
        int numRows = matrix.Length;
        int numColumns = matrix[0].Length;

        int sum = 0;

        for (int i = 0; i < numRows; i++)
        {
            for(int j = 0; j < numColumns; j++)
            {
                if (matrix[i][j] != 0 && i == 0)
                {
                    sum += matrix[i][j];
                }
                else if (matrix[i][j] != 0)
                {
                    for (int k = 1; k <= i; k++)
                    {
                        if (matrix[i - k][j] == 0)
                        {
                            break;
                        }
                        else if (k == i && (matrix[i - k][j] != 0))
                        {
                            sum += matrix[i][j];
                        }
                    }  
                }
                else
                {
                    continue;
                }
            }
        }

        return sum;
    }

    public static void Main(string[] args)
    {
        int[][] matrix = new int[][]
        {
            new int[] { 0, 1, 1, 2 },
            new int[] { 0, 5, 0, 0 },
            new int[] { 2, 0, 3, 3 }
        };

        int[][] matrix2 = new int[][]
        {
            new int[] { 1, 1, 1, 0 },
            new int[] { 0, 5, 0, 1 },
            new int[] { 2, 1, 3, 10 }
        };

        int sum = MatrixElementSum(matrix2);

        Console.WriteLine(sum);
    }
}