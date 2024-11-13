using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senthil
{
    class car_constructor
    {
        public string model;
        public int addition;


        // creating constructor
        car_constructor()
        {

            model = "TATA";
        }

        car_constructor(int a,int b)
        {
             
            addition = a + b;
            Console.WriteLine(addition);
        }

        static void Main(string[] agrs)
        {
            car_constructor c = new car_constructor();
            car_constructor c1 = new car_constructor(5,2);
            Console.WriteLine(c.model);
            Console.WriteLine(c1.addition);

            Console.ReadKey();
        }
    }
}

