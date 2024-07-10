using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Transport
    {
        public string? Id { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public int Wheels { get; set; }
        public double Gas { get; set; }

        private double Distance;
        public double distanceKm
        {
            get { return Distance; }
            set { Distance = value; }
        }
        public double distanceMi
        {
            get { return Distance / 1.609; }
            set { Distance = value * 1.609;  }
        }

        public Transport()
        {
            Wheels = 1;
            Gas = 0;
            Distance = 0;
            Console.WriteLine(" => Transport created!");
        }

        public Transport(string id, string model, string color, int wheels, double gas) : this()
        {
            Id = id;
            Model = model;
            Color = color;
            Wheels = wheels;
            Gas = gas;
        }

        public Transport(string id, string model, string color, int wheels)
            : this(id, model, color, wheels, gas: 0)
        {

        }

        public bool MoveForward(double distance, int? unit = 1)
        {
            const int OIL_FOR_KM = 2;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A {distance}km travel started!");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 1; i <= distance; i++)
            {
                double oilForStep = (unit == 1 ? OIL_FOR_KM : OIL_FOR_KM / 1.609);
                if (Gas >= oilForStep)
                {
                    if (unit == 1)
                    {
                        distanceKm++;
                    }
                    else
                    {
                        distanceMi++;
                    }

                    Gas -= oilForStep;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"You have traveled {distanceKm}km");
                    Console.ForegroundColor = ConsoleColor.White;
                } 
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NOT ENOUGH OIL!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return false;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Arrived!");
            Console.ForegroundColor = ConsoleColor.White;

            return true;
        }

        public void PutGas(double gas)
        {
            Gas += gas;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Now you have {Gas}L of gas");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public virtual void Crash()
        {
            Console.WriteLine("You crashed!");
        }
    }
}
