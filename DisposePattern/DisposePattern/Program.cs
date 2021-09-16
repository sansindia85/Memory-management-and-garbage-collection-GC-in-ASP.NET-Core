using System;

namespace DisposePattern
{
    class Program
    {
        public static long FinalisedObjects = 0;
        public static long TotalTime = 0;
        static void Main(string[] args)
        {
            for (int i = 0; i < 500000; i++)
            {
                using var obj = new WithDispose();
                //var obj = new WithDispose();
                obj.DoWork();
            }

            double avgLifetime = 1.0 * TotalTime / FinalisedObjects;
            Console.WriteLine("Number of disposed/finalised objects: {0}k", FinalisedObjects);
            Console.WriteLine("Average resource lifetime: {0}ms", avgLifetime);

        }
    }
}
