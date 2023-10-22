using System;
using System.Threading;
using System.Security.Permissions;



namespace Lesson_22_05._10._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Race Condition
            //for (int i = 0; i < 10; i++)
            //{
            //    new Thread(() => Console.WriteLine(i)).Start();
            //}
            //CPU anlamir ki, hansini isledib ya yox.
            //mutleq shekilde hemin i-ni bir deyishene menimsetmek lazimdir

            //for (int i = 0; i < 10; i++)
            //{
            //    int temp = i;
            //    new Thread(() => Console.WriteLine(temp)).Start();
            //}
            #endregion

            #region Abort, Join, Sleep, Priority
            //Thread t1 = new Thread(TestX);
            //t1.Start();
            ////t1.Abort();

            //Thread t2 = new Thread(TestY);
            //t2.Start();

            ////Join
            //Thread t3 = new Thread(TestZ);
            //t3.Start();
            //t3.Join();
            //Console.WriteLine("Work completed");

            ////Sleep
            //for (int i = 0; i < 10; i++)
            //{
            //   Console.WriteLine(i + " xxxxxx");
            //    Thread.Sleep(2000);
            //}

            //// Priority
            //Thread t4 = new Thread(TestZ);
            //t4.Start();
            //t4.Priority = ThreadPriority.Highest;

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine("helloooo");
            //}

            #endregion

        }
        public static void TestX()
        {
            Console.WriteLine("Test X");
        }
        public static void TestY()
        {
            Console.WriteLine("Test Y");
        }
        public static void TestZ()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Work is in completed");
            }
        }
    }
}