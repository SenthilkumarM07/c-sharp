using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace senthil
{
    class ARRAY
    {
        static void Main(string[] agrs)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------TYPE 1-----------------");
            //TYPE 1
            //DATATYPE [] VARIABLE NAME=NEW DATATYPE[SIZE];
            int[] id = new int[5];
            id[0] = 101;
            id[1] = 102;
            id[2] = 103;
            id[3] = 104;
            id[4] = 105;

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("your id is :" + id[i]);
            }

            //type 2---DATATYPE [] VARIABLE NAME={}

            Console.WriteLine("--------------TYPE 2-----------------");

            string[] name = { "senthil", "prathap", "sanjvu", "nithish", "sasi" };

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("name of the student : " + name[i]);
            }

            Console.WriteLine("--------------TYPE 3-----------------");

            //TYPE 3 ----DATATYPE [] VARIABLENAME=NEW DATATYPENAME[SIZE]{VALUES}
            
            char[] initial = new char[5] {'M','V','S','N','T'};

            for (int i = 0; i < initial.Length;i++ )
            {
                Console.WriteLine("initial of std "+name[i]+" is "+ initial[i]);
            }

            Console.WriteLine("--------------TYPE 3-----------------");


            Console.ReadKey();
        }
    }
}
