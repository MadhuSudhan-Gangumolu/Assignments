using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class DimandPattern
    {

        //o/p
     /*
         *
        ***
       *****
        ***
         *
     */
        public static void dimandPattern()
        {
            int n = 6;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n ; j++)
                {
                    if (j <= ((int)(n) / 2) + count && j >= ((int)(n) / 2) - count)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                if ((i+1) >= (int)n/2)
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
    }
}
