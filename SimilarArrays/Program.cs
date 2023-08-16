public class Program
{
    public static bool IsSimilar(int[] a, int[] b)
    {
        if (string.Join(",", a.OrderBy(o => o).Select(o => o.ToString()).ToArray())
                != string.Join(",", b.OrderBy(o => o).Select(o => o.ToString()).ToArray()))
                return false;
        return a.Select((o, i) => b[i] != o).Count(o => o) <= 2;
    }

    public static void Main()
    {
        int[] a = { 1, 2, 3, 4};
        int[] b = { 1, 2, 7, 3 };

        Console.WriteLine(IsSimilar(a, b));
        
    }
}