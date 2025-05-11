using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Singleton.Instance.GetHashCode());
        Console.WriteLine(Singleton.Instance.GetHashCode());
    }
}