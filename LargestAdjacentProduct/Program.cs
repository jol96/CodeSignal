public class Program
{
    public static int LargetAdjacentProduct(int[] inputArray)
    {
        int largestProduct = -1000;

        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            var currentValue = inputArray[i];
            var adjacentCalue = inputArray[i + 1];

            var product = currentValue * adjacentCalue;

            if (product > largestProduct)
            {
                largestProduct = product;
            }
        }
        Console.WriteLine($"Largest product {largestProduct}");
        return largestProduct;
    }

    public static void Main(string[] args)
    {
        int[] inputArray = { -23, 4, -3, 8, -12 };
        LargetAdjacentProduct(inputArray);
    }
}