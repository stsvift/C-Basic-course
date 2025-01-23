using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        HashSet<string> students = new HashSet<string>(Console.ReadLine().Split());
        for (int i = 1; i < m; i++)
        {
            int n = int.Parse(Console.ReadLine());
            students.IntersectWith(Enumerable.Range(0, n).Select(_ => Console.ReadLine()));
        }
        foreach (var student in students.OrderBy(s => s))
            Console.WriteLine(student);
    }
}
