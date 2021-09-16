using System;
using System.Runtime;

namespace ServerGC
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;

            if (GCSettings.IsServerGC == true)
                result = "server";
            else
                result = "workstation";
            Console.WriteLine("The {0} garbage collector is running.", result);
        }
    }
}
