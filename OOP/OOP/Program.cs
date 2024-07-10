using System;
using System.ComponentModel;

namespace OOP
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

        static void Main()
        {
            int op = 0;
            Car myCar = new Car("id-car", "cavalier", "orange", 4, 6, 2);
            Motorcycle myMoto = new Motorcycle("id-moto", "perron moto's", "yellow", 2, true, true);
            do
            {
                double distance = 0, gas = 0;
                int aux = 0;

                Console.WriteLine("\n\n\n === Options: (0) close \n[CAR]:(11) move, (12) gas, (13) open trunk, (14) close trunk, (15) crash. \n[MOTO]: (21) move, (22) gas, (23) nitro, (24) drift, (25) crash");
                Console.Write("Action: ");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        return;

                    case 11:
                        Console.WriteLine(" ***** (car) MOVE FORWARD ***** ");
                        Console.WriteLine("Unit (1. Kms, 2. Mi): ");
                        aux = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Distance: ");
                        distance = Convert.ToDouble(Console.ReadLine());
                        myCar.MoveForward(distance, aux);
                        break;

                    case 12:
                        Console.WriteLine(" ***** (car) PUT GAS ***** ");
                        Console.WriteLine("Gas: ");
                        gas = Convert.ToDouble(Console.ReadLine());
                        myCar.PutGas(gas);
                        break;

                    case 13:
                        Console.WriteLine(" ***** (car) OPEN TRUNK ***** ");
                        myCar.OpenTrunk();
                        break;

                    case 14:
                        Console.WriteLine(" ***** (car) CLOSE TRUNK ***** ");
                        myCar.CloseTrunk();
                        break;

                    case 15:
                        Console.WriteLine(" ***** (car) CRASH ***** ");
                        myCar.Crash();
                        break;

                    case 21:
                        Console.WriteLine(" ***** (moto) MOVE FORWARD ***** ");
                        Console.WriteLine("Unit (1. Kms, 2. Mi): ");
                        aux = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Distance: ");
                        distance = Convert.ToDouble(Console.ReadLine());
                        myMoto.MoveForward(distance, aux);
                        break;

                    case 22:
                        Console.WriteLine(" ***** (moto) PUT GAS ***** ");
                        Console.WriteLine("Gas: ");
                        gas = Convert.ToDouble(Console.ReadLine());
                        myMoto.PutGas(gas);
                        break;

                    case 23:
                        Console.WriteLine(" ***** (moto) NITRO ***** ");
                        myMoto.Nitro();
                        break;

                    case 24:
                        Console.WriteLine(" ***** (moto) DRIFT ***** ");
                        myMoto.Drift();
                        break;

                    case 25:
                        Console.WriteLine(" ***** (moto) CRASH ***** ");
                        myMoto.Crash();
                        break;
                }


                Console.WriteLine(" ----- car ----- ");
                PrintObject(myCar);
                Console.WriteLine(" ----- moto ----- ");
                PrintObject(myMoto);
            } while (true);
        }
    }
}