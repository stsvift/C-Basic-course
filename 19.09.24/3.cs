using System;

class Program
{
    static void Main()
    {
        double deposit = 1000;
        int monthCountA = 0;
        int monthCountB = 0;
        double increase = 0;

        // Решение для части (a)
        while (increase <= 30)
        {
            increase = deposit * 0.02;
            deposit += increase;
            monthCountA++;
        }
        
        Console.WriteLine($"(а) Величина ежемесячного увеличения превысит 30 руб. через {monthCountA} месяцев.");

        deposit = 1000;
        increase = 0;

        // Решение для части (b)
        while (deposit <= 1200)
        {
            increase = deposit * 0.02;
            deposit += increase;
            monthCountB++;
        }

        Console.WriteLine($"(б) Размер вклада превысит 1200 руб. через {monthCountB} месяцев.");
    }
}
