using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBizz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Execute();
            Console.ReadLine();
        }

        static void Execute()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                    Console.WriteLine(i);
                else if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine($"{i} FizzBizz");
                else if (i % 3 == 0)
                    Console.WriteLine($"{i} Fizz");
                else Console.WriteLine($"{i} Bizz");


            }
        }
    }
}
