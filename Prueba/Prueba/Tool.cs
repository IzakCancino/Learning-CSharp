using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Tool : Item
    {
        public int Durability { get; set; }
        public Tool(string Name, string Texture, int Durability, int Stack = 64) : base(Name, Texture, Stack)
        {
            this.Durability = Durability;
        }

        public Tool(string Texture, int Durability) : base(Texture)
        {
            this.Durability = Durability;
        }

        public void Use()
        {
            if (Durability > 0)
            {
                Console.WriteLine($"{Name} used");
                Durability--;
            }

            if (Durability <= 0 ) 
            {
                Console.WriteLine($"{Name} broken");
            }
        }
    }
}
