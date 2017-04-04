using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_Activity_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMan superman = new SuperMan(660);

            Console.WriteLine("The required velocity to jump over a 660 foot building on Venus is \n " + superman.Leap(29.1) + " feet/sec.");
            Console.WriteLine("The required velocity to jump over a 660 foot building on Earth is \n " + superman.Leap(32.1) + " feet/sec.");
            Console.WriteLine("The required velocity to jump over a 660 foot building on the Moon is \n " + superman.Leap(5.3) + "feet/sec.");
            Console.WriteLine("The required velocity to jump over a 660 foot building on Mars is \n " + superman.Leap(12.4) + " feet/sec.");
            Console.WriteLine("The required velocity to jump over a 660 foot building on Jupiter is \n " + superman.Leap(85.1) + " feet/sec.");
        }
    }
}
