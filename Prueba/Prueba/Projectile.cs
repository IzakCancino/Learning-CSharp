using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class Projectile : Item
    {
        public double GravityForce { get; set; }

        public Projectile(string Name, string Texture, double GravityForce, int Stack = 64) : base(Name, Texture, Stack)
        {
            this.GravityForce = GravityForce;
        }

        
        public void Throw()
        {
            if (GravityForce < 0)
            {
                for (double i = 1; i > 50; i *= GravityForce)
                {
                    Console.WriteLine($"{Name} is going up (y={i})");
                }
                Console.WriteLine($"{Name} continued up to the infinite");
            }
            else if (GravityForce > 0)
            {
                for (double i = 1; i < 50; i *= GravityForce)
                {
                    Console.WriteLine($"{Name} is going down (y={i})");
                }
                Console.WriteLine($"{Name} continued down to the infinite");
            }
            else
            {
                Console.WriteLine($"{Name} continued to the front infinitely");
            }
        }

        public void Hit()
        {
            Console.WriteLine($"You hit someone with the {Name}!");
        }

        public void Hit(string nickname)
        {
            Console.WriteLine($"You hit {nickname} with the {Name}!");
        }

        public void Hit(int distance)
        {
            Console.WriteLine($"You hit someone with the {Name} from {distance} away!");
        }

        public void Hit(string nickname, int distance)
        {
            Console.WriteLine($"You hit {nickname} with the {Name} from {distance} away!");
        }
    }
}
