using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTest;


namespace Factorizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            int number;
            //string strNumber = null; ;
            List<int> factors = new List<int>();
            number = UserInput.GetIntFromInput("What number would you like to factor?");
            //Console.Write("What number would you like to factor?");
            //strNumber = Console.ReadLine();
            //while (!int.TryParse(strNumber, out number))
            //{
            //    Console.Write("Please enter a positive number");
            //    strNumber = Console.ReadLine();
            //}
            Console.WriteLine($"The factores of {number} are:");
            factors = GetFactors(number);   
            foreach (int factor in factors)
            {
                Console.Write(factor + " ");
            }
            Console.WriteLine( number);
            if (Isperfect(number, factors))
                Console.WriteLine($"{number} is  perfect number.");
            else
                Console.WriteLine($"{number} is Not perfect number.");
            if (IsPrime(factors))
                Console.WriteLine($"{number} is prime number.");
            else
                Console.WriteLine($"{number} is Not prime number.");

            Console.ReadLine();



        }
        static bool Isperfect(int num, List<int> factors)
        {
            int sum = 0;
            for(int i = 0; i < factors.Count; i++)
            {
                sum +=factors[i];   
            }
            if (sum == num)
                return true;
            return false;

        }
        static bool IsPrime(List<int> factors)
        {
            if (factors.Count == 1 && factors[0] == 1)
                return true;
            return false;
        }

        static List<int> GetFactors(int num)
        {
            List<int> factors = new List<int>();
            for(int i = 1; i < num; i++)
            {
                if (num % i == 0 )
                    factors.Add(i);
            }
            return factors; 
        }
    }
}
