public class Program
{
    //  Consider several points lying on a straight line.
    //  Call an unordered triple of points an equidistant triple if one of them is the mid-point of the segment formed by the other two.
    //  Given the coordinates of the points, find the number of equidistant triples formed by them.
    //  Example
    //  For coordinates = [1, 2, 4, 6, 7, 8], the output should be
    //  solution(coordinates) = 4.
    //  The equidistant triples are: (1, 4, 7), (2, 4, 6), (4, 6, 8), (6, 7, 8).


    public static int Solution(int[] coordinates)
    {
        int count = 0;
        int coordinateLength = coordinates.Length;

        for (int i = 0; i < coordinateLength; i++)
        {
            for (int j = i + 1; j < coordinateLength; j++)
            {
                int firstDistance = coordinates[j] - coordinates[i];
                for (int k = 0; k < coordinateLength; k++)
                {
                    int secondDistance = (k != i && k != j) ? coordinates[k] - coordinates[j] : 0;
                    if (firstDistance == secondDistance)
                    {
                        count++;
                        break;
                    }
                }
            }
        }
        return count;
    }

    public static void Main(string[] args)
    {
        int[] myCoordinates = { 1, 2, 4, 6, 7, 8, 9, 10 };
        int result = Solution(myCoordinates); // result == 4
        Console.WriteLine(result);
    }
}