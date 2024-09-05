using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада (в рублях): ");
        double initialDeposit = Convert.ToDouble(Console.ReadLine());
        double[] depositAmounts = new double[6];
        depositAmounts[0] = initialDeposit * (1 + 4.0 / 100);

        for (int year = 1; year < 6; year++)
        {
            double percentageIncrease = 4.0 + year * 2.0;
            depositAmounts[year] = depositAmounts[year - 1] * (1 + percentageIncrease / 100);
        }

        for (int year = 0; year < 6; year++)
        {
            Console.WriteLine($"Сумма вклада после {year + 1} года: {depositAmounts[year]:F2} рублей");
        }
    }
}
