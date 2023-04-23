using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinBattle
{
    internal class Goblin
    {
        private static Random _rng = new Random();
        private const int maximumDamage = 4;
        private int _hitPoints;
        private bool _isDead;

        //private string _name;
        //public  string Name {
        //    get { return _name; }
        //    set { _name = value; }
        //}

        public string Name
        {
            get;
            set;
        }

        public int Hitpoints
        {
            get { return _hitPoints; }
            set { if (value> 0) _hitPoints = value; }
        }

        public bool IsDead { get { return _isDead; }}

        public void Attack(Goblin target)
        {
            int damage = _rng.Next(maximumDamage+1);
            Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage!");
            target.Hit(damage);
        }

        public void Hit(int damage)
        {
            _hitPoints -= damage;
            Console.WriteLine($"{Name} recives {damage} damage. They have {_hitPoints} health.");
            if (_hitPoints <= 0)
            {
                Console.WriteLine($"{Name} Has died!");
                _isDead = true;
            }
        }

    }
}
