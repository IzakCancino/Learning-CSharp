using System;

namespace ArraysAndLists
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(" ===== ARRAYS");

            // An array of integers
            int[] arrNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(arrNumbers);

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                Console.WriteLine(arrNumbers[i]);
            }

            // An array of strings
            string[] arrNames = { "Izak", "Pepe", "Jacob" };
            Console.WriteLine(arrNames);

            foreach (var name in arrNames)
            {
                Console.WriteLine($"Hi {name}!");
            }

            Console.WriteLine("\n\n ===== LISTS");

            // A list of integers
            List<int> listNumbers = new List<int>();
            listNumbers.Add(1);
            listNumbers.Add(2);
            listNumbers.Add(3);
            listNumbers.Add(4);
            listNumbers.Remove(3);
            Console.WriteLine(listNumbers);

            foreach (var number in listNumbers)
            {
                Console.WriteLine(number);
            }

            if (listNumbers.Any(x => x % 2 == 0))
                Console.WriteLine("There is an even");
            else
                Console.WriteLine("There isn't any even");

            if (listNumbers.All(x => x > 2))
                Console.WriteLine("All are greater than 2");
            else
                Console.WriteLine("Not all are greater than 2");


            Console.WriteLine("\n\n ===== QUEUES");

            Queue<string> queuePeople = new Queue<string> ();
            queuePeople.Enqueue("Izak");
            queuePeople.Enqueue("Pepe");
            queuePeople.Enqueue("Jacob");

            Console.WriteLine("1. Queue full");
            foreach (var person in queuePeople)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("3. First time out");
            queuePeople.Dequeue();
            foreach (var person in queuePeople)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("2. Second time out");
            queuePeople.Dequeue();
            foreach (var person in queuePeople)
            {
                Console.WriteLine(person);
            }


            Console.WriteLine("\n\n ===== STACKS");

            Stack<string> stackPeople = new Stack<string>();
            stackPeople.Push("Izak");
            stackPeople.Push("Pepe");
            stackPeople.Push("Jacob");

            Console.WriteLine("1. Queue full");
            foreach (var person in stackPeople)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("3. First time out");
            stackPeople.Pop();
            foreach (var person in stackPeople)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("2. Second time out");
            stackPeople.Pop();
            foreach (var person in stackPeople)
            {
                Console.WriteLine(person);
            }
        }
    }
}