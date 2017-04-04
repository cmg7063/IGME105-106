using System;

namespace Homework1_Dungeon_Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a Dungeon object, which contains the code to draw
            // a map in the console.  This map is 100 columns by 30 rows.
            Dungeon dungeon = new Dungeon("Sample Dungeon", 100, 30);
            // Change the numbers above if you'd like a different size!

            // Builds the dungeon ------------------------------------
            // This code creates the left hand room.  The following can be done
            // in any order, but has been broken up by the type of object for
            // ease of reading.  Feel free to rearrange these if you need to.

            Console.WriteLine("Disclaimer: Potions will spawn in preset location.");
            Console.WriteLine("Explorer and weapon will always spawn in room 1.");
            Console.WriteLine();

            Console.WriteLine("How many rooms will your dungeon have? (Choose a number 0 - 6)");
            String roomNumber = Console.ReadLine();

            Console.WriteLine("How many monsters should be in each room? (Choose a number 0 - 3)");
            String monsterNumber = Console.ReadLine();

            Console.WriteLine("How many gems should be in each room? (Choose a number 0 - 3");
            String gemNumber = Console.ReadLine();

            Console.Clear();

            if (roomNumber == "0" && monsterNumber == "0" && gemNumber == "0")           // No rooms, no monsters, no gems
            {
                dungeon.noRooms();
            }
            else if (roomNumber == "1" && monsterNumber == "0" && gemNumber == "1")    // One room, no monsters, one gem
            {
                dungeon.oneRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
            }
            else if (roomNumber == "1" && monsterNumber == "0" && gemNumber == "2")     // One room, no mosters, two gems
            {
                dungeon.oneRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
            }
            else if (roomNumber == "1" && monsterNumber == "0" && gemNumber == "3")     // One room, no monsters, three gems
            {
                dungeon.oneRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
            }
            else if (roomNumber == "1" && monsterNumber == "1" && gemNumber == "0")     // One room, one monster, no gems
            {
                dungeon.oneRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "1" && monsterNumber == "1" && gemNumber == "1")     // One room, one monster, one gem
            {
                dungeon.oneRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
            }
            else if (roomNumber == "1" && monsterNumber == "1" && gemNumber == "2")     // One room, one monster, two gems
            {
                dungeon.oneRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
            }
            else if (roomNumber == "1" && monsterNumber == "1" && gemNumber == "3")     // One room, one monster, three gems
            {
                dungeon.oneRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
            }
            else if (roomNumber == "1" && monsterNumber == "2" && gemNumber == "0")     // One room, two monsters, no gems
            {
                dungeon.oneRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "1" && monsterNumber == "2" && gemNumber == "1")     // One room, two monsters, one gem
            {
                dungeon.oneRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
            }
            else if (roomNumber == "1" && monsterNumber == "2" && gemNumber == "2")     // One room, two monsters, two gems
            {
                dungeon.oneRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
            }
            else if (roomNumber == "1" && monsterNumber == "2" && gemNumber == "3")     // One room, two monsters, three gems
            {
                dungeon.oneRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
            }
            else if (roomNumber == "1" && monsterNumber == "3" && gemNumber == "0")     // One room, three monsters, no gems
            {
                dungeon.oneRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "1" && monsterNumber == "3" && gemNumber == "1")     // One room, three monsters, one gem
            {
                dungeon.oneRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
            }
            else if (roomNumber == "1" && monsterNumber == "3" && gemNumber == "2")     // One room, three monsters, two gems
            {
                dungeon.oneRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
            }
            else if (roomNumber == "1" && monsterNumber == "3" && gemNumber == "3")     // One room, three monsters, three gems
            {
                dungeon.oneRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
            }

            else if (roomNumber == "2" && monsterNumber == "0" && gemNumber == "0")     //Two rooms, no monsters, no gems
            {
                dungeon.twoRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
            }
            else if (roomNumber == "2" && monsterNumber == "0" && gemNumber == "1")     //Two rooms, no monsters, one gem
            {
                dungeon.twoRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
            }
            else if (roomNumber == "2" && monsterNumber == "0" && gemNumber == "2")     //Two rooms, no monsters, two gems
            {
                dungeon.twoRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
            }
            else if (roomNumber == "2" && monsterNumber == "0" && gemNumber == "3")     //Two rooms, no monsters, three gems
            {
                dungeon.twoRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
            }
            else if (roomNumber == "2" && monsterNumber == "1" && gemNumber == "1")     //Two rooms, one monster, one gem
            {
                dungeon.twoRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "2" && monsterNumber == "1" && gemNumber == "2")     //Two rooms, one monster, two gems
            {
                dungeon.twoRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "2" && monsterNumber == "1" && gemNumber == "3")     //Two rooms, one monster, three gems
            {
                dungeon.twoRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "2" && monsterNumber == "1" && gemNumber == "0")     //Two rooms, one monster, no gems
            {
                dungeon.twoRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "2" && monsterNumber == "2" && gemNumber == "0")     //Two rooms, two monsters, no gems
            {
                dungeon.twoRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "2" && monsterNumber == "2" && gemNumber == "1")     //Two rooms, two monsters, one gem
            {
                dungeon.twoRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "2" && monsterNumber == "2" && gemNumber == "2")     //Two rooms, two monsters, two gems
            {
                dungeon.twoRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "2" && monsterNumber == "2" && gemNumber == "3")     //Two rooms, two monsters, three gems
            {
                dungeon.twoRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "2" && monsterNumber == "3" && gemNumber == "0")     //Two rooms, three monsters, no gems
            {
                dungeon.twoRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "2" && monsterNumber == "3" && gemNumber == "1")     //Two rooms, three monsters, one gem
            {
                dungeon.twoRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "2" && monsterNumber == "3" && gemNumber == "2")     //Two rooms, three monsters, two gems
            {
                dungeon.twoRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "2" && monsterNumber == "3" && gemNumber == "3")     //Two rooms, three monsters, three gems
            {
                dungeon.twoRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "3" && monsterNumber == "0" && gemNumber == "0")     //Three rooms, no monsters, no gems
            {
                dungeon.threeRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
            }
            else if (roomNumber == "3" && monsterNumber == "0" && gemNumber == "1")     //Three rooms, no monsters, one gem
            {
                dungeon.threeRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
            }
            else if (roomNumber == "3" && monsterNumber == "0" && gemNumber == "2")     //Three rooms, no monsters, two gems
            {
                dungeon.threeRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
            }
            else if (roomNumber == "3" && monsterNumber == "0" && gemNumber == "3")     //Three rooms, no monsters, three gems
            {
                dungeon.threeRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(15, 6, '*', ConsoleColor.Yellow);
            }
            else if (roomNumber == "3" && monsterNumber == "1" && gemNumber == "0")     //Three rooms, one monster, no gems
            {
                dungeon.threeRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "3" && monsterNumber == "1" && gemNumber == "1")     //Three rooms, one monster, one gem
            {
                dungeon.threeRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "3" && monsterNumber == "1" && gemNumber == "2")     //Three rooms, one monster, two gems
            {
                dungeon.threeRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "3" && monsterNumber == "1" && gemNumber == "3")     //Three rooms, one monster, three gems
            {
                dungeon.threeRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(15, 6, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "3" && monsterNumber == "2" && gemNumber == "0")     //Three rooms, two monsters, no gems
            {
                dungeon.threeRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(18, 6, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "3" && monsterNumber == "2" && gemNumber == "1")     //Three rooms, two monsters, one gem
            {
                dungeon.threeRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(18, 6, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "3" && monsterNumber == "2" && gemNumber == "2")     //Three rooms, two monsters, two gems
            {
                dungeon.threeRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(18, 6, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "3" && monsterNumber == "2" && gemNumber == "3")     //Three rooms, two monsters, three gems
            {
                dungeon.threeRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(15, 6, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "3" && monsterNumber == "3" && gemNumber == "0")     //Three rooms, three monsters, no gems
            {
                dungeon.threeRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(18, 6, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "3" && monsterNumber == "3" && gemNumber == "1")     //Three rooms, three monsters, one gem
            {
                dungeon.threeRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(18, 6, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "3" && monsterNumber == "3" && gemNumber == "2")     //Three rooms, three monsters, two gems
            {
                dungeon.threeRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(18, 6, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "3" && monsterNumber == "3" && gemNumber == "3")     //Three rooms, three monsters, three gems
            {
                dungeon.threeRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(15, 6, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(18, 6, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "4" && monsterNumber == "0" && gemNumber == "0")     //Four rooms, no monsters, no gems
            {
                dungeon.fourRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
            }
            else if (roomNumber == "4" && monsterNumber == "0" && gemNumber == "1")     //Four rooms, no monsters, one gem
            {
                dungeon.fourRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
            }
            else if (roomNumber == "4" && monsterNumber == "0" && gemNumber == "2")     //Four rooms, no monsters, two gems
            {
                dungeon.fourRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
            }
            else if (roomNumber == "4" && monsterNumber == "0" && gemNumber == "3")     //Four rooms, no monsters, three gems
            {
                dungeon.fourRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(15, 6, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(28, 16, '*', ConsoleColor.Yellow);
            }
            else if (roomNumber == "4" && monsterNumber == "1" && gemNumber == "0")     //Four rooms, one monster, no gems
            {
                dungeon.fourRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
            }
            else if (roomNumber == "4" && monsterNumber == "1" && gemNumber == "1")     //Four rooms, one monster, one gem
            {
                dungeon.fourRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
            }
            else if (roomNumber == "4" && monsterNumber == "1" && gemNumber == "2")     //Four rooms, one monster, two gems
            {
                dungeon.fourRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
            }
            else if (roomNumber == "4" && monsterNumber == "1" && gemNumber == "3")     //Four rooms, one monster, three gems
            {
                dungeon.fourRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(15, 6, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(28, 16, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
            }
            else if (roomNumber == "4" && monsterNumber == "2" && gemNumber == "0")     //Four rooms, two monsters, no gems
            {
                dungeon.fourRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
            }
            else if (roomNumber == "4" && monsterNumber == "2" && gemNumber == "1")     //Four rooms, two monsters, one gem
            {
                dungeon.fourRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
            }
            else if (roomNumber == "4" && monsterNumber == "2" && gemNumber == "2")     //Four rooms, two monsters, two gems
            {
                dungeon.fourRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
            }
            else if (roomNumber == "4" && monsterNumber == "2" && gemNumber == "3")     //Four rooms, two monsters, three gems
            {
                dungeon.fourRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(15, 6, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(28, 16, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
            }
            else if (roomNumber == "4" && monsterNumber == "3" && gemNumber == "0")     //Four rooms, three monsters, no gems
            {
                dungeon.fourRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(18, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(25, 17, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "4" && monsterNumber == "3" && gemNumber == "1")     //Four rooms, three monsters, one gem
            {
                dungeon.fourRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(18, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(25, 17, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "4" && monsterNumber == "3" && gemNumber == "2")     //Four rooms, three monsters, two gems
            {
                dungeon.fourRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(18, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(25, 17, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "4" && monsterNumber == "3" && gemNumber == "3")     //Four rooms, three monsters, three gems
            {
                dungeon.fourRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(15, 6, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(28, 16, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(18, 6, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);
                dungeon.DrawObject(25, 17, 'M', ConsoleColor.DarkRed);
            }
            else if (roomNumber == "5" && monsterNumber == "0" && gemNumber == "0")     //Five rooms, no monsters, no gems
            {
                dungeon.fiveRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
            }
            else if (roomNumber == "5" && monsterNumber == "0" && gemNumber == "1")     //Five rooms, no monsters, one gem
            {
                dungeon.fiveRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
            }
            else if (roomNumber == "5" && monsterNumber == "0" && gemNumber == "2")     //Five rooms, no monsters, two gems
            {
                dungeon.fiveRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(40, 14, '*', ConsoleColor.White);
            }
            else if (roomNumber == "5" && monsterNumber == "0" && gemNumber == "3")     //Five rooms, no monsters, three gems
            {
                dungeon.fiveRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(40, 14, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(15, 6, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(28, 16, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(40, 12, '*', ConsoleColor.Yellow);
            }
            else if (roomNumber == "5" && monsterNumber == "1" && gemNumber == "0")     //Five rooms, one monster, no gems
            {
                dungeon.fiveRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five

            }
            else if (roomNumber == "5" && monsterNumber == "1" && gemNumber == "1")     //Five rooms, one monster, one gem
            {
                dungeon.fiveRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
            }
            else if (roomNumber == "5" && monsterNumber == "1" && gemNumber == "2")     //Five rooms, one monster, two gems
            {
                dungeon.fiveRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(40, 14, '*', ConsoleColor.White);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
            }
            else if (roomNumber == "5" && monsterNumber == "1" && gemNumber == "3")     //Five rooms, one monster, three gems
            {
                dungeon.fiveRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(40, 14, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(15, 6, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(28, 16, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(40, 12, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
            }
            else if (roomNumber == "5" && monsterNumber == "2" && gemNumber == "0")     //Five rooms, two monsters, no gems
            {
                dungeon.fiveRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(40, 20, 'M', ConsoleColor.DarkRed);  // Room five
            }
            else if (roomNumber == "5" && monsterNumber == "2" && gemNumber == "1")     //Five rooms, two monsters, one gem
            {
                dungeon.fiveRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(40, 20, 'M', ConsoleColor.DarkRed);  // Room five
            }
            else if (roomNumber == "5" && monsterNumber == "2" && gemNumber == "2")     //Five rooms, two monsters, two gems
            {
                dungeon.fiveRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(40, 14, '*', ConsoleColor.White);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(40, 20, 'M', ConsoleColor.DarkRed);  // Room five
            }
            else if (roomNumber == "5" && monsterNumber == "2" && gemNumber == "3")     //Five rooms, two monsters, three gems
            {
                dungeon.fiveRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(40, 14, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(15, 6, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(28, 16, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(40, 12, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(40, 20, 'M', ConsoleColor.DarkRed);  // Room five
            }
            else if (roomNumber == "5" && monsterNumber == "3" && gemNumber == "0")     //Five rooms, three monsters, no gems
            {
                dungeon.fiveRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(18, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(25, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(40, 20, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(41, 18, 'M', ConsoleColor.DarkRed);  // Room five
            }
            else if (roomNumber == "5" && monsterNumber == "3" && gemNumber == "1")     //Five rooms, three monsters, one gem
            {
                dungeon.fiveRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(18, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(25, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(40, 20, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(41, 18, 'M', ConsoleColor.DarkRed);  // Room five
            }
            else if (roomNumber == "5" && monsterNumber == "3" && gemNumber == "2")     //Five rooms, three monsters, two gems
            {
                dungeon.fiveRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(40, 14, '*', ConsoleColor.White);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(18, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(25, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(40, 20, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(41, 18, 'M', ConsoleColor.DarkRed);  // Room five
            }
            else if (roomNumber == "5" && monsterNumber == "3" && gemNumber == "3")     //Five rooms, three monsters, three gems
            {
                dungeon.fiveRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(40, 14, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(15, 6, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(28, 16, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(40, 12, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(18, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(25, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(40, 20, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(41, 18, 'M', ConsoleColor.DarkRed);  // Room five
            }
            else if (roomNumber == "6" && monsterNumber == "0" && gemNumber == "0")     //Six rooms, no monsters, no gems
            {
                dungeon.sixRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
            }
            else if (roomNumber == "6" && monsterNumber == "0" && gemNumber == "1")     //Six rooms, no monsters, one gem
            {
                dungeon.sixRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(49, 13, '*', ConsoleColor.Cyan);
            }
            else if (roomNumber == "6" && monsterNumber == "0" && gemNumber == "2")     //Six rooms, no monsters, two gems
            {
                dungeon.sixRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(49, 13, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(40, 14, '*', ConsoleColor.White);
                dungeon.DrawObject(53, 10, '*', ConsoleColor.White);
            }
            else if (roomNumber == "6" && monsterNumber == "0" && gemNumber == "3")     //Six rooms, no monsters, three gems
            {
                dungeon.sixRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(49, 13, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(40, 14, '*', ConsoleColor.White);
                dungeon.DrawObject(53, 10, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(15, 6, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(28, 16, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(40, 12, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(59, 14, '*', ConsoleColor.Yellow);
            }
            else if (roomNumber == "6" && monsterNumber == "1" && gemNumber == "0")     //Six rooms, one monster, no gems
            {
                dungeon.sixRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(51, 14, 'M', ConsoleColor.DarkRed);  // Room six
            }
            else if (roomNumber == "6" && monsterNumber == "1" && gemNumber == "1")     //Six rooms, one monster, one gem
            {
                dungeon.sixRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(49, 13, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(51, 14, 'M', ConsoleColor.DarkRed);  // Room six
            }
            else if (roomNumber == "6" && monsterNumber == "1" && gemNumber == "2")     //Six rooms, one monster, two gems
            {
                dungeon.sixRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(49, 13, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(40, 14, '*', ConsoleColor.White);
                dungeon.DrawObject(53, 10, '*', ConsoleColor.White);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(51, 14, 'M', ConsoleColor.DarkRed);  // Room six
            }
            else if (roomNumber == "6" && monsterNumber == "1" && gemNumber == "3")     //Six rooms, one monster, three gems
            {
                dungeon.sixRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(49, 13, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(40, 14, '*', ConsoleColor.White);
                dungeon.DrawObject(53, 10, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(15, 6, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(28, 16, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(40, 12, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(59, 14, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(51, 14, 'M', ConsoleColor.DarkRed);  // Room six
            }
            else if (roomNumber == "6" && monsterNumber == "2" && gemNumber == "0")     //Six rooms, two monsters, no gems
            {
                dungeon.sixRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(40, 20, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(51, 14, 'M', ConsoleColor.DarkRed);  // Room six
                dungeon.DrawObject(55, 11, 'M', ConsoleColor.DarkRed);  // Room six
            }
            else if (roomNumber == "6" && monsterNumber == "2" && gemNumber == "1")     //Six rooms, two monsters, one gem
            {
                dungeon.sixRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(49, 13, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(40, 20, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(51, 14, 'M', ConsoleColor.DarkRed);  // Room six
                dungeon.DrawObject(55, 11, 'M', ConsoleColor.DarkRed);  // Room six
            }
            else if (roomNumber == "6" && monsterNumber == "2" && gemNumber == "2")     //Six rooms, two monsters, two gems
            {
                dungeon.sixRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(49, 13, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(40, 14, '*', ConsoleColor.White);
                dungeon.DrawObject(53, 10, '*', ConsoleColor.White);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(40, 20, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(51, 14, 'M', ConsoleColor.DarkRed);  // Room six
                dungeon.DrawObject(55, 11, 'M', ConsoleColor.DarkRed);  // Room six
            }
            else if (roomNumber == "6" && monsterNumber == "2" && gemNumber == "3")     //Six rooms, two monsters, three gems
            {
                dungeon.sixRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(49, 13, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(40, 14, '*', ConsoleColor.White);
                dungeon.DrawObject(53, 10, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(15, 6, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(28, 16, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(40, 12, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(59, 14, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(40, 20, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(51, 14, 'M', ConsoleColor.DarkRed);  // Room six
                dungeon.DrawObject(55, 11, 'M', ConsoleColor.DarkRed);  // Room six
            }
            else if (roomNumber == "6" && monsterNumber == "3" && gemNumber == "0")     //Six rooms, three monsters, no gems
            {
                dungeon.sixRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(18, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(25, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(40, 20, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(41, 18, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(51, 14, 'M', ConsoleColor.DarkRed);  // Room six
                dungeon.DrawObject(55, 11, 'M', ConsoleColor.DarkRed);  // Room six
                dungeon.DrawObject(58, 11, 'M', ConsoleColor.DarkRed);  // Room six
            }
            else if (roomNumber == "6" && monsterNumber == "3" && gemNumber == "1")     //Six rooms, three monsters, one gems
            {
                dungeon.sixRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(49, 13, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(18, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(25, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(40, 20, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(41, 18, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(51, 14, 'M', ConsoleColor.DarkRed);  // Room six
                dungeon.DrawObject(55, 11, 'M', ConsoleColor.DarkRed);  // Room six
                dungeon.DrawObject(58, 11, 'M', ConsoleColor.DarkRed);  // Room six
            }
            else if (roomNumber == "6" && monsterNumber == "3" && gemNumber == "2")     //Six rooms, three monsters, two gems
            {
                dungeon.sixRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(49, 13, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(40, 14, '*', ConsoleColor.White);
                dungeon.DrawObject(53, 10, '*', ConsoleColor.White);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(18, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(25, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(40, 20, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(41, 18, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(51, 14, 'M', ConsoleColor.DarkRed);  // Room six
                dungeon.DrawObject(55, 11, 'M', ConsoleColor.DarkRed);  // Room six
                dungeon.DrawObject(58, 11, 'M', ConsoleColor.DarkRed);  // Room six
            }
            else if (roomNumber == "6" && monsterNumber == "3" && gemNumber == "3")     //Six rooms, three monsters, three gems
            {
                dungeon.sixRoom();
                dungeon.DrawObject(2, 6, '@', ConsoleColor.DarkMagenta);
                dungeon.DrawObject(3, 6, 'W', ConsoleColor.Gray);
                dungeon.DrawObject(10, 6, 'P', ConsoleColor.Green);
                dungeon.DrawObject(22, 3, 'P', ConsoleColor.Green);
                dungeon.DrawObject(33, 4, 'P', ConsoleColor.Green);
                dungeon.DrawObject(4, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(38, 4, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(17, 6, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(14, 17, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 18, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(49, 13, '*', ConsoleColor.Cyan);
                dungeon.DrawObject(40, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(6, 2, '*', ConsoleColor.White);
                dungeon.DrawObject(14, 6, '*', ConsoleColor.White);
                dungeon.DrawObject(17, 21, '*', ConsoleColor.White);
                dungeon.DrawObject(40, 14, '*', ConsoleColor.White);
                dungeon.DrawObject(53, 10, '*', ConsoleColor.White);
                dungeon.DrawObject(8, 3, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(35, 7, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(15, 6, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(28, 16, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(40, 12, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(59, 14, '*', ConsoleColor.Yellow);
                dungeon.DrawObject(3, 3, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(9, 5, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(5, 6, 'M', ConsoleColor.DarkRed);    // Room one
                dungeon.DrawObject(30, 4, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(35, 5, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(38, 7, 'M', ConsoleColor.DarkRed);   // Room two
                dungeon.DrawObject(16, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(17, 5, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(18, 6, 'M', ConsoleColor.DarkRed);   // Room three
                dungeon.DrawObject(16, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(20, 21, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(25, 17, 'M', ConsoleColor.DarkRed);  // Room four
                dungeon.DrawObject(41, 15, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(40, 20, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(41, 18, 'M', ConsoleColor.DarkRed);  // Room five
                dungeon.DrawObject(51, 14, 'M', ConsoleColor.DarkRed);  // Room six
                dungeon.DrawObject(55, 11, 'M', ConsoleColor.DarkRed);  // Room six
                dungeon.DrawObject(58, 11, 'M', ConsoleColor.DarkRed);  // Room six
            }
            else 
            {
                Console.WriteLine("Sorry, but the number you entered was not within the parameters listed!");
            }

            // The following lines ensure the cursor ends up near the bottom
            // of the console window when the program ends.  Make sure this
            // happens last by only adding code above these lines.
            Console.CursorTop = Console.WindowHeight - 1;
            Console.CursorLeft = 0;
        }
    }
}
