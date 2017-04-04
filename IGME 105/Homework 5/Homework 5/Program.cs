using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            String userName = Console.ReadLine();
            Console.Write("Enter your gender: ");
            String userGender = Console.ReadLine();
            Console.Write("Enter your year (1-5): ");
            int userYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Student student = new Student(userName, userGender, userYear);
            student.Spawn();
            Console.WriteLine("Year of student: " + student.Year);
            Console.WriteLine();
            Console.WriteLine("END OF ACTIVITY 1");
            Console.WriteLine();

            Console.WriteLine(student.ToString());
            Console.WriteLine("TEST DAY");
            student.TakeTest();

            Console.Write("How many points will you plead for? ");
            int points = Convert.ToInt32(Console.ReadLine());
            student.PleadForPartialCredit(points);
            student.HasLeftClassroom();
            student.HasFailed();
        }
    }
}
