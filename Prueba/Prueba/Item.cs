using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Item
    {
        public string Name { get; set; }
        public string Texture {  get; set; }
        public int Stack { get; set; }

        public Item(string Name, string Texture, int Stack = 64)
        {
            this.Name = Name;
            this.Texture = Texture;
            this.Stack = Stack;
        }
        public Item(string Texture)
        {
            this.Texture = Texture;
        }

        public void Drop()
        {
            Console.WriteLine($"{Name} dropped!");
        }

        public virtual void GetName()
        {
            Console.WriteLine(Name);
        } 
    }
}
