using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public  override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
    class polymorphism2
    {
        static void Main(string[] args)
        {
            Pig p = new Pig();
            Dog d = new Dog();
            p.animalSound();
            d.animalSound();

            markdetails md = new markdetails();
            student1 s1 = new student1();
            student2 s2 = new student2();
            student3 s3 = new student3();

            md.total(80, 88, 99, 89, 87);
            s1.total(80,88,99,89,87);
            s2.total(80, 88, 99, 89, 87);
            s3.total(80, 88, 99, 89, 87);



            Console.ReadKey();
        }
    }
    class markdetails
    {
        public virtual void total(int t, int e, int m, int s, int ss)
        {
            int res = t + e + m + s + ss;
            Console.WriteLine("Tamil:" + t + ", English :" + e + ", Maths:" + m + " ,Science:" + s + " ,Social science:" + ss);
            Console.WriteLine("totalhdh:" + res);
        }

    }

    class student1:markdetails
    {
        public override void total(int t, int e, int m, int s, int ss)
        {
            int res = t + e + m + s + ss;
            Console.WriteLine("Tamil:" + t + ", English :" + e + ", Maths:" + m + " ,Science:" + s + " ,Social science:" + ss);
            Console.WriteLine("total asfd:" + res);

        }

    }

    class student2:markdetails
    {
        public  override void total(int t, int e, int m, int s, int ss)
        {
            int res = t + e + m + s + ss;
            Console.WriteLine("Tamil:" + t + ", English :" + e + ", Maths:" + m + " ,Science:" + s + " ,Social science:" + ss);
            Console.WriteLine("totalgdhdfjf:" + res);
        }

    }

    class student3:markdetails
    {
       public override void total(int t, int e, int m, int s, int ss)
        {
            int res = t + e + m + s + ss;
            Console.WriteLine("Tamil:" + t + ", English :" + e + ", Maths:" + m + " ,Science:" + s + " ,Social science:" + ss);
            Console.WriteLine("tot fndal:" + res);
        }

    }
}
