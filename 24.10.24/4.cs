using System;

class Program
{
    static bool IsArraySorted(int[] A)
    {
        for (int i = 1; i < A.Length; i++)
            if (A[i] < A[i - 1])
                return false;
        return true;
    }

    static void Main()
    {
        int[] A = { 1, 2, 3, 4, 5 };
        Console.WriteLine(IsArraySorted(A) ? "Массив отсортирован" : "Массив не отсортирован");
    }
}
