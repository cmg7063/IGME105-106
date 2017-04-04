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
            List<CommonCharacter> characters = new List<CommonCharacter>();
            characters.Add(new Student("Astrid", "female", 1));
            characters.Add(new Student("Holden", "male", 2));
            characters.Add(new HonorsStudent("Matthew", "male", 3));
            characters.Add(new HonorsStudent("Sammantha", "female", 4));

            // This will be used to choose a character to "battle" at random from the List of characters
            Random random = new Random();

            while(characters.Count() > 1)
            {
                foreach(CommonCharacter character in characters)
                {
                    // When I initially did HW 5 I didn't know we'd be having a battle between characters so... 
                    // I know it seems weird to call the method TakeTest() and use the points missed by one student 
                    // as an "attack" against another student but it was too late to change it.

                    int randomStudent = random.Next(characters.Count);

                    if (1==1)
                    {
                        for (int i = 0; i < characters.Count; i++)
                        {
                                int points = characters[i].TakeTest();

                                if (points > 0)
                                {
                                // This makes sure there is no instance where a student "attacks"
                                // themself but... I don't think it works properly
                                if (characters[i].Name == characters[randomStudent].Name)
                                    {
                                        random.Next(characters.Count);
                                    }
                                    else
                                    {
                                        int afterScore = characters[randomStudent].TestScore - points;
                                        characters[randomStudent].TestScore = afterScore;

                                        if (afterScore < 25)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine(characters[i].Name + " reports " + characters[randomStudent].Name + " for cheating and loses them " + points + " points.");
                                            Console.WriteLine(characters[randomStudent].Name + " now has a test score of " + afterScore);
                                            Console.WriteLine();
                                            System.Threading.Thread.Sleep(1000);
                                        }
                                    }
                                }
                                // If the randomly generated TakeTest() points are
                                // 0, then no "damage" is done to the "opponent"
                                else if (points == 0)
                                {
                                    Console.WriteLine(characters[i].Name + " reports " + characters[randomStudent].Name + " for cheating but the claim is dismissed.");
                                    Console.WriteLine();
                                    System.Threading.Thread.Sleep(1000);
                                }
                            }
                    }
                }

                // This loop checks if any characters have fled
                // Honors Students leave when their score is <= 50
                // and Students leave when their score is <= 25
                for (int i = 0; i < characters.Count(); i++)
                {
                    if (characters[i].HasLeftClassroom())
                    {
                        String removed = characters[i].Name;
                        Console.WriteLine("!!!!!!!!!" + removed + " has left the classroom!!!!!!!!!");
                        characters.RemoveAt(i);
                        Console.WriteLine();
                    }
                }
            }

            foreach (CommonCharacter character in characters)
            {
                Console.WriteLine(character.Name + " is still in the classroom.");
                Console.WriteLine();
                Console.WriteLine("The test is over.");
            }

            //Console.Write("Enter your name: ");
            //String userName = Console.ReadLine();
            //Console.Write("Enter your gender: ");
            //String userGender = Console.ReadLine();
            //Console.Write("Enter your year (1-5): ");
            //int userYear = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();
            //Student student = new Student(userName, userGender, userYear);
            //student.Spawn();
            //Console.WriteLine("Year of student: " + student.Year);
            //Console.WriteLine();
            //Console.WriteLine("END OF ACTIVITY 1");
            //Console.WriteLine();

            //Console.WriteLine(student.ToString());
            //Console.WriteLine("TEST DAY");
            //student.TakeTest();

            //Console.Write("How many points will you plead for? ");
            //int points = Convert.ToInt32(Console.ReadLine());
            //student.PleadForPartialCredit(points);
            //student.HasLeftClassroom();
            //student.HasFailed();
        }
    }
}
