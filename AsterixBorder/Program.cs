public class Program
{
    public static string[] AsterixBorder(string[] picture)
    {
        List<string> list = new();
        List<char> topAndBottomBorderCharArray = new();

        if (picture == null || picture.Length == 0)
        {
            Console.WriteLine("Picture array is empty. Cannot add border.");
            return Array.Empty<string>();
        }

        // create bottom and top border
        for (int i = 0; i <= picture[0].Length + 1; i++)
        {
            topAndBottomBorderCharArray.Add('*');
        }

        string topAndBottomBorder = new(topAndBottomBorderCharArray.ToArray());
        list.Add(topAndBottomBorder);
        list.Add(topAndBottomBorder);

        // edit the existing elemenets with astrix either side
        for (int i = 0; i < picture.Length; i++)
        {
            var element = picture[i].ToCharArray().ToList();
            element.Insert(0, '*');
            element.Insert(element.Count, '*');

            string elementToString = new(element.ToArray());
            list.Insert(i + 1, elementToString);
        }
       
        return list.ToArray();
    }

    public static void Main()
    {
        string[] picture = { "abc", "jol"};

        string[] pictureBorder = AsterixBorder(picture);

        foreach (string pic in pictureBorder)
        {
            Console.WriteLine(pic);
        }
    }
}