using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senthil
{
    class operators
    {
        static void Main(string[] args)
        {
            //arithmetic operator (+,-,*,/,%)

            int a = 10;
            int b = 25;
            int add = a + b;
            int sub = a - b;
            int mul = a * b;
            int div = a / b;
            int rem = a % b;

            Console.WriteLine("addition of a and b is: "+add);
            Console.WriteLine("subraction of a and b is: " +sub);
            Console.WriteLine("multiplication of a and b is: " + mul);
            Console.WriteLine("division of a and b is: " + div);
            Console.WriteLine("remainder of a and b is: " + rem);
            Console.WriteLine("--------------------------------");
            
            //assignment operator(+=,-=,*=,/=,%=)
            int c = 150;
            int d = 20;
            int e = 80;
            int f = 110;
            int g = 920;
            c += 5;  //c=c+5  ,c=150+5,c=155
            d -= 1;  //d=d-1 , d=20-1 ,d=19
            e *= 10;  //e=e*10 ,e=80*10, e=800
            f /= 5; //f=f/5 ,f=110/5, f=20
            g %= 6; //g=g%6 

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine("--------------------------");

            //right shift operator(>>) ----(/ is used in this operator)

            Console.WriteLine (a>>2); //10/2^2, 10/4, 2
            Console.WriteLine(100>>3); //100/2^3 , 100/8, 12
            Console.WriteLine(250>>5); //250/2^5,250/32,7
            Console.WriteLine("----------------------------");


            //left shift operator(<<)---------( * is used in this operator)

            Console.WriteLine(100<<2); //100*2^2 ,100*4,400
            Console.WriteLine(10<<5); //10*2^5 ,10*32 , 320 
            Console.WriteLine("----------------------------");

            //unary operator( prifix--(a++,a--),postfix--(++a,--a))

            //a++,a-- it first give value of x and then added and stored in refrerence memory  

            int x = 18;
            Console.WriteLine(x++);  //first give result and add 
            Console.WriteLine(x);
            Console.WriteLine(x--);
            Console.WriteLine(x);
            Console.WriteLine("----------------------------");
            //++a,--a it first store added value  in refrerence memory and diplay the output   

            int y = 43;
            Console.WriteLine(--y);
            Console.WriteLine(y);
            Console.WriteLine(++y);
            Console.WriteLine(y);


            Console.ReadKey();
        }
    }
}
