using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1-if else
//2-nested if 
//3-else if ladder
namespace senthil
{
    class ifelse
    {
        static void Main(string[] agrs)
        {
            Console.ForegroundColor = ConsoleColor.Green; //---to chage output color
            Console.WriteLine("-----------IF STATEMENT----------");
            //if statement

            if (1 == 1)
            {
                Console.WriteLine("true");
            }
            Console.WriteLine("-----------IF  ELSE STATEMENT---------------");
            //if else statement
            int age;
            Console.WriteLine("Enter your age :");
            age = Convert.ToInt32(Console.ReadLine());  //--to get input fronm the user
            
            if (age >= 18)
            {
                Console.WriteLine("you are eligible to vote");
            }
            else
            {
                Console.WriteLine("sorry you not eligible to vote");
            }

            
            Console.WriteLine("----------- NESTED IF STATEMENT---------------");

            
            //nested if 
            int weight ;
            Console.WriteLine("enter your weight :");
            weight=Convert.ToInt32(Console.ReadLine());
            string bloodgroup;
            Console.WriteLine("enter your bloodgroup");
            bloodgroup = Convert.ToString(Console.ReadLine());
            
            if(weight>60 && weight<100)
            {
                if (bloodgroup == "o+" || bloodgroup == "A+" || bloodgroup == "AB+")
                {
                    Console.WriteLine("you eligible to donate blood to patient no 02");
                }
                else if (bloodgroup == "o+" || bloodgroup == "B+"  || bloodgroup =="B-")
                {
                    Console.WriteLine("you eligible to donate blood to patient no 10");
                }
                else if (bloodgroup == "o+" || bloodgroup == "O-")
                {
                    Console.WriteLine("you eligible to donate blood to patient no 100");

                }
                else
                {
                    Console.WriteLine("you not eligible to donate blood");
                }
            }
            else
            {
                Console.WriteLine("sorry your are weight no suitable to donate blood  ");
            }

            Console.WriteLine("--------------else if ladder--------------");

            //else if ladder

            Console.WriteLine("enter your mark ");
            int mark;
            mark = Convert.ToInt32(Console.ReadLine());
            
            if (mark >= 0 && mark<50)
            {
                Console.WriteLine("sorry you are fail");
            }
            else if(mark >= 50 && mark <60)
            {
                Console.WriteLine("your grade is B");
            }
            else if(mark >= 60 && mark <70)
            {
                Console.WriteLine("your grade is B+");
            }
            else if(mark >= 70 && mark <80)
            {
                Console.WriteLine("your grade is A");
            }
            else if(mark >= 80 && mark <90)
            {
                Console.WriteLine("your grade is A+");
            }
            else if (mark >= 90 && mark < 100)
            {
                Console.WriteLine("your grade is O");
            }
            else if (mark == 100)
            {
                Console.WriteLine("your grade is O++");
            }
            else
            {
                Console.WriteLine("sorry invalid number");
            }

            // multiple if 
 
            Console.WriteLine("------------MULTIPLE IF --------------");
            if (mark >= 0 && mark < 50)
            {
                Console.WriteLine("sorry ou are fail");
            }
            if (mark >= 50 && mark < 60)
            {
                Console.WriteLine("your grade is B");
            }
            if (mark >= 60 && mark < 70)
            {
                Console.WriteLine("your grade is B+");
            }
            if (mark >= 70 && mark < 80)
            {
                Console.WriteLine("your grade is A");
            }
            if (mark >= 80 && mark < 90)
            {
                Console.WriteLine("your grade is A+");
            }
            if (mark >= 90 && mark < 100)
            {
                Console.WriteLine("your grade is O");
            }
            if (mark == 100)
            {
                Console.WriteLine("your grade is O++");
            }
            else
            {
                Console.WriteLine("sorry invalid number");
            }
            




            Console.ReadKey();
        }
    }

}