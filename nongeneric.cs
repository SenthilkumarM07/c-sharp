using System;
using System.Collections.Generic;//generic
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;//non generic

namespace ConsoleApplication1
{
    class nongeneric
    {
        //collections---non generic collections--no fixed size, no fixed datatype
        //Array list
        //stack
        //queue
        //sortedlist
        //hashtable 
        

        static void Main(string[] args)
        {

            //1)ArrayList
            ArrayList l = new ArrayList();
            l.Add(1);
            l.Add("senthil");
            l.Add(true);
            l.Add('S');
            l.Add(90.22);

            
            foreach(var v in l)
            {
                Console.WriteLine(v.ToString());
            }
            Console.WriteLine("====================================");

            //
            ArrayList l1 = new ArrayList();
            l1.Add(2);
            l1.Add("sanjvu");
            l1.Add(true);
            l1.Add('V');
            l1.Add(99.89);
            
            l.AddRange(l1);
            foreach (var v in l1)
            {
                Console.WriteLine(v.ToString());
            }
            Console.WriteLine("=====================================");
           
            
            ArrayList l2 = new ArrayList();
            l2.Add(3);
            l2.Add("prathap");
            l2.Add(true);
            l2.Add('S');
            l2.Add(99.89);

            l.AddRange(l2);
            foreach (var v in l2)
            {
                Console.WriteLine(v.ToString());
            }

            Console.WriteLine("==========================");
            l.Insert(2, "arakkonam");

            foreach (var v in l)
            {
                Console.WriteLine(v.ToString());
            }
            Console.WriteLine("=============================");
            //l.Remove(1);
            //l.RemoveAt(3);
            //l.RemoveRange(0, 4);

            foreach (var v in l)
            {
                Console.WriteLine(v.ToString());
            }
            Console.WriteLine("=========================");
            Console.WriteLine("count :"+l.Count);
            Console.WriteLine("capacity :"+l.Capacity);
            Console.WriteLine("=========================");

            if (l.Contains("senthil"))
            {
                Console.WriteLine("it already exists");
            }
            else
            {
                l.Add("senthil");
            }
            Console.WriteLine("=========================");
            Console.WriteLine("Index :"+l.IndexOf("senthil"));
            Console.WriteLine("Index :" + l.IndexOf(2));

            Console.WriteLine("last index :"+l.LastIndexOf(3));

            Console.WriteLine("------------stack ---------------");
            //stack --- last in first out 
            Stack s = new Stack();
            s.Push(1);
            s.Push("senthil");
            s.Push(20);
            s.Push("cse");
            s.Push("veltech");
            s.Push(85.88);
            s.Push("avadi");
            s.Pop(); // to remove first element of the stack
            Console.WriteLine(s.Peek());// to print peak values 
            foreach(var v in s)
            {
                Console.WriteLine(v.ToString());
            }


            Console.WriteLine("------------queue---------------");
           //queue --first in first out 
            
           Queue q = new Queue();
           q.Enqueue(1); //To add 
           q.Enqueue("senthil");
           q.Dequeue();//to remove

           foreach (var v in q)
           {

               Console.WriteLine(v);
           }

        
            Console.WriteLine("------------sorted list ---------------------");
            //sorted list -- key ,value 
            //in sorterd list  we  cannot change key values
            //sorted list does not allow duplicate values in key but it allow duplicate in values{}----{key ,value}
            //capital letter has higest priority

            SortedList so = new SortedList();
            so.Add('a',"apple");
            so.Add('Z',"ball");
            so.Add('c', "cat");
            so.Add('g', "ball");
            so.Add('y', "yellow");
            so.Add('z', "zebra");

            foreach (DictionaryEntry d in so)
            {
                Console.WriteLine(d.Key + "," + d.Value);

            }
           //Hashtable 

            Console.WriteLine("------HashTable----------");

            Hashtable names = new Hashtable();
            names.Add(1,"senthil");
            names.Add(2, "sanjvu");  
            names.Add(3, "prathap");
            names.Add(4, "nithish");
            names.Add(5, "manoj");
            names.Add(6, "sasi");

            foreach (DictionaryEntry d in names)
            {
                Console.WriteLine(d.Key + "," + d.Value);
                
            }


            Console.ReadKey();
        }
    }
}
