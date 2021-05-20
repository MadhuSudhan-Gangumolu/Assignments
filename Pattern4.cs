using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class Pattern4
    {
        static void Main()
        {
            Console.WriteLine("Enter size");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < (int)n/2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= ((int)n / 2) - i && j <= ((int)n / 2) + i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
