using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1

{
    

    
    class father
    {
        public void f ()
        {
            Console.WriteLine("father is  here....");
        }

    }

    class son:father
    {
       public void s()
        {
            Console.WriteLine("son is here......");
        }

    }
    
    class inheritance
    {
        static void Main(string[] args)
        {
            son i= new son();
            i.f();
            i.s();
            


            Console.ReadKey();
        }
       
    }
    
    
}
