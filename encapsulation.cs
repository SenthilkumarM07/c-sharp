using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class encapsulation
    {
        //encapsulation  defines warpping up data and method into single unit.
        //encapsulation helps to protect data by hiding it.
        //public getter setter are used here

        static void Main(string [] args)
        {
            banking b = new banking(1000);
            Console.WriteLine(b.deposit);
            b.deposit = 100;
            Console.WriteLine(b.deposit);
            Console.ReadKey();
        }
    }
    class banking
    {
        //variable
        private int current_balance;
        //properties
        public int deposit
        {
            get
            {
                return current_balance;
            }
            set
            {
                current_balance += value;
            }
        }
        // constructor or method

        public banking(int initial_balance)
        {

            current_balance = initial_balance;
        }
    }
}
