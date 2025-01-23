using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int sum = 0;
        foreach (char c in input)
            sum += c - '0';
        Console.WriteLine(sum);
    }
}
