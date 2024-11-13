using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senthil
{
    class number_patten
    {
        static void Main(string[] agrs)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------------");

            int count = 0;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count +" ");
                    count++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("enter any letter in caps(A-Z)");
            char letter = Convert.ToChar(Console.ReadLine());
            int letterasii = letter;
            Console.WriteLine("a's ascii number is :" + letterasii);
            for (int i = letterasii; i <= 122; i++)
            {

                Console.Write(((char)i) + " ");
            }


            Console.ReadKey();
        }
    }
}
