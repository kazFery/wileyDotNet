using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Goblin goblinPlayer = new Goblin();
            Goblin goblinOther = new Goblin();

            goblinPlayer.Hitpoints = 10;
            goblinPlayer.Name = "Bob";

            goblinOther.Hitpoints = 10;
            goblinOther.Name = "Tom";

            while (!goblinPlayer.IsDead && !goblinOther.IsDead)
            {
                goblinPlayer.Attack(goblinOther);
                // swap players        
                Goblin goblinTemp = goblinPlayer;
                goblinPlayer = goblinOther;
                goblinOther = goblinTemp;
            }

            Console.WriteLine("The battle is ended!");
            Console.ReadLine();
        }
    }
}
