using System;

class Program
{
    static int MinSumOfAbsDiagonals(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int minSum = int.MaxValue;

        // Диагонали ниже и включая побочную диагональ
        for (int k = 0; k < n; k++)
        {
            int sum = 0;
            for (int i = k, j = 0; i >= 0 && j < n; i--, j++)
                sum += Math.Abs(matrix[i, j]);
            minSum = Math.Min(minSum, sum);
        }

        // Диагонали выше побочной диагонали
        for (int k = 1; k < n; k++)
        {
            int sum = 0;
            for (int i = n - 1, j = k; i >= 0 && j < n; i--, j++)
                sum += Math.Abs(matrix[i, j]);
            minSum = Math.Min(minSum, sum);
        }

        return minSum;
    }

    static void Main()
    {
        int[,] matrix = {
            { 1, -2, 3 },
            { 4, 5, -6 },
            { 7, 8, 9 }
        };
        int minSum = MinSumOfAbsDiagonals(matrix);
        Console.WriteLine($"Минимум среди сумм модулей элементов диагоналей, параллельных побочной: {minSum}");
    }
}
