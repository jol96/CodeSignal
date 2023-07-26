public class Program
{
    public static int NInterestingPolygon(int n)
    {
        return (n * n) + ((n - 1) * (n - 1));
    }

    public static void Main(string[] args)
    {
        int result = NInterestingPolygon(4);
        Console.WriteLine(result);
    }
}