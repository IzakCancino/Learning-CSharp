using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Car : Transport
    {
        public int Seats { get; set; }
        public int Doors { get; set; }
        public bool Trunk { get; set; }

        public Car() : base()
        {
            Seats = 1;
            Doors = 1;
            Trunk = false;
            Console.WriteLine(" => Car created!");
        }

        public Car(string id, string model, string color, int wheels, int seats, int doors, int gas) 
            : this()
        {
            // Transport attributes
            Id = id;
            Model = model;
            Color = color;
            Wheels = wheels;
            Gas = gas;

            // Car attributes
            Seats = seats;
            Doors = doors;
        }

        public Car(string id, string model, string color, int wheels, int seats, int doors)
            : this(id, model, color, wheels, seats, doors, gas: 0)
        {

        }

        public void OpenTrunk()
        {
            if (!Trunk)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Trunk opened!");
                Console.ForegroundColor = ConsoleColor.White;

                Trunk = true;
                return;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TRUNK ALREADY OPENED!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void CloseTrunk()
        {
            if (Trunk)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Trunk closed!");
                Console.ForegroundColor = ConsoleColor.White;

                Trunk = false;
                return;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TRUNK ALREADY CLOSED!");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
