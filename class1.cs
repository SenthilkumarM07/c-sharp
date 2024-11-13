using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class a
    {
        private int amount = 1000;

        public int deposit
        {
            get
            {
                return amount;
            }
            set
            {

                amount += value;
            
            }

        }
    }


    
    class Class1
    {
       
        
        static void Main(string[] args)
        {
            //oops concept in c#
            //--inheritance,abstraction,encapsulation,interface,polymorphism(method overloding,overriding)

            a n = new a();
            Console.WriteLine(n.deposit);
            n.deposit = 100;
            Console.WriteLine(n.deposit);

            Console.ReadKey();
        }
    }
}
