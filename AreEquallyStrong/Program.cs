public class Program
{
    public static bool EquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight) 
    {
        int person1StrongArm = (yourLeft > yourRight) ? yourLeft : yourRight;
        int person2StrongArm = (friendsLeft > friendsRight) ? friendsLeft : friendsRight;

        int person1WeakArm = (yourLeft < yourRight) ? yourLeft : yourRight;
        int person2WeakArm = (friendsLeft < friendsRight) ? friendsLeft : friendsRight;

        return person1StrongArm == person2StrongArm && person1WeakArm == person2WeakArm;
    }

    public static void Main()
    {
        Console.WriteLine(EquallyStrong(10,11,12,10));
    }
}