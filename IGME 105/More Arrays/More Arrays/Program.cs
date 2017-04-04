using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            String userInput = Console.ReadLine();
            userInput = userInput.Trim();
            String usersName = userInput.ToLower();

            //Creates a new GradePredictor
            GradePredictor grade = new GradePredictor();

            //I'm bad at variable names
            int [] noIdea = grade.GetLetters(usersName);
            int gradeValue = grade.EstimateGrade(noIdea);
            Console.WriteLine("Estimated grade: " + grade.EstimateGrade(noIdea));
            Console.WriteLine("Letter grade: " + grade.AssignGrade(gradeValue));
        }
    }
}
