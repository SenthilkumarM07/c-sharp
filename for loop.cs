using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senthil
{
    class for_loop
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------- for loop  forward printing-------------------");
            int i;
            for (i=0; i < 5;i++ )
            {
                Console.WriteLine("("+i+")"+"hi guys");
            }

            Console.WriteLine("----------------for loop reverse printing----------------------");
            for (i = 6; i >= 1; i--)
            {
                Console.WriteLine(i+"  welcome");
            }

            //-------------------------------------------------------------------------
            
            Console.WriteLine("----------------- for loop to printing 3 tables -----------------");

            int m = 3;
            for (int x = 1; x <=10; x++)
            {
                Console.WriteLine(m  + "*" + x + "=" + m*x );
            }
            Console.ReadKey();
        }
    }
}
