using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senthil
{
    class constructor_practice
    {
        //constructor
        constructor_practice()
        {
            Console.WriteLine("enter first name :");
            //string first_name = Console.ReadLine();
            Console.WriteLine("enter last name :");
            //string last_name = Console.ReadLine();
            //Console.WriteLine("My  name is :" + first_name + last_name);
        }


        constructor_practice(int a, int b, int c)
        {
            int res = a + b + c;
            Console.WriteLine("a,b,c&res{0}{1}{2}{3}",a,b,c,res);
        }
        constructor_practice(int a, int b)
        {
            Console.WriteLine("Total :"+a*b);
        }
        //method
        void methoda()
        {
            Console.WriteLine("sdfghg");
        }  
        static void Main(string[] agrs)
        {
            constructor_practice c = new constructor_practice();//creating object for class
            constructor_practice c1 = new constructor_practice(2,4,8);
            constructor_practice c2 = new constructor_practice(2, 8);
            c.methoda();//method calling
            Console.ReadKey();
        }
    } 
}
