using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinaliseSpeed
{
    class WithoutDispose
    {
        private Stopwatch stopwatch = null;

        public WithoutDispose()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }

        public void DoWork()
        {
            //Simulate work
            double j = 0;
            for (int i = 0; i < 1000; i++)
            {
                j += i * 1;
            }
        }

        ~WithoutDispose()
        {
            stopwatch.Stop();
            Interlocked.Increment(ref Program.FinalisedObjects);
            Interlocked.Add(ref Program.TotalTime, stopwatch.ElapsedMilliseconds);
        }
    }
}
