using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senthil
{
    class user_input
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine("enter no of students details you going to enter ?");
            int studentcount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pls enter "+studentcount +" student Details Below.");
            for(int i=0;i<studentcount;i++)
            {

               int id;
               Console.WriteLine("id  :");
               id = Convert.ToInt32(Console.ReadLine());
               string first_name;
               Console.WriteLine("first_name :");
               first_name = Console.ReadLine();
               string last_name;
               Console.WriteLine("last_name :");
               last_name = Console.ReadLine();
               char initial;
               Console.WriteLine("initial : ");
               initial = Convert.ToChar (Console.ReadLine());
               int age;
               Console.WriteLine("age :");
               age = Convert.ToInt32(Console.ReadLine());
               string dept;
               Console.WriteLine("dept :");
               dept = Console.ReadLine();
               Console.WriteLine(id+","+first_name+last_name+" "+initial+","+age+","+dept);
               Console.WriteLine("-----------------------------------------------------");

            }
            Console.ReadKey();
        }
    }
}
