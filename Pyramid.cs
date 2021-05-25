using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class Pyramid
    {
        static void Main(string[] args)
        {
            int n = 6;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n*2; j++)
                {
                    if (j <= ((int)(n * 2)/2)+i && j >= ((int)(n * 2) / 2) - i)
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
