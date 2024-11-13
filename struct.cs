using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //structure is defined using struct keyword
    //it cannot be inherit and inherited
    //it cannot contain default  constructor
    // it doesnot support inheritance and abstraction 

    struct student
    {
        public string name ;
        public string dept ;
       
    }

    struct alphas
    {
        public int x;
        public  int y;
    }
    class @struct
    {
        static void Main(string[] args)
        {
            //creating an object  to structure class with new keyword
            student s = new student();
            Console.WriteLine(s.name);
            Console.WriteLine(s.dept);

            //creating an object  to structure class without new keyword

            alphas a;
           // Console.WriteLine(a.x); --->error due to value doesn't assigned for variable
            a.x = 10;
            a.y = 20;
            Console.WriteLine(a.x);
            Console.WriteLine(a.y);

            
            Console.ReadKey();
        }
    }
}
