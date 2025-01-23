using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string shortest = words.OrderBy(w => w.Length).First();
        string longest = words.OrderByDescending(w => w.Length).First();
        Console.WriteLine(shortest);
        Console.WriteLine(longest);
    }
}
