using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class atm_swithcase
    {
        static void Main(string[] args)
        {
            int amt = 10000; //balance
            int pin = 2024; //pin

            
            Console.WriteLine("enter your pin ");
            int entered_pin = Convert.ToInt16(Console.ReadLine());

            if (entered_pin == pin)
            {
                Console.WriteLine("1.Check balance ");
                Console.WriteLine("2.Withdraw");
                Console.WriteLine("3.Deposit");
                Console.WriteLine("4.changepin");
                Console.WriteLine("5.exit");

                Console.WriteLine("select your option ");
                int choice = Convert.ToInt16(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        Console.WriteLine("your accout balance amount is :" + amt);
                        break;

                    case 2:
                        Console.WriteLine("enter the withdraw amount ");
                        int withdrawAmount = Convert.ToInt16(Console.ReadLine());
                        if (withdrawAmount % 100 == 0 && withdrawAmount <= amt)
                        {
                            Console.WriteLine("your amount successfully withdrawed");
                        }
                        else if (withdrawAmount % 100 != 0)
                        {
                            Console.WriteLine(" sorry !!!you entered invalid amount ");
                        }
                        else
                        {
                            Console.WriteLine("sorry !!you entered more amount than your balance");
                        }
                        break;

                    case 3:
                        Console.WriteLine("enter the deosit amount :");
                        int depositamount = Convert.ToInt16(Console.ReadLine());

                        if (depositamount % 100 == 0 && depositamount <= 40000)
                        {
                            amt = amt + depositamount;
                            Console.WriteLine("your " + depositamount + " successfully deposited , now you balance amount is :" + amt);
                        }
                        else
                        {
                            Console.WriteLine("sorry !!! your amount is greater than  one deposit limit ");
                        }
                        break;


                    case 4:
                        Console.WriteLine("enter your new pin number ");
                        int newpin = Convert.ToInt16(Console.ReadLine());
                        pin = newpin;
                        Console.WriteLine("your pin changed sucessfully !! ");
                        break;


                    case 5:
                        Console.WriteLine("ThankYou for visiting!!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("sorry you enterd wrong pin number");
            }
            Console.ReadKey();

        }
    }


}

