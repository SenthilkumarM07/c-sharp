using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senthil
{
    class practice
    {


        static void Main(string[] args)
        {
            //int num1 = Convert.ToInt16(Console.ReadLine());
            int num = 1234;
            int r;
            int temp;
            for (int i = 0; i<4 ; i++)
            {
                r = num % 10;

                num = num 10;
                
                Console.WriteLine(r);
            }
            Console.ReadKey();

        }

    }
}
