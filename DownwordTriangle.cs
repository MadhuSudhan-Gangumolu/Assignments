using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class DownwordTriangle
    {
        public static void downwordTriangle()
        {
            int n = 8;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
