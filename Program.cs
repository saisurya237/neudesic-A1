using System;

class A1
{

    static int josephus(int n, int k)
    {
        if (n == 1)
            return 1;
        else
            return (josephus(n - 1, k)+ k - 1) % n + 1;
    }
    public static void Main()
    {
        string userinput;
        int n;
        int k = 2;
        Console.Write("Enter the Number of people in the circle.");
        userinput = Console.ReadLine();
        n = Convert.ToInt32(userinput);
        Console.WriteLine("The chosen "
        + "place is " + josephus(n, k));
        Console.ReadKey();
    }
}