using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите делимое: ");
            string n1 = Console.ReadLine();
            Console.Write("Введите делитель: ");
            string n2 = Console.ReadLine();

            if (n1.Trim() == "" || n2.Trim() == "")
                throw new Exception("не введено число");
            if (n1.Length > 30 || n2.Length > 30)
                throw new Exception("введено слишком длинное число");

            double a = double.Parse(n1);
            double b = double.Parse(n2);
            double result = a / b;
            
            Console.WriteLine($"Результат: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: деление на ноль");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: ошибка преобразования");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
