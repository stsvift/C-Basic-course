using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string reversed = new string(input.Reverse().ToArray());
        Console.WriteLine(input == reversed ? "Число является палиндромом" : "Число не является палиндромом");
    }
}
