using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Motorcycle : Transport
    {
        public bool CanNitro { get; set; }
        public bool CanDrift { get; set; }

        public Motorcycle() : base()
        {
            CanNitro = false;
            CanDrift = false;
            Console.WriteLine(" => Motorcycle created!");
        }

        public Motorcycle(string id, string model, string color, int wheels, bool canNitro, bool canDrift, int gas)
            : this()
        {
            // Transport attributes
            Id = id;
            Model = model;
            Color = color;
            Wheels = wheels;
            Gas = gas;

            // Motorcycle attributes
            CanNitro = canNitro;
            CanDrift = canDrift;
        }

        public Motorcycle(string id, string model, string color, int wheels, bool canNitro, bool canDrift) 
            : this(id, model, color, wheels, canNitro, canDrift, gas: 0)
        {

        }

        public Motorcycle(string id, string model, string color, int wheels)
            : this(id, model, color, wheels, canNitro: false, canDrift: false, gas: 0)
        {

        }

        public Motorcycle(string id, string model, string color, int wheels, int gas)
            : this(id, model, color, wheels, canNitro: false, canDrift: false, gas)
        {

        }

        public void Nitro()
        {
            if (!CanNitro)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("THIS MOTORCYCLE DOESN'T HAVE NITRO!");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nitro started! (10km)");
            Console.ForegroundColor = ConsoleColor.White;

            if (!MoveForward(10))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("UNABLE TO FINISH THE NITRO!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nitro finished!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Drift()
        {
            if (!CanDrift)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("THIS MOTORCYCLE CAN'T DRIFT!");
                Console.ForegroundColor = ConsoleColor.White;
            }

            if(!MoveForward(1))
            {
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Drifted! You travelled 1km more");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void Crash()
        {
            Console.WriteLine("You crashed (it is too dangerous)!");
        }
    }
}
