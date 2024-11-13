using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class exeptionhandling
    {
        static void Main(string[] args)
        {
           // syntax -try{} catch{}
            try
            {
                string[] names = { "senthil", "prathap", "nithish", "sanjvu" };
                Console.WriteLine(names[4]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
               
                int a = 20; 
                int b=0;
                int avg = a / b;
                Console.WriteLine(avg);

            }
            catch(Exception ex )
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

    }
}
