using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest
{
    public class UserInput
    {
        public static int GetIntFromInput(string prompt)
        {
            int result;

            while (true)
            {

                Console.WriteLine(prompt);
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out result))
                    return result;
                Console.WriteLine("That is not a valid input!!! press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
