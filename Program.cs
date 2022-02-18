using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LimitExceeded : Exception
    {
        public override string Message
        {
            get
            {
                return "amount limit exceeded";
            }
        }

        public class test1
        {

            static void Main(string[] args)
            {
                while(true)
                { 
                string accounttype;
                Console.WriteLine("enter account type");
                accounttype = Console.ReadLine();
                
                    
                    try
                    {
                        switch (accounttype)
                        {

                            case "savings account":
                                Console.WriteLine("you chose savings account/n");
                                Console.WriteLine("enter deposit amount");
                                int amount;
                                amount = int.Parse(Console.ReadLine());
                                if (amount > 100000)
                                    throw new LimitExceeded();
                                Console.WriteLine(" amount deposited ");
                                break;

                            case "current account":
                                Console.WriteLine("you chose current account/n");
                                Console.WriteLine("enter deposit amount");
                                amount = int.Parse(Console.ReadLine());
                                if (amount > 100000)
                                    throw new LimitExceeded();
                                break;
                            case "child account":
                                Console.WriteLine("you chose child account/n");
                                Console.WriteLine("enter deposit amount");
                                amount = int.Parse(Console.ReadLine());
                                if (amount > 50000)
                                    throw new LimitExceeded();
                                break;
                        }
                    }
                    catch (LimitExceeded e)

                    {
                        Console.WriteLine(e.Message);
                        
                       Console.ReadKey();
                    }


                }


            }

        }
    }
}
    


