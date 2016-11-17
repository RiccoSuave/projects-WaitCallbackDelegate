using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace waitcallback
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(ThreadProc);
            Console.WriteLine("Main Thread does some work, then sleeps");
            Thread.Sleep(1000);
            Console.WriteLine("Main thread exits");
        }
        private static void ThreadProc (Object StateInfo) {
            Console.WriteLine("Printing from the spunned thread");
            Console.ReadLine();
        }
    }
}
