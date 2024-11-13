using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senthil
{
    //variable --(int ,string,char,bool,double,float)
    //(1)local variable and (2)instance variable

    class variabletype
    {
        //instance variable == inside class outside method
        int stdid;
        string name;
        char initial;
        float percentage;
        string college_name;
        static string college_city = "avadi";
        static void Main(string[] args)
        {
            //classname objectname=new classname(); -------object creation 
            variabletype s = new variabletype();
            s.stdid = 1;
            s.name = "senthil";
            s.initial = 'M';
            s.percentage = 83.75f;
            s.college_name = "veltech";
            
            //---------object 2
            variabletype  s1=new   variabletype();
            s1.stdid = 1;
            s1.name = "prathap";
            s1.initial = 'S';
            s1.percentage = 89.75f;
            s1.college_name = "veltech hightech";
            //-------object 3

            variabletype s2 = new variabletype();
            s2.stdid = 3;
            s2.name = "sanjvu";
            s2.initial='V';
            s2.percentage = 87.45f;
            s2.college_name = "veltechmulti tech";



            Console.WriteLine(s.stdid+","+s.name+","+s.initial+","+s.percentage+","+s.college_name+","+variabletype.college_city);
            Console.WriteLine(s1.stdid+","+s1.name+","+s1.initial+","+s1.percentage+","+s1.college_name);
            Console.WriteLine(s2.stdid+","+s2.name+","+s1.initial+","+s2.percentage+","+s2.college_name);
            Console.ReadKey();
        }
    }
}
  