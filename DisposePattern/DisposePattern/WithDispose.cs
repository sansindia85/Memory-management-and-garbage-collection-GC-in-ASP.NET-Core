using System;
using System.Diagnostics;
using System.Threading;

namespace DisposePattern
{
    public class WithDispose : IDisposable
    {
        private Stopwatch stopwatch = null;
        private bool disposed = false;

        public WithDispose()
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

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                stopwatch.Stop();
                Interlocked.Increment(ref Program.FinalisedObjects);
                Interlocked.Add(ref Program.TotalTime, stopwatch.ElapsedMilliseconds);

                if (disposing)
                {
                    //explicitly called from user code
                }
                else
                {
                    //called from finaliser
                }

                disposed = true;
            }
        }

        ~WithDispose()
        {
            Dispose(false);
        }
    }
}
