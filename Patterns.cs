using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class Patterns
    {
    //     * * * * * 
    //      * * * * 
    //       * * * 
    //        * * 
    //         * 
        public static void ReversePyramid()
        {
            int n = 10;
            n = n % 2 == 0 ? n + 1 : n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= i && j <= n - 1 - i)
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


        //* 
        //* * 
        //* * * 
        //* * * * 
        //* * * * * 
        //* * * * 
        //* * * 
        //* * 
        //* 
        public static void rightPascalTraingle()
        {
            int n = 10;
            n = n % 2 == 0 ? n + 1 : n;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= count)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                if(i>=(int)n/2)
                {
                    count--;
                }
                else
                {
                    count++;
                }
                Console.WriteLine();

            }
        }

     //    *
     //   **
     //  ***
     // ****
     //*****
     // ****
     //  ***
     //   **
     //    *
         public static void leftpascalTraingle()
         {
            int n = 10;
            n = n % 2 == 0 ? n + 1 : n;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= n - 1 - count)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                if (i >= (int)n / 2)
                {
                    count--;
                }
                else
                {
                    count++;
                }
                Console.WriteLine();

            }
         }

        //      1
        //     121
        //    12321
        //   1234321
        public static void numberPattern()
        {
            int n = 6;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(Math.Pow((int)(Math.Pow(10,i)/9),2));
            }
        }
    }
}
