using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldSample
{
    internal class Program
    {
        static void Main(string[] args)


        {

            Random randomizer = new Random();

            Console.WriteLine("Random can make integers: " + randomizer.Next());
            Console.WriteLine("Or a double: " + randomizer.NextDouble());

            int num = randomizer.Next(101);

            Console.WriteLine("You can store a randomized result: " + num);
            Console.WriteLine("And use it over and over again: " + num + ", " + num);

            Console.WriteLine("Or just keep generating new values");
            Console.WriteLine("Here's a bunch of numbers from 0 - 100: ");

            Console.WriteLine(randomizer.Next(101) + ",");
            Console.WriteLine(randomizer.Next(101) + ",");
            Console.WriteLine(randomizer.Next(101) + ",");
            Console.WriteLine(randomizer.Next(101) + ",");
            Console.WriteLine(randomizer.Next(101) + ",");
            Console.WriteLine(randomizer.Next(101));

            StringBuilder sb = new StringBuilder("abcd");
            String str1 = "abcd";
            String str2 = null;
            Object o2 = null;
         //   string str3 = new string("absd");

            Console.WriteLine();
            Console.WriteLine(" *  The value of String str1 is '{0}'.", str1);
            Console.WriteLine(" *  The value of StringBuilder sb is '{0}'.", sb.ToString());

            Console.WriteLine();
            Console.WriteLine("1a) String.Equals(Object). Object is a StringBuilder, not a String.");
            Console.WriteLine("    Is str1 equal to sb?: {0}", str1.Equals(sb));

            Console.WriteLine();
            Console.WriteLine("1b) String.Equals(Object). Object is a String.");
            str2 = sb.ToString();
            o2 = str2;
            Console.WriteLine(" *  The value of Object o2 is '{0}'.", o2);
            Console.WriteLine("    Is str1 equal to o2?: {0}", str1.Equals(o2));

            Console.WriteLine();
            Console.WriteLine(" 2) String.Equals(String)");
            Console.WriteLine(" *  The value of String str2 is '{0}'.", str2);
            Console.WriteLine("    Is str1 equal to str2?: {0}", str1.Equals(str2));

            Console.WriteLine();
            Console.WriteLine(" 3) String.Equals(String, String)");
            Console.WriteLine("    Is str1 equal to str2?: {0}", String.Equals(str1, str2));
            Console.ReadLine();
            //Static members cannot access instance members in their code blocks.Instance members can access static members in their code blocks.
        }
    }
}
