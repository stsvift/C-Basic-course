using System;
using System.Linq;

class Program
{
    static void FindProductOfNonNegativeRows(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            bool hasNegative = false;
            int product = 1;

            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] < 0)
                {
                    hasNegative = true;
                    break;
                }
                product *= matrix[i, j];
            }

            if (!hasNegative)
            {
                Console.WriteLine($"Произведение элементов в строке {i + 1}: {product}");
            }
        }
    }

    static void Main()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { -1, 4, 5 },
            { 6, 7, 8 }
        };
        FindProductOfNonNegativeRows(matrix);
    }
}
