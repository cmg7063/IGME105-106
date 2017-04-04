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

            // Draw the walls first
            dungeon.DrawWallHorizontal(1, 0, 10);                   // Draw the top wall
            dungeon.DrawWallVertical(0, 1, 6);                      // Draw left wall
            dungeon.DrawWallHorizontal(1, 7, 10);                   // Draw the bottom wall	
            dungeon.DrawWallVertical(11, 1, 1);                     // Draw top right wall
            dungeon.DrawWallVertical(11, 5, 2);                     // Draw bottom right wall

            // Wall corners
            dungeon.DrawWallCorner(0, 0, WallCorner.TopLeft);
            dungeon.DrawWallCorner(11, 0, WallCorner.TopRight);
            dungeon.DrawWallCorner(0, 7, WallCorner.BottomLeft);
            dungeon.DrawWallCorner(11, 7, WallCorner.BottomRight);
            dungeon.DrawWallCorner(11, 2, WallCorner.BottomLeft);   // The entrance to the hallway
            dungeon.DrawWallCorner(11, 4, WallCorner.TopLeft);      // The entrance to the hallway

            // Objects in the dungeon
            dungeon.DrawObject(3, 2, '@');                          // Add the explorer
            dungeon.DrawObject(5, 6, 'W', ConsoleColor.Green);      // Add a weapon

            //Draws horizontal tunnel
            dungeon.DrawWallHorizontal(12, 4, 17);
            dungeon.DrawWallHorizontal(12, 2, 17);

            //Wall corners 2.0
            dungeon.DrawWallCorner(28, 4, WallCorner.TopRight);     // The entrance to the other room
            dungeon.DrawWallCorner(28, 2, WallCorner.BottomRight);  // The entrance to the other room
            dungeon.DrawWallCorner(28, 1, WallCorner.TopLeft);      // The corner of the other room
            dungeon.DrawWallCorner(28, 9, WallCorner.BottomLeft);   // The corner of the other room
            dungeon.DrawWallCorner(42, 1, WallCorner.TopRight);     // The corner of the other room
            dungeon.DrawWallCorner(42, 9, WallCorner.BottomRight);  // The corner of the other room

            //Draw the walls first 2.0
            dungeon.DrawWallVertical(28, 5, 4);
            dungeon.DrawWallHorizontal(29, 1, 13);
            dungeon.DrawWallVertical(42, 2, 7);
            dungeon.DrawWallHorizontal(29, 9, 13);

            // Objects in the dungeon 2.0
            dungeon.DrawObject(39, 4, '*', ConsoleColor.White);     // Add a gem
            dungeon.DrawObject(38, 4, '*', ConsoleColor.Green);     // Add a gem
            dungeon.DrawObject(38, 5, '*', ConsoleColor.Cyan);      // Add a gem
            dungeon.DrawObject(33, 4, 'P', ConsoleColor.White);     // Add the potion
            dungeon.DrawObject(31, 8, 'M', ConsoleColor.DarkRed);   // Add the monster


            // The following lines ensure the cursor ends up near the bottom
            // of the console window when the program ends.  Make sure this
            // happens last by only adding code above these lines.
            Console.CursorTop = Console.WindowHeight - 1;
            Console.CursorLeft = 0;
        }
    }
}
