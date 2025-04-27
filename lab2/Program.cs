using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = PrimeService.IsPrime(number);
            Console.WriteLine(isPrime ? "true" : "false");
        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid input. Please enter a valid integer.");
            Environment.Exit(1);
        }
    }
}