using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //collections---generic collections--no fixed size,  fixed datatype
        //list 
        //stack
        //queue
        //sortedlist
        //dictionary 
    class generic
    {
        static void Main(string[] args)
        {
            //list 
            List<string> a = new List<string>();

            a.Add("senthil");
            a.Add("saanjvu ");
            a.Add("sasi");
            a.Add("prathap");

            foreach (var v in a)
            {
                Console.WriteLine(v.ToString());

            }
            Console.WriteLine("-----------------------------");

            foreach (var v in a)
            {
                Console.WriteLine(v.ToString());

            }
            Console.WriteLine("-----------------------------");

            // queue ---first in first out 

            Queue<char>q=new Queue<char>();


            q.Enqueue('a');
            q.Enqueue('c');
            q.Enqueue('k');
            q.Enqueue('p');
            q.Enqueue('k');
            q.Dequeue();

            foreach (var v in q)
            {
                Console.WriteLine(v.ToString());

            }
            Console.WriteLine("-----------------------------");


            //sorted list (key , value)

            SortedList<int ,string> sl=new SortedList<int ,string>();

            sl.Add(1,"senthil");
            sl.Add(2, "senthil");
            sl.Add(3, "senthil");
            sl.Add(4, "senthil");

            foreach (KeyValuePair<int,string> v in sl)
            {
                Console.WriteLine(v.Key+","+v.Value);

            }
            Console.WriteLine("--------------dictionary---------------");

            //dictionary 

            
            Dictionary<int, string> d = new Dictionary<int, string>();

            d.Add(1, "senthil");
            d.Add(2, "senthil");
            d.Add(3, "senthil");
            d.Add(4, "senthil");

            foreach (KeyValuePair<int, string> v in d)
            {
                Console.WriteLine(v.Key + "," + v.Value);
            }
            Console.ReadKey();
        }
    }
}
