using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class CommonCharacter
    {
        protected int testScore = 100;
        protected int sleep;
        protected String name;
        protected String gender;
        protected String position;
        private int points;

        public CommonCharacter()
        {
            sleep = 7;
            name = "UNKNOWN";
            gender = "UNKNOWN";
            position = "UNKONWN";
        }

        public CommonCharacter(String name, String gender)
        {
            this.gender = gender;
            this.name = name;
        }

        public int Sleep
        {
            get { return sleep; }
        }

        public String Name
        {
            get { return name; }
        }
        
        public String Gender
        {
            get { return gender; }
        }

        public String Position
        {
            get { return position; }
        }

        public int TestScore
        {
            get { return testScore; }
            set { testScore = value; }
        }
        public void Spawn()
        {
            Console.WriteLine(name + ", a " + gender + " " + position + ", has had " + sleep + " hours of sleep");
        }

        public virtual int TakeTest()   // public int Attack()
        {
            // Generate a random number between 0 and 100, then I will use if-statements
            // To determine the % chance of the student getting a specific amount of credit

            Random random = new Random();
            int chance = random.Next(0, 101);

            if (chance > 0 && chance <= 25)
            {
                int pointsMissed = 0;
                return pointsMissed; // <- added this line so that pointsMissed would be returned (used to calculate points of "damage")
                //testScore -= pointsMissed;
                //Console.WriteLine("You missed " + pointsMissed + " points on the test, resulting in a score of " + testScore);
            }
            else if (chance > 25 && chance <= 45)
            {
                int pointsMissed = random.Next(1, 6);   // Generate how many points were missed; exclusive!!
                return pointsMissed;
                //testScore -= pointsMissed;
                //Console.WriteLine("You missed " + pointsMissed + " points on the test, resulting in a score of " + testScore);
            }
            else if (chance > 45 && chance <= 65)
            {
                int pointsMissed = random.Next(6, 11);
                return pointsMissed;
                //testScore -= pointsMissed;
                //Console.WriteLine("You missed " + pointsMissed + " points on the test, resulting in a score of " + testScore);
            }
            else if (chance > 65 && chance <= 85)
            {
                int pointsMissed = random.Next(11, 16);
                return pointsMissed;
                //testScore -= pointsMissed;
                //Console.WriteLine("You missed " + pointsMissed + " points on the test, resulting in a score of " + testScore);
            }
            else if (chance > 85 && chance <= 100)
            {
                int pointsMissed = random.Next(16, 21);
                return pointsMissed;
                //testScore -= pointsMissed;
                //Console.WriteLine("You missed " + pointsMissed + " points on the test, resulting in a score of " + testScore);
            }

            return 0;
        }

        public virtual void PleadForPartialCredit(int points)   // public void ChangeHealth(int amount)
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

        public virtual bool HasFailed() // public bool IsDead(); I hope that it's okay that I used 50 instead of 0 (because 50 and below is failing on a test).
        {
            if (testScore <= 50)
            {
                Console.WriteLine(name + ", you failed the test.");
                return true;
            }

            Console.WriteLine(name + ", you did not fail the test.");
            return false;
        }

        public virtual bool HasLeftClassroom()  // public bool HasFled()
        {
            // This entire method has been modified so that it returns true or false
            // This is due to the fact that in the Battle Royale we are not asking for user input
            if (testScore <= 25)
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
            //Console.WriteLine("Your test score is greater than 25. You do not have the option to leave the test site.");
            return false;
        }
        
        // This is like how I recorded "damage" done to the characters
        public int CompareResults(int points)
        {
            int score = testScore - points;
            return score;
        }

    }
}
