using System;

class Program
{
    static void Main()
    {
        int[] A = { 1, 2, 3, 4, 5 };
        int N = A.Length;
        double[] B = new double[N];

        int sum = 0;

        for (int K = 0; K < N; K++)
        {
            sum += A[K];
            B[K] = (double)sum / (K + 1);
        }

        for (int K = 0; K < N; K++)
        {
            Console.WriteLine($"B[{K + 1}] = {B[K]:F2}");
        }
    }
}
