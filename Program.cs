using HackerRank;

public class Program
{


    public static void Main(string[] args)
    {

        var clouds = new List<int> { 0, 0, 1, 0, 0, 0, 1, 0 };
        WarmUp.jumpingCouds(clouds);


        long v = WarmUp.RepeatedString("abcac", 3);
        Console.WriteLine(v);
    }

}