using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senthil
{
    class while_loop
    {
        static void Main(string[] agrs)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------while loop----     -----------");
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("------------------ dice game while loop---------------");
            /*
            Random randomnumber=new Random();
            int roll=0;
            int attempt=0;
            while (roll != 6)
            {
                Console.ReadKey();
                roll = randomnumber.Next(1, 7);
                Console.WriteLine("you rolled :"+roll );
                attempt++;
            }
            Console.WriteLine("you rolled six in :"+attempt+"attempts" );
            */

            Random rnumber = new Random();
            int roll = 0;
            int  attempt = 0;

            while (roll != 6)
            {
                roll = rnumber.Next(1, 7);
                Console.WriteLine("you rolled :"+roll);
                attempt++;
            }

            Console.WriteLine("you rolled six in :"+attempt +"attempt");

            //dowhile loop
            int j = 0;
            do
            {
                Console.WriteLine("");
                j++;
            }
            while (i < 6);



            Console.ReadKey ();
        }
    }
}
