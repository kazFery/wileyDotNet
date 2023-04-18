using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int round = 0; ;
            string strRound;
            string  strChoose = null;
            int userChoose;
            int computerChoose;
            const int ROUND_Max = 10;
            const int ROUND_Min = 1;  
            int userWin = 0;
            int computerWin = 0;
            int tie = 0;

            Console.WriteLine(" Game : Rock Papper Scicesser");
            Console.Write("Please enter number of time you want to play: ");
            strRound = Console.ReadLine();  
            while(!int.TryParse(strRound, out round))
            { 
                Console.WriteLine($"Please enter a number between {ROUND_Min} to {ROUND_Max}");
                strRound = Console.ReadLine();
            }
            if (round > ROUND_Max || round <ROUND_Min)
            {
                Console.WriteLine($"You enter a number out of range [{ROUND_Min} to {ROUND_Max}]");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            Random random = new Random();
            do
            {
                round--;
                Console.WriteLine("Please Enter\n 1: Rock, \n 2: Papper, \n 3: Scicesser");
                strChoose = Console.ReadLine();
                while (!int.TryParse(strChoose, out userChoose))
                {
                    Console.WriteLine("Please enter a number 1 or 2 or 3!!!");
                    strChoose = Console.ReadLine();

                }
                computerChoose = random.Next(1,4);
                Console.WriteLine($"computer choose is {computerChoose}");
                if (computerChoose == userChoose)
                {
                    tie++;
                    continue;
                }
                if ((userChoose == 1 && computerChoose == 3) || (userChoose == 2 && computerChoose == 1) || (userChoose == 3 && computerChoose == 2))
                    userWin++;
                else
                    computerWin++;

            }
            while (round >= ROUND_Min);
            Console.WriteLine($"Number of tie: {tie}");
            Console.WriteLine($"Number of user win: {userWin}");
            Console.WriteLine($"Number of computer win: {computerWin}");
            Console.ReadLine();
            
        }
    }
}
