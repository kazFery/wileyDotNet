using SGBank.UI.WorkFlows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.UI
{
    public static class Menu
    {
        public  static void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("SG Bank Application");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1.Look up an account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("\nQ to quit");
                Console.WriteLine("\nEnter selection: ");

                string userInput = Console.ReadLine();  
                switch (userInput) 
                {
                    case "1":
                        AccountLookupWorkFlow lookupflow = new AccountLookupWorkFlow();
                        lookupflow.Execute();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "Q":
                        return;
                }



            }
        }
    }
}
