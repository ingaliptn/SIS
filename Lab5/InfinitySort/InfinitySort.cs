using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace InfinitySort
{
    public class InfinitySort
    {
        public static void Thread()
        {
            List<Thread> threads = new List<Thread>();
            var threadDelegate = new ThreadStart(ArrSort);

            for (int i = 0; i < 10000; i++)
            {
                Thread thread = new Thread(threadDelegate) { IsBackground = true };
                thread.Start();
            }
        }

        public static void InfiniteThread()
        {
            var threadDelegate = new ThreadStart(ArrSort);
            Thread newThread = new Thread(threadDelegate) { IsBackground = true };
            do
            {
                newThread.Start();
            } while (true);
        }
        private static double[] ArrCreate()
        {
            var A = new double[100000];
            var rand = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rand.Next(0, 1000);
            }
            return A;
        }
        private static void ArrSort()
        {
            var B = ArrCreate();
            Array.Sort(B);
        }
    }
}
