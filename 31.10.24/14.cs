using System;

class Program
{
    static int[] ShiftArrayRight(int[] A, int K)
    {
        int N = A.Length;
        int[] shiftedA = new int[N];
        if (K >= N)
        {
            return shiftedA;
        }
        Array.Copy(A, 0, shiftedA, K, N - K);
        return shiftedA;
    }

    static void Main()
    {
        int[] A = { 1, 2, 3, 4, 5 };
        int K = 2;
        int[] shiftedA = ShiftArrayRight(A, K);
        Console.WriteLine(string.Join(", ", shiftedA)); // Вывод: 0, 0, 1, 2, 3
    }
}
