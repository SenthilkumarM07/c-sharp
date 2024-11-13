    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senthil
{
    class two_dimensionalarray
    {
        static void Main(string[] agrs)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //type 1
            string[,] district = new string[2, 2];
            district[0, 0] = "ranipet";
            district[0, 1] = "vellore";
            district[1, 0] = "cudalore";
            district[1, 1] = "vilipuram";

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(district[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------");
            //type 2

            int[,] pincode = { { 600001, 600002 }, { 600003, 600004 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write (pincode[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------");
            //type 3
            char[,] initial = new char[,] { { 'M', 'S', 'K' }, { 'V', 'C', 'T' }, { 'W', 'J', 'V' } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(initial[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------");
            //type 4
            Console.WriteLine("enter no of rows");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter no of column");
            int col = Convert.ToInt32(Console.ReadLine());

            string[,] name = new string[row, col];
            Console.WriteLine("-----------------------------");
            Console.WriteLine("please enter :" + row * col + " names");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    name[i, j] = Console.ReadLine();    
                }
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("printing"+row*col+"names");


            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    
                    Console.Write(name[i, j]+"  ");
                }
        
                Console.WriteLine();
            }
            


        Console.ReadKey();
        }


    }
}
