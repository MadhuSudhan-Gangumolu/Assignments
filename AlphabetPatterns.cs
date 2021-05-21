using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class AlphabetPatterns
    {
        private static void A(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i==0 || i == (int)n / 2 || j == 0 || j == n-1)
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

        private static void  B(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == (int)n / 2 || j == 0 || j == n - 1 || i == n-1)
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

        private static void C(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 ||  j == 0 ||  i == n - 1)
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


        private static void D(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0 || i == n - 1 || j == n-1)
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

        private static void E(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0 || i == (int)n / 2 || i == n - 1)
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


        private static void F(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0 || i == (int)n / 2 )
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

        private static void G(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || i == 0 || i == n - 1)
                    {
                        Console.Write("*");
                    }
                    else if (((i >= (int)n / 2) && (j == n - 1)) || ((j >= (int)n / 2) && (i == (int)n / 2)))
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


        private static void H(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || i == (int)n / 2 || j == n-1)
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

        private static void I(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1 || j == (int)n / 2)
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

        private static void J(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1 || j == n - 1)
                    {
                        Console.Write("*");
                    }
                    else if ((i >= (int)n / 2) && (j == 0))
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

        private static void K(int n)
        {
            int count = n - (int)n / 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || j == count)
                    {
                        Console.Write("*");
                    }
                    else if ((i >= (int)n / 2) && (j == 0))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                if ((i+1) >= (int)n / 2)
                {
                    count++;

                }
                else
                {
                    count--;
                }
                Console.WriteLine();
            }
        }

        private static void L(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || i == n - 1 )
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

        private static void M(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || j == n - 1)
                    {
                        Console.Write("*");
                    }
                    else if (i <= (int)n / 2)
                    {
                        if(j == i || j == n - 1 -i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void N(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || j == n - 1 || i == j)
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

        private static void O(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || j == n - 1 || i == 0 || i == n - 1)
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

        private static void P(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 ||  i == 0 )
                    {
                        Console.Write("*");
                    }
                    else if (i <= (int)n / 2)
                    {
                        if( j == n - 1 || i == (int)n / 2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void Q(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i <= n - 2)
                    {
                        if (i == 0 || j == 0 || j == n - 1 || i == n - 2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (j == n - 2)
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

        private static void R(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i <= (int)n / 2)
                    {
                        if (i == 0 || j == 0 || j == n - 1 || i == (int)n / 2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (j == 0 || i == j)
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

        private static void S(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < (int)n / 2)
                    {
                        if (i == 0 ||j == 0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (i == (int)n / 2)
                    {
                        Console.Write("*");
                    }
                    else if (j == n - 1 || i == n - 1)
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

        private static void T(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ( i == 0 || j == (int)n / 2)
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

        private static void U(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || j ==  n - 1 || i == n - 1)
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


        private static void V(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((j == i || j == n - 1 - i) && i < (int)((n) / 2 ))
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

        private static void W(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || j == n - 1)
                    {
                        Console.Write("*");
                    }
                    if (i >= (int)n / 2)
                    {
                        if (i == j || j == n - 1 - i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void X(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || j == n - 1 - i)
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


        private static void Y(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i == j || j == n - 1 - i) && (i <= (int)n / 2))
                    {
                        Console.Write("*");
                    }
                    else if (((j == (int)n / 2) || j == ((int)n / 2) - 1) && (i > (int)n / 2))
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

        private static void Z(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == n - 1 - i || i == n - 1)
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
        public static void callAlphabets(int n, string name)
        {
            
            char choice = '.';
            foreach (char ch in name)
            {   
                choice = Convert.ToChar( Convert.ToString(ch).ToUpper());
                if (choice == ' ')
                {
                    Console.WriteLine("\n\n");
                    continue;
                }
                switch(choice)
                {
                    case 'A':
                        A(n);
                        Console.WriteLine("\n");
                        break;
                    case 'B':
                        B(n);
                        Console.WriteLine("\n");
                        break;
                    case 'C':
                        C(n);
                        Console.WriteLine("\n");
                        break;
                    case 'D':
                        D(n);
                        Console.WriteLine("\n");
                        break;
                    case 'E':
                        E(n);
                        Console.WriteLine("\n");
                        break;
                    case 'F':
                        F(n);
                        Console.WriteLine("\n");
                        break;
                    case 'G':
                        G(n);
                        Console.WriteLine("\n");
                        break;
                    case 'H':
                        H(n);
                        Console.WriteLine("\n");
                        break;
                    case 'I':
                        I(n);
                        Console.WriteLine("\n");
                        break;
                    case 'J':
                        J(n);
                        Console.WriteLine("\n");
                        break;
                    case 'K':
                        K(n);
                        Console.WriteLine("\n");
                        break;
                    case 'L':
                        L(n);
                        Console.WriteLine("\n");
                        break;
                    case 'M':
                        M(n);
                        Console.WriteLine("\n");
                        break;
                    case 'N':
                        N(n);
                        Console.WriteLine("\n");
                        break;
                    case 'O':
                        O(n);
                        Console.WriteLine("\n");
                        break;
                    case 'P':
                        P(n);
                        Console.WriteLine("\n");
                        break;
                    case 'Q':
                        Q(n);
                        Console.WriteLine("\n");
                        break;
                    case 'R':
                        R(n);
                        Console.WriteLine("\n");
                        break;
                    case 'S':
                        S(n);
                        Console.WriteLine("\n");
                        break;
                    case 'T':
                        T(n);
                        Console.WriteLine("\n");
                        break;
                    case 'U':
                        U(n);
                        Console.WriteLine("\n");
                        break;
                    case 'V':
                        V(n);
                        Console.WriteLine("\n");
                        break;
                    case 'W':
                        W(n);
                        Console.WriteLine("\n");
                        break;
                    case 'X':
                        X(n);
                        Console.WriteLine("\n");
                        break;
                    case 'Y':
                       Y(n);
                        Console.WriteLine("\n");
                        break;
                    case 'Z':
                        G(n);
                        Console.WriteLine("\n");
                        break;
                    default:
                        Console.WriteLine("Invalid character");
                        Console.WriteLine("\n");
                        break;

                }
            }
           
            
        }
        static void Main()
        {
            Console.WriteLine("Enter size");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name ");
            string name = Console.ReadLine();
            callAlphabets(n,name);


        }
    }
}
