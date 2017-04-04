using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class Student : CommonCharacter
    {
        private int testScore = 100;
        private int year;
        private int points;

        public Student(String name, String gender, int year) : base(name, gender)
        {
            this.sleep = 5;
            this.year = year;
            this.position = "student";
            //this.testScore = 100;
        }

        public int Year
        {
            get { return year; }
        }

        public override string ToString()
        {
            return name + ", a " + gender + " year " + year + " " + position + ", has had " + sleep + " hours of sleep.";
        }

        public int TakeTest()   // public int Attack()
        {
            // Generate a random number between 0 and 100, then I will use if-statements
            // To determine the % chance of the student getting a specific amount of credit

            Random random = new Random();
            int chance = random.Next(0, 101);

            if(chance > 0 && chance <= 25)
            {
                int pointsMissed = 0;
                testScore -= pointsMissed;
                Console.WriteLine("You missed " + pointsMissed + " points on the test, resulting in a score of " + testScore);
            }
            else if (chance > 25 && chance <= 45)
            {
                int pointsMissed = random.Next(1, 6);   // Generate how many points were missed; exclusive!!
                testScore -= pointsMissed;
                Console.WriteLine("You missed " + pointsMissed + " points on the test, resulting in a score of " + testScore);
            }
            else if (chance > 45 && chance <= 65)
            {
                int pointsMissed = random.Next(6, 11);
                testScore -= pointsMissed;
                Console.WriteLine("You missed " + pointsMissed + " points on the test, resulting in a score of " + testScore);
            }
            else if (chance > 65 && chance <= 85)
            {
                int pointsMissed = random.Next(11, 16);
                testScore -= pointsMissed;
                Console.WriteLine("You missed " + pointsMissed + " points on the test, resulting in a score of " + testScore);
            }
            else if (chance > 85 && chance <= 100)
            {
                int pointsMissed = random.Next(16, 21);
                testScore -= pointsMissed;
                Console.WriteLine("You missed " + pointsMissed + " points on the test, resulting in a score of " + testScore);
            }

            return testScore;
        }

        public void PleadForPartialCredit(int points)   // public void ChangeHealth(int amount)
        {
            this.points = points;
            int finalScore = testScore + points;

            if (points > 0)
            {
                if (finalScore > 100)
                {
                    //finalScore = 100;
                    Console.WriteLine("You pleaded for more points on your test and ended up with a score of 100.");
                }
                else
                {
                    Console.WriteLine("You pleaded for more points on your test and ended up with a score of " + finalScore + ".");
                }
            }
            if (points < 0)
            {
                if (finalScore < 0)
                {
                    //finalScore = 0;
                    Console.WriteLine("You pleaded for less points on your test and ended up with a score of 0.");
                }
                else
                {
                    Console.WriteLine("You pleaded for less points on your test and ended up with a score of " + finalScore + ".");
                }
            }
        }

        public bool HasFailed() // public bool IsDead(); I hope that it's okay that I used 50 instead of 0 (because 50 and below is failing on a test).
        {
            if (testScore <= 50)
            {
                Console.WriteLine(name + ", you failed the test.");
                return true;
            }

            Console.WriteLine(name + ", you did not fail the test.");
            return false;
        }

        public bool HasLeftClassroom()  // public bool HasFled()
        {
            if (testScore <= 25)
            {
                Console.WriteLine("Your current test score is " + testScore + ". Do you want to want to leave the testing site? (Y/N)");
                String response = Console.ReadLine().ToUpper();
                if(response == "Y")
                {
                    return true;
                }
                else if (response == "N")
                {
                    return false;
                }
            }
            Console.WriteLine("Your test score is greater than 25. You do not have the option to leave the test site.");
            return false;
        }
    }
}
