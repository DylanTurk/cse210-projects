using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            numbers.Add(number);
        } while (number != 0);

        int total = numbers.Sum();
        Console.WriteLine($"Your sum is: {total}");

        int avg = total / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");
    }
}