using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] A = { -1, 2, 3, -4, 5 }; 
        List<int> result = new List<int>();

        foreach (int num in A)
        {
            if (num > 0)
            {
                result.Add(0); 
            }
            result.Add(num);
        }

        int[] B = result.ToArray();

        foreach (int num in B)
        {
            Console.Write(num + " ");
        }
    }
}
