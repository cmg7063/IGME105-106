using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am going to analyze your name.");
            Console.Write("Please enter your name: ");
            String userName = Console.ReadLine();

            //Print user's name in all caps
            userName = userName.ToUpper();
            Console.WriteLine("Thanks " + userName);

            //Print first letter of name
            String firstLetter = userName.Substring(0, 1);
            Console.WriteLine("The first letter of your name is " + firstLetter);

            //Print last letter of name
            String lastLetter = userName.Substring(userName.Length - 1);
            Console.WriteLine("The last letter of your name is " + lastLetter);

            //Print the length of name
            Console.WriteLine("Your name has " + userName.Length + " letters");

            //$$$ section
            Console.WriteLine();
            Console.WriteLine("Now I am going to analyze a number.");
            Console.Write("Enter a price: ");
            String userPrice = Console.ReadLine();
            Console.WriteLine("You entered $" + userPrice);

            //Print price w/ tax
            double convertString = Convert.ToDouble(userPrice);
            double tax = convertString * .08;
            double newPrice = tax + convertString;
            Console.WriteLine("Total with tax: $" + newPrice);

            //Print dollar portions
            String portionPrice = Convert.ToString(newPrice);
            int tensPosition = portionPrice.IndexOf(".");
            String dollarPortion = portionPrice.Substring(0, tensPosition);
            Console.WriteLine("The dollar portion is " + dollarPortion);
            String centPosition = portionPrice.Substring(tensPosition, portionPrice.Length - 1);
            Console.WriteLine("The cent portion is 0" + centPosition);

            //Compare numbers
            Console.WriteLine();
            Console.WriteLine("Lastly, we'll compare numbers.");
            Console.Write("Enter the first number: ");
            String firstNumber = Console.ReadLine();
            Console.Write("Enter the second number: ");
            String secondNumber = Console.ReadLine();

            double convertFirstNumber = Convert.ToDouble(firstNumber);
            double convertSecondNumber = Convert.ToDouble(secondNumber);

            double maxNumber = Math.Max(convertFirstNumber, convertSecondNumber);

            Console.WriteLine("The larger number is " + maxNumber);


        }
    }
}
