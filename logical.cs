using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senthil
{
    class logical
    {
        static void Main(string[] agrs)
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            
            ////factorial
            //Console.WriteLine("----------------factorial----------------------");
            //Console.WriteLine("enter the number :");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int fact = 1;

            //for (int i = 1; i <= num; i++)
            //{
            //    fact *= i;
            //}

            //Console.WriteLine("factorial of " + num + " is  " + fact);

            //Console.WriteLine("---------------fibonacci ------------------");
            ////fibonacci 

            //int num1 = 1;
            //int num2 = 1;
            //int num3;
            //Console.Write("faboacci numbers are : "+num1 + " , " + num2 + " , ");

            //for (int i = 2; i <= 5; i++)
            //{
            //    num3 = num1 + num2;
            //    Console.Write(num3 + ",");
            //    num1 = num2;
            //    num2 = num3;
            //}
            ////amstrong number

            //Console.WriteLine();
            //Console.WriteLine("--------------amstrong number------------------");


            //Console.WriteLine("enter the value of n :");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int temp=n;
            //int sum = 0;
            //int r;
            //while(n>=1)
            //{
            //    r = n % 10;
            //    sum += r * r * r;
            //    n = n / 10;
            //}

            //if (sum == temp)
            //{
            //    Console.WriteLine(sum+" is a amstrong number ");
            //}
            //else
            //{
            //    Console.WriteLine(sum+" is not a amstrong number");
            //}
             
            ////palindrome using int

            //Console.WriteLine("----------palindrome using int------------------");
            //Console.WriteLine("enter the number to check palindrome : ");
            //int number=Convert.ToInt32(Console.ReadLine());
            //int temp1 = number;
            //int sum1 = 0;
            //int r1;

            //while (number >= 1)
            //{
            //    r1 = number % 10;
            //    sum1 = (sum1 * 10) + r1;
            //    number = number / 10;
            //} 

            //if (sum1 == temp1)
            //{
            //    Console.WriteLine(sum1+"  it is a  palindrome ");
            //}
            //else
            //{
            //    Console.WriteLine(sum1+"  it is not a palindrome number");
            //}
            
            Console.WriteLine("--------------palindrome using string---------------------");
             
            //palindrome using string

            //Console.WriteLine("enter the letter :");
            //string word = Console.ReadLine();
            //string reverse = "";
            //int wordlength = word.Length;
            //for (int i = (wordlength - 1); i >= 0; i--)
            //{
            //    reverse = reverse + word.charAt(i);
            //}

            //if (word == reverse)
            //{
            //    Console.WriteLine(word + "  it is a  palindrome ");
            //}
            //else
            //{
            //    Console.WriteLine(word + "  it is not a palindrome number");
            //}
                
            Console.WriteLine("enter the letter :");
            string word = Console.ReadLine();
                
            string reversed = new string(word.Reverse().ToArray());

                
            if (word == reversed)    
            {

                Console.WriteLine("it is a palindrome");
            }    
            else
            {

                Console.WriteLine("it is not a palindrome");
            }
                
            //odd or even
                
                //Console.WriteLine("----------------odd or even------------");
                //for (int i = 0; i < 10;i++ )
                //{
                //    if (i % 2 == 0)
                //    {
                //        Console.WriteLine(i + "  is even");
                //    }
                //    else
                //    {
                //        Console.WriteLine(i + "  is odd");
                //    }
                //}

                
                ////prime no

            Console.WriteLine("----------------prime no ------------");
            Console.WriteLine("enter the number to check prime or not :");
            int numb = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= numb; i++)
            {
                if (numb % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine(numb + " is a prime number");
            }
            else
            {
                Console.WriteLine(numb + " is  not a prime number");
            }
                
                Console.ReadKey();
        }
    }
}
