using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Inventory
{
    class Program
    {
        public static void PrintObject(Object obj)
        {
            Console.WriteLine(" === Object === ");
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(obj);
                Console.WriteLine("{0}={1}", name, value);
            }
            Console.WriteLine(" ============= ");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("STARTING");

            Pickaxe myPickaxe = new Pickaxe("Pico pro", "pico-madera.png", 5, "Madera", 1);
            myPickaxe.Drop();
            myPickaxe.Use();
            myPickaxe.Use();
            myPickaxe.Use();
            myPickaxe.Use();
            myPickaxe.Use();
            myPickaxe.Use();
            myPickaxe.Use();
            myPickaxe.Use();
            myPickaxe.Use();
            myPickaxe.BreakBlock();

            Console.WriteLine("");
            Console.WriteLine("====");
            Console.WriteLine("");

            Projectile mySnow = new Projectile("Bola de nieve", "nieve.png", 2, 16);
            mySnow.Drop();
            mySnow.Throw();

            // Overload
            mySnow.Hit();
            mySnow.Hit("Mago07");
            mySnow.Hit("Veggeta 777", 23);
            mySnow.Hit(12);


            Pickaxe noNamePickaxe = new Pickaxe("pico.jpg", 100, "piedra");
            Console.WriteLine(noNamePickaxe.Name);

            PrintObject(noNamePickaxe);

            myPickaxe.GetName();

            // private proprieties with getters and setters
            Console.WriteLine("Speed: " + myPickaxe.speed);
            myPickaxe.speed = 10;
            Console.WriteLine("Speed: " + myPickaxe.speed);
            Console.WriteLine("Speed: " + myPickaxe.speedInM);
            // myPickaxe.speed = -3;       // has an exception
            // Console.WriteLine("Speed: " + myPickaxe.speed);
        }
    }
}