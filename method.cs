using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senthil
{
    class method
    {
       
              //1)without return type without parameter
        void name()
        {
              Console.WriteLine("------------without return type without parameter-----------------");
            Console.WriteLine("enter first name :");
            string first_name = Console.ReadLine();
            Console.WriteLine("enter last name :");
            string last_name = Console.ReadLine();
            Console.WriteLine("My  name is :" + first_name + last_name);
        }
        
              //2) without return type with parameter

        void add(int a,int b,int c)
        {
             Console.WriteLine("------------without return type with parameter-----------------");
            int res = a + b + c;
            Console.WriteLine("a,b,c&res {0}{1}{2}{3}",a,b,+c,res);
        }

        //------------------------------------------------------
        void studentdata(string name, string dept, string course)
        {
            Console.WriteLine(name + "+" + dept + "+" + course);
        }

         
              //3) with return type without parameter
        bool course()
        {
            Console.WriteLine("------------with return type without parameter-----------------");
            Console.WriteLine("Pls enter true for course complition false for not complete???");
            bool result = Convert.ToBoolean(Console.ReadLine());
            return result;

        }

        
             //4) with return type with parameter
        string mark(int t, int e, int m, int s, int ss)
        {
            Console.WriteLine("------------with return type with parameter-----------------");
            int total = t + e + m + s + ss;
            if (total >= 340)
            {
                return "pass";
            }
            else
            {
                return "fail";
            }
        }

        static void Main(string[] agrs)
        {
            method m = new method();
            m.name();
            m.add(2, 3, 4);
            m.studentdata("senthil","cse","dot net");
            m.course();
            Console.WriteLine(m.mark(80, 70, 88, 80, 77));

            Console.ReadKey();
        }
    }

}
