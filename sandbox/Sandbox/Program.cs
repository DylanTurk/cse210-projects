using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Give me an adjective");
        string adj = Console.ReadLine();
        Console.WriteLine("Give me a color");
        string color = Console.ReadLine();
        Console.WriteLine("Give me a noun");
        string noun1 = Console.ReadLine();
        Console.WriteLine("Give me a plural noun");
        string plural1 = Console.ReadLine();
        Console.WriteLine("Give me a person's name");
        string  name = Console.ReadLine();
        Console.WriteLine("Give me a place");
        string place = Console.ReadLine();
        Console.WriteLine("Give me an adverb");
        string adverb = Console.ReadLine();
        Console.WriteLine("Give me a plural noun");
        string plural2 = Console.ReadLine();
        Console.WriteLine("Give me a noun");
        string noun2 = Console.ReadLine();
        Console.WriteLine("Give me a verb");
        string verb = Console.ReadLine();
        Console.WriteLine("Give me a plural noun");
        string plural3 = Console.ReadLine();

        //Console.WriteLine($"One {adj} day, I was walking my {color} pet {noun1} when {plural1} started flying from the sky!");
        //Console.WriteLine($"I called my friend {name} and she said one just landed right on her {place}!");
        //Console.WriteLine($"({adverb}, there was raining {plural2} as well and they were just going everywhere!");
        //Console.WriteLine($"My {noun2} started {verb} and catching {plural3} with his mouth to eat.");
    }
}