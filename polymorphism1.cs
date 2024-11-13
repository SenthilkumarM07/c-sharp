using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//polymorphism  (1)poly--many, (2)morphism --forms 
//one method takes many actions 
//there are two types of polymorphism 
//1)method overloding -- same method  with differnt parameter or parameter.
//2)method over writting  -- same method with same parameter with different implemantation  




namespace ConsoleApplication1
{
    //method overloding 
    class polymorphism1m
    {
        void passenger(string name)
        {
            Console.WriteLine("passenger name is added");
        }

        void passenger(string name, int age)
        {
            Console.WriteLine("passenger name,age is added");
        }

        void passenger(string name, int age, string destination)
        {
            Console.WriteLine("passenger name,age,destination is added");
        }

        static void Main(string[] args)
        {
            polymorphism1m t = new polymorphism1m();


            t.passenger("senthil kumar M");
            t.passenger("senthil kumar ", 20);
            t.passenger("senthil kumar ", 20, "arakkonam ");
                
           

            Console.ReadKey();
        }
    }
}
