using System;

class Program
{
    static int[] CyclicShiftLeft(int[] A)
    {
        int N = A.Length;
        if (N <= 1) return A;

        int[] shiftedA = new int[N];
        Array.Copy(A, 1, shiftedA, 0, N - 1);
        shiftedA[N - 1] = A[0];
        return shiftedA;
    }

    static void Main()
    {
        int[] A = { 1, 2, 3, 4, 5 };
        int[] shiftedA = CyclicShiftLeft(A);
        Console.WriteLine(string.Join(", ", shiftedA)); // Вывод: 2, 3, 4, 5, 1
    }
}
