using System;
using System.Threading;

namespace Finalisers
{
    public class MyObject
    {
        private int _index = 0;

        public MyObject(int index)
        {
            _index = index;
            Console.WriteLine("Constructed object {0} in gen {1}", _index, GC.GetGeneration(this));
        }

        ~MyObject()
        {
            Thread.Sleep(500);
            Console.WriteLine("Finalised object {0} in gen {1}", _index, GC.GetGeneration(this));
        }
    }
}
