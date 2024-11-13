using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senthil
{
    class pattenprogram
    {
        static void Main(string[] args)
        {
        Console.ForegroundColor = ConsoleColor.Green;
            /*  
             1)printing * patten 
                 *
                 * * 
                 * * * 
            */

            for (int i = 0; i < 3;i++ )
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
            
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------------------------");
            /*  
            2)printing * patten 
                * * * 
                * *
                * 
            */

            for (int i = 1; i <=3; i++)
            {
                for (int j = 1; j <=3-i+1; j++)
                {
                    Console.Write("* ");

                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------------");
            /*  
             3)printing * patten 
                   *
                 * *
               * * *
             */

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3-i+1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            /*
            4)printing * patten 
                   -***
                   --**
                   ---*
             */

            Console.WriteLine("-------------------------------");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i ; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 3-i+1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


            Console.WriteLine("------------------------------------------");
            /*
             5) patten program 
                        ****
                        *
                        *
                        ****
            */
            for (int i = 0; i < 4; i++)
            {
            if (i == 0 || i == 4 - 1) 
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write("*");
                }
            } 
            else 
            {
                Console.Write("* ");
            }
            Console.WriteLine() ;
            }


            Console.WriteLine("-----------------------------------------");

            /*  
             6)printing * patten 
                   * 
                 *  *
               *   *   *
          */

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3 - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            /*
            7)printing * patten 
                   -* * * 
                   --* * 
                   ---*
             */

            Console.WriteLine("-------------------------------");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 3 - i + 1; k++)
                { 
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
