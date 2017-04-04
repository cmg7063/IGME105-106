using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PE12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sleep for 20 milliseconds
            int sleepTime = 20;

            Thread[] thread = new Thread[3];

            // Create three Child objects
            Child ch1 = new Child("Kevin", "I want to go home!");
            Child ch2 = new Child("Sarah", "I want to go to the park!");
            Child ch3 = new Child("Kristina", "I want ice cream!");

            // Create three new Threads in array
            Thread t1 = new Thread(ch1.Whine);
            thread[0] = t1;
            Thread t2 = new Thread(ch2.Whine);
            thread[1] = t2;
            Thread t3 = new Thread(ch3.Whine);
            thread[2] = t3;

            // Loop to start threads
            foreach (Thread t in thread)
            {
                t.Start();
                Thread.Sleep(sleepTime);
                t.Join();
                Console.WriteLine("Knock it off!");
            }
        }
    }
}
