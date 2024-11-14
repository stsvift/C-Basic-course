using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива N: ");
        int N = int.Parse(Console.ReadLine());

        int[] A = new int[N];
        Console.WriteLine("Введите элементы массива:");

        for (int i = 0; i < N; i++)
        {
            Console.Write($"A[{i}] = ");
            A[i] = int.Parse(Console.ReadLine());
        }

        int count = 0;
        bool inIncreasingSegment = false;

        for (int i = 1; i < N; i++)
        {
            if (A[i] > A[i - 1])
            {
                if (!inIncreasingSegment)
                {
                    count++;
                    inIncreasingSegment = true;
                }
            }
            else
            {
                inIncreasingSegment = false;
            }
        }

        Console.WriteLine($"Количество монотонно возрастающих участков: {count}");
    }
}
