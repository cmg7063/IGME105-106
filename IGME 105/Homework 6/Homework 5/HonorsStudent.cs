using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class HonorsStudent : CommonCharacter
    {
        private int year;

        public HonorsStudent(String name, String gender, int year) : base(name, gender)
        {
            this.position = "honors student";
            this.year = year;
            this.sleep = 3;
        }

        public override string ToString()
        {
            return name + ", a " + gender + " year " + year + " " + position + ", has had " + sleep + " hours of sleep";
        }

        public override int TakeTest()
        {
            Random random = new Random();
            int chance = random.Next(0, 101);

            if (chance > 0 && chance <= 30)
            {
                int pointsMissed = 0;
                return pointsMissed; // <- added this line so that pointsMissed would be returned (used to calculate points of "damage")
                //testScore -= pointsMissed;
                //Console.WriteLine("You missed " + pointsMissed + " points on the test, resulting in a score of " + testScore);
            }
            else if (chance > 30 && chance <= 80)
            {
                int pointsMissed = random.Next(5, 16);   // Generate how many points were missed; exclusive!!
                return pointsMissed;
                //testScore -= pointsMissed;
                //Console.WriteLine("You missed " + pointsMissed + " points on the test, resulting in a score of " + testScore);
            }
            else if (chance > 80 && chance <= 100)
            {
                int pointsMissed = random.Next(16, 26);
                return pointsMissed;
                //testScore -= pointsMissed;
                //Console.WriteLine("You missed " + pointsMissed + " points on the test, resulting in a score of " + testScore);
            }

            return 0;
        }
        // This entire method has been modified so that it returns true or false
        // This is due to the fact that in the Battle Royale we are not asking for user input
        public override bool HasLeftClassroom()  // public bool HasFled()
        {
            if (testScore <= 50)
            {
                return true;
                //Console.WriteLine("Your current test score is " + testScore + ". Do you want to want to leave the testing site? (Y/N)");
                //String response = Console.ReadLine().ToUpper();
                //if (response == "Y")
                //{
                //    return true;
                //}
                //else if (response == "N")
                //{
                //    return false;
                //}
            }
            //Console.WriteLine("Your test score is greater than 50. You do not have the option to leave the test site.");
            return false;
        }
    }
}
