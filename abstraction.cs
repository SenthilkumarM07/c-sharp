using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
//abstraction is the process of hiding certain details and showing only essential information to the user.
//Abstraction can be achieved with either abstract classes or interfaces .
//Abstract class is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
//Abstract method can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).

    //abstract class
    abstract class animal
    {
        //abstract method 
        abstract public void cow();

        

  
        // normal method
        public void bird()
        {
            Console.WriteLine("bird sing kwick kwick....");
        }

        //abstract method for declare
         public abstract void student(int id ,string name, int age, string dept);
    }
    class abstraction:animal
    {
        //declaring abstract method using override
        public  override void student(int id, string name, int age, string dept)
        {
            Console.WriteLine(id + "," + name + "," + age + "," + dept);
        }
       
        public override void cow()
        {
            Console.WriteLine("cow says ma.....");
        }
        static void Main(string[] args)
        {
            abstraction a = new abstraction();
            a.bird();
            a.cow();
            a.student(101,"senthil",20,"cse");
            Console.ReadKey();
        }
    }
}
