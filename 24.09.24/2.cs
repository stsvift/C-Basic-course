using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 9, 3, 4, 5, 8, 2 };
        int N = array.Length;

        if (N < 2)
        {
            Console.WriteLine("Массив слишком мал для поиска пары элементов.");
            return;
        }

        int maxSum = array[0] + array[1];
        int index = 0;

        for (int i = 1; i < N - 1; i++)
        {
            int currentSum = array[i] + array[i + 1];
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                index = i;
            }
        }

        Console.WriteLine($"{array[index]}, {array[index + 1]}");
    }
}
