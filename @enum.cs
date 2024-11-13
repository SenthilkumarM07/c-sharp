using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //enum is a special class that represents aa group of constants
    //it is a sealed "class" .it cannot be inherited 
    //default enum contains int , it can support bute,sbyte,short,ushort,int,long and ulong.
    //it is value types and they stored in stack memory.

    enum weekdays
    {
        sunday,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday
    }

    enum alpha
    { 
        a,
        b,
        c,
        d=8,
        e,
        f,
        g,
        h=20,
        i,
        j
    }

    class @enum  
    {
        static void Main(string[] args)
        {
            Console.WriteLine(weekdays.friday);

            Console.WriteLine("----------------------");
            foreach(var v in Enum. GetValues(typeof(weekdays)))
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("-----------------------");
            foreach(int v in Enum.GetValues(typeof(alpha)))
            {
                Console.WriteLine(v);
            }
            //converting enum to int
            Console.WriteLine("-----------------------");
            int day = (int)weekdays.friday;
            Console.WriteLine(day);
            Console.WriteLine("-----------------------");

            //converting int to enum
            var d = (weekdays)5;
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }

}
