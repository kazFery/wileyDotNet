using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseLinqCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> allNumbers = new List<int>()
                        { 4, 2, 3, 7, 15, 20, 6 };

            var onlyOdds = from number in allNumbers
                           where number % 2 == 1
                           select number;
            foreach (var number in onlyOdds)    
                Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
