using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface Imathematics
    {
        //in interface public is automatically called 
        //in interface we can use it one for declare not for define
        //while definining inside the class method we cannot change the datatype and  parameter values.
        
        void add(int a,int b, int c);
        void sub(int a, int b,int c);
    }
    interface Imathematics1
    {
        int mul(int a, int b, int c);
        int div(int a, int b, int c);
    }

    class interface1:Imathematics,Imathematics1
    {
        public void add(int a, int b,int c)
        {
            int res;
            res = a + b;
            Console.WriteLine("addition  :"+res);
        }
        public void sub(int a, int b, int c)
        {
            int res;
            res = a - b+c;
            Console.WriteLine("subraction :"+res);
        }
        public int mul(int a, int b, int c)
        {
            int res;
            res = a * b + c;
            return res;
        }
        public int div(int a, int b, int c)
        {
            int res;
            res = a / b + c;
            return res;
        }
        
        static void Main(string[] args)
        {
            interface1 i = new interface1();
            i.add(5,2,0);
            i.sub(5,2,0);
            Console.WriteLine("multiplication :"+i.mul(7,2,0));
            Console.WriteLine("division :"+i.div(6,3,0));

            Console.ReadKey();   
        }
    
    }
}
