using System;

class Program
{
    static void SortAboveMainDiagonal(double[,] matrix)
    {
        int n = matrix.GetLength(0);
        var elementsAboveDiagonal = new List<double>();

        // Сбор элементов над главной диагональю
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
                elementsAboveDiagonal.Add(matrix[i, j]);

        // Пузырьковая сортировка
        for (int i = 0; i < elementsAboveDiagonal.Count - 1; i++)
            for (int j = 0; j < elementsAboveDiagonal.Count - i - 1; j++)
                if (elementsAboveDiagonal[j] > elementsAboveDiagonal[j + 1])
                    (elementsAboveDiagonal[j], elementsAboveDiagonal[j + 1]) = (elementsAboveDiagonal[j + 1], elementsAboveDiagonal[j]);

        // Вывод отсортированных элементов над диагональю
        Console.WriteLine("Отсортированные элементы над главной диагональю:");
        Console.WriteLine(string.Join(", ", elementsAboveDiagonal));
    }

    static void Main()
    {
        double[,] matrix = {
            { 1.0, 4.2, 3.3 },
            { 0.0, 2.5, 6.6 },
            { 7.1, -2.8, 3.9 }
        };
        SortAboveMainDiagonal(matrix);
    }
}
