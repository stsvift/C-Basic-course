using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество товаров: ");
        int itemCount = int.Parse(Console.ReadLine());

        double totalCost = 0;

        for (int i = 0; i < itemCount; i++)
        {
            Console.Write($"Введите стоимость товара {i + 1}: ");
            double cost = double.Parse(Console.ReadLine());

            if (cost > 1000)
            {
                totalCost += cost;
            }
        }

        Console.WriteLine($"Общая стоимость товаров дороже 1000 рублей: {totalCost}");
    }
}
