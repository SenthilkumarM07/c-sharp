using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senthil
{
    class assignment
    {
        static void Main(String[] agrs)
        {
            Console.WriteLine("-----------------(1)Odd or Even----------------------------------");

            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " is even");
                }
                else
                {

                    Console.WriteLine(i + " is odd");
                }
            }

            Console.WriteLine("-------------------------2.print 1 to 100 Even number-------------------");

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ",");
                }

            }
            Console.WriteLine();
            Console.WriteLine("--------------------3.print 1 to 10 odd number----------------------------------");

            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i + " is odd");
                }

            }
            Console.WriteLine("------------------------4.Factorial number from 1 to 5:---------------------------------------");

            int fact = 1;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(fact *= i);
            }

            Console.WriteLine("----------------------------5.Even number count from 1 to 100------------------------------------------");

            int count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                }

            }

            Console.WriteLine("the even number count are :" + count);


            Console.WriteLine("------------------6.Odd number count from 1 to 1000------------------------------------------");

            int count1 = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 != 0)
                {
                    count1++;
                }

            }

            Console.WriteLine("the odd number count are :" + count1);

            Console.WriteLine("------------------------------7.Sum of Even number from 1 to 500---------------------------------------------");

            int sum = 0;

            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }

            Console.WriteLine("Sum of Even number from 1 to 500:" + sum);

            Console.WriteLine("----------------------------8.Sum of odd number from 1 to 100-----------------------------------------------");


            int sum1 = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    sum1 = sum1 + i;
                }
            }
            Console.WriteLine("Sum of odd number from 1 to 100:" + sum1);

            Console.WriteLine("-------------------------------------9.Sum of the number from 1 to 600------------------------------------------");

            int sum2 = 0;
            for (int i = 1; i <= 600; i++)
            {
                sum2 += i;
            }

            Console.WriteLine("Sum of the number from 1 to 600 " + sum2);

            Console.WriteLine("-------------------------------------10.Reverse the number----------------------------------------------");

            //int num = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("------------------------------------11.Palindrome number or not---------------------------------------------");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int temp = num1;
            int summ = 0;
            int r;

            while (num1 > 0)
            {
                r = num1 % 10;
                summ = (summ * 10) + r;
                num1 = num1 / 10;

            }

            if (summ == temp)
            {
                Console.WriteLine(summ + "  it is a  palindrome ");
            }
            else
            {
                Console.WriteLine(summ + "  it is not a palindrome number");
            }

            Console.WriteLine("--------------------------------12.Print the palindrome number from 1 to 1000--------------------------------");

            Console.WriteLine("-----------------------------------------13.Amstrong number or not-----------------------------------------");

            int a = Convert.ToInt32(Console.ReadLine());
            int eq = a;
            int ams = 0;
            int rem;

            while (a > 0)
            {
                rem = a % 10;
                ams = ams + rem * rem * rem;
                a = a / 10;
            }

            if (ams == eq)
            {
                Console.WriteLine("it is a amstrong number");
            }
            else
            {
                Console.WriteLine("it is not a amstrong number");
            }
            Console.WriteLine("------------------------------------14.Print amstrong number from 1 to 600------------------------------------------");


            Console.WriteLine("------------------------------------15.Count the digit------------------------------------------");
            Console.WriteLine("------------------------------------16.Sum of the digit:------------------------------------------");
            Console.WriteLine("--------------------------17.Swape the 2 number with using 3rd variable name------------------------------------");
            Console.WriteLine("------------------------------------18.Swape the 2 number without using 3rd variable name------------------------");
            Console.WriteLine("------------------------------------19.Fibanocii series from 1 to 10:-----------------------------------------");
            Console.WriteLine("-----------------------------------20.print the fabanocii series sum from 1 to 10:-----------------------------------------");
            Console.WriteLine("------------------------------------21.Reverse the string --String name = Welcome-----------------------------------------");
            Console.WriteLine("-----------------------------------22.Palindrome String or not:  String name = madam---------------------------------------");
            Console.WriteLine("------------------------------------23.Asc order:  int a[] = { 10, 100, 90, 20, 40 }---------------------------------------");
            Console.WriteLine("------------------------------------24.Desc Order:  int a[] = { 10, 100, 90, 20, 40 }-----------------------------------------");
            Console.WriteLine("-----------------------------------25.Max and Min number in given array: int a[] = { 10, 100, 90, 20, 40 }---------------------------------------");
            Console.WriteLine("------------------------------26.Vowels count:  String name = Welcome-----------------------------------------");
            Console.WriteLine("-----------------------------------27.Consonants  and vowels count: String name = Welcome----------------------------------------");
            Console.WriteLine("-----------------------------------28.print the vowels and consonants seperately:  String name = Welcome-----------------------------------------");
            Console.WriteLine("----------------------29.Count of each character in given String: String name = Welcome-------------------------------------");
            Console.WriteLine("--------------30.Count of the word in a given String: String name = Welcome to java sql java to java sql plsq----------------------------------------");
           Console.ReadKey();

        }
    }
}
