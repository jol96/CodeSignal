public class Program
{
    public static int[] AlternatingSums(int[] a)
    {
        var team1 = new List<int>();
        var team2 = new List<int>();

        for(int i = 0; i < a.Length; i++)
        {
            if(i % 2 == 0)
            {
                team1.Add(a[i]);
            }
            else
            {
                team2.Add(a[i]);
            }
        }

        return new int[] { team1.Sum(), team2.Sum() };
    }

    public static void Main(string[] args) 
    {
        int[] a = { 50, 60, 60, 45, 70 };

        int[] result = AlternatingSums(a);

        Console.WriteLine("Team 1 Sum: " + result[0]); // Output: Team 1 Sum: 170
        Console.WriteLine("Team 2 Sum: " + result[1]);
    }
}