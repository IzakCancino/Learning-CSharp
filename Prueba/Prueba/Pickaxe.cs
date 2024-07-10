using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Pickaxe : Tool
    {
        private string Material { get; set; }
        private int Speed = 3;

        public int speed { 
            get { return Speed; }
            set { 
                if (value < 0)
                {
                    throw new Exception("Negative speed");
                }

                Speed = value;
            }
        }
        public int speedInM
        {
            get { return Speed * 1000; }
        }

        public Pickaxe(string Name, string Texture, int Durability, string Material, int Stack = 1) : base(Name, Texture, Durability, Stack)
        {
            this.Material = Material;
        }

        public Pickaxe(string Texture, int Durability, string Material): base(Texture, Durability) 
        {
            this.Name = "Pickaxe Default";
            this.Material = Material;
            this.Stack = 1;
        }

        public void BreakBlock()
        {
            Console.WriteLine($"Something broken with pickaxe of {Material}");
        }

        public override void GetName()
        {
            Console.WriteLine($"I'm a pickaxe called {Name}");
        }
    }
}
