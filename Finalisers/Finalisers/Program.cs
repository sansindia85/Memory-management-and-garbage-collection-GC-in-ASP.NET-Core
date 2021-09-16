using System;

namespace Finalisers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (!Console.KeyAvailable)
            {
                new MyObject(count++);
            }

            Console.WriteLine("Terminating process...");
            Console.WriteLine("Do not press enter again.");
            Console.ReadLine();
        }
    }
}
