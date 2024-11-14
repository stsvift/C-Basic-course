using System;

class Program
{
    static void SortElementsInRange(double[,] matrix, double a, double b)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        var elementsInRange = new List<double>();

        // Сбор элементов в заданном диапазоне
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                if (matrix[i, j] > a && matrix[i, j] < b)
                    elementsInRange.Add(matrix[i, j]);

        // Пузырьковая сортировка
        for (int i = 0; i < elementsInRange.Count - 1; i++)
            for (int j = 0; j < elementsInRange.Count - i - 1; j++)
                if (elementsInRange[j] > elementsInRange[j + 1])
                    (elementsInRange[j], elementsInRange[j + 1]) = (elementsInRange[j + 1], elementsInRange[j]);

        // Вывод отсортированных элементов
        Console.WriteLine("Отсортированные элементы в диапазоне:");
        Console.WriteLine(string.Join(", ", elementsInRange));
    }

    static void Main()
    {
        double[,] matrix = {
            { 1.2, 3.3, 5.5 },
            { 7.8, 4.2, 9.6 },
            { 2.1, 8.4, 6.3 }
        };
        SortElementsInRange(matrix, 3.0, 8.0);
    }
}
