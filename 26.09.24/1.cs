using System;

class Program
{
    static void Main()
    {
        int[] A = new int[10];
        Console.WriteLine("Введите 10 элементов массива:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"A[{i + 1}] = ");
            A[i] = int.Parse(Console.ReadLine());
        }

        int firstElement = A[0];
        int lastElement = A[9];
        int lastIndex = 0;

        for (int k = 1; k < 9; k++) // Не включаем первый и последний элемент
        {
            if (firstElement < A[k] && A[k] < lastElement)
            {
                lastIndex = k + 1; // Индексы выводим, начиная с 1, поэтому +1
            }
        }

        Console.WriteLine($"Порядковый номер последнего элемента, удовлетворяющего условию: {lastIndex}");
    }
}
