﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class Pattern3
    {
        static void Main()
        {
            Console.WriteLine("Enter size");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
                    {
                        Console.Write("*");
                    }
                    else if(j==i || j==n-1-i)
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
