using System;

namespace Homework1_Dungeon_Starter
{
	/// <summary>
	/// Defines possible wall corner directions
	/// </summary>
    enum WallCorner
    {
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight
    }

	/// <summary>
	/// Allows a dungeon to be drawn to the console window
	/// </summary>
	class Dungeon
	{
		// The sizes of the dungeon
		private int dungeonWidth;
		private int dungeonHeight;

		/// <summary>
		/// Creates a new dungeon object of
		/// a specific size
		/// </summary>
		/// <param name="width">The x size of the dungeon</param>
		/// <param name="height">The y size of the dungeon</param>
		public Dungeon(String name, int width, int height)
		{
            Console.WindowWidth = width;
            Console.WindowHeight = height;
            Console.Title = name;

			// Save the sizes
			this.dungeonWidth = width;
			this.dungeonHeight = height;
		}
                                         // *****************************************************************
                                         // * THE BEGINNINIG OF ALL THAT HAS BEEN MODIFIED IN THIS DOCUMENT *
                                         // *****************************************************************
        public void noRooms()
        {
        }

        public void oneRoom()
        {
            // Draw the walls first
            DrawWallHorizontal(1, 0, 10);                   // Draw the top wall
            DrawWallVertical(0, 1, 6);                      // Draw left wall
            DrawWallHorizontal(1, 7, 10);                   // Draw the bottom wall	
            DrawWallVertical(11, 0, 7);                     // Draw right wall

            // Wall corners
            DrawWallCorner(0, 0, WallCorner.TopLeft);
            DrawWallCorner(11, 0, WallCorner.TopRight);
            DrawWallCorner(0, 7, WallCorner.BottomLeft);
            DrawWallCorner(11, 7, WallCorner.BottomRight);
        }

        public void twoRoom()
        {
            // Draw the walls first
            DrawWallHorizontal(1, 0, 10);                   // Draw the top wall
            DrawWallVertical(0, 1, 6);                      // Draw left wall
            DrawWallHorizontal(1, 7, 10);                   // Draw the bottom wall	
            DrawWallVertical(11, 1, 1);                     // Draw top right wall
            DrawWallVertical(11, 5, 2);                     // Draw bottom right wall

            // Wall corners
            DrawWallCorner(0, 0, WallCorner.TopLeft);
            DrawWallCorner(11, 0, WallCorner.TopRight);
            DrawWallCorner(0, 7, WallCorner.BottomLeft);
            DrawWallCorner(11, 7, WallCorner.BottomRight);
            DrawWallCorner(11, 2, WallCorner.BottomLeft);   // The entrance to the hallway
            DrawWallCorner(11, 4, WallCorner.TopLeft);      // The entrance to the hallway

            //Draws horizontal hallway
            DrawWallHorizontal(12, 4, 17);
            DrawWallHorizontal(12, 2, 17);

            //Corners galore
            DrawWallCorner(28, 4, WallCorner.TopRight);     // The entrance to the other room
            DrawWallCorner(28, 2, WallCorner.BottomRight);  // The entrance to the other room

            //Gem room 
            DrawWallVertical(28, 5, 4);
            DrawWallHorizontal(29, 1, 13);
            DrawWallVertical(42, 2, 7);
            DrawWallHorizontal(29, 9, 13);
            DrawWallCorner(28, 1, WallCorner.TopLeft);      // The corner of the gem room
            DrawWallCorner(28, 9, WallCorner.BottomLeft);   // The corner of the gem room
            DrawWallCorner(42, 1, WallCorner.TopRight);     // The corner of the gem room
            DrawWallCorner(42, 9, WallCorner.BottomRight);  // The corner of the gem room
        }
        
        public void threeRoom()
        {
            // Draw the walls first
            DrawWallHorizontal(1, 0, 10);                   // Draw the top wall
            DrawWallVertical(0, 1, 6);                      // Draw left wall
            DrawWallHorizontal(1, 7, 10);                   // Draw the bottom wall	
            DrawWallVertical(11, 1, 1);                     // Draw top right wall
            DrawWallVertical(11, 5, 2);                     // Draw bottom right wall

            // Wall corners
            DrawWallCorner(0, 0, WallCorner.TopLeft);
            DrawWallCorner(11, 0, WallCorner.TopRight);
            DrawWallCorner(0, 7, WallCorner.BottomLeft);
            DrawWallCorner(11, 7, WallCorner.BottomRight);
            DrawWallCorner(11, 2, WallCorner.BottomLeft);   // The entrance to the hallway
            DrawWallCorner(11, 4, WallCorner.TopLeft);      // The entrance to the hallway

            //Draws horizontal hallway
            DrawWallHorizontal(12, 4, 4);
            DrawWallHorizontal(19, 4, 9);   // This depends on user input
            DrawWallHorizontal(12, 2, 17);

            //Corners galore
            DrawWallCorner(28, 4, WallCorner.TopRight);     // The entrance to the other room
            DrawWallCorner(28, 2, WallCorner.BottomRight);  // The entrance to the other room

            DrawWallCorner(16, 4, WallCorner.TopRight);     // The corner leading to small room from hallway
            DrawWallCorner(18, 4, WallCorner.TopLeft);      // The corner leading to small room from hallway
            DrawWallCorner(16, 5, WallCorner.BottomRight);  // The corner leading to small room
            DrawWallCorner(18, 5, WallCorner.BottomLeft);   // The corner leading to small room

            //Gem room 
            DrawWallVertical(28, 5, 4);
            DrawWallHorizontal(29, 1, 13);
            DrawWallVertical(42, 2, 7);
            DrawWallHorizontal(29, 9, 13);
            DrawWallCorner(28, 1, WallCorner.TopLeft);      // The corner of the gem room
            DrawWallCorner(28, 9, WallCorner.BottomLeft);   // The corner of the gem room
            DrawWallCorner(42, 1, WallCorner.TopRight);     // The corner of the gem room
            DrawWallCorner(42, 9, WallCorner.BottomRight);  // The corner of the gem room

            //Small room
            DrawWallHorizontal(13, 5, 3);
            DrawWallHorizontal(14, 7, 5);
            DrawWallVertical(19, 6, 1);
            DrawWallVertical(13, 6, 1);
            DrawWallCorner(19, 5, WallCorner.TopRight);     // The corner of the small room
            DrawWallCorner(13, 5, WallCorner.TopLeft);      // The corner of the small room
            DrawWallCorner(13, 7, WallCorner.BottomLeft);   // The corner of the small room
            DrawWallCorner(19, 7, WallCorner.BottomRight);  // The corner of the small room

        }

        public void fourRoom()
        {
            // Draw the walls first
            DrawWallHorizontal(1, 0, 10);                   // Draw the top wall
            DrawWallVertical(0, 1, 6);                      // Draw left wall
            DrawWallHorizontal(1, 7, 10);                   // Draw the bottom wall	
            DrawWallVertical(11, 1, 1);                     // Draw top right wall
            DrawWallVertical(11, 5, 2);                     // Draw bottom right wall

            // Wall corners
            DrawWallCorner(0, 0, WallCorner.TopLeft);
            DrawWallCorner(11, 0, WallCorner.TopRight);
            DrawWallCorner(0, 7, WallCorner.BottomLeft);
            DrawWallCorner(11, 7, WallCorner.BottomRight);
            DrawWallCorner(11, 2, WallCorner.BottomLeft);   // The entrance to the hallway
            DrawWallCorner(11, 4, WallCorner.TopLeft);      // The entrance to the hallway

            //Draws horizontal hallway
            DrawWallHorizontal(12, 4, 4);
            DrawWallHorizontal(19, 4, 2);   // This depends on user input
            DrawWallHorizontal(25, 4, 3);   // This depends on user input
            DrawWallHorizontal(12, 2, 17);

            //Corners galore
            DrawWallCorner(28, 4, WallCorner.TopRight);     // The entrance to the other room
            DrawWallCorner(28, 2, WallCorner.BottomRight);  // The entrance to the other room

            DrawWallCorner(16, 4, WallCorner.TopRight);     // The corner leading to small room from hallway
            DrawWallCorner(18, 4, WallCorner.TopLeft);      // The corner leading to small room from hallway
            DrawWallCorner(16, 5, WallCorner.BottomRight);  // The corner leading to small room
            DrawWallCorner(18, 5, WallCorner.BottomLeft);   // The corner leading to small room

            DrawWallCorner(24, 4, WallCorner.TopLeft);      // The corner leading to the long hallway
            DrawWallCorner(21, 4, WallCorner.TopRight);     // The corner leading to the long hallway

            DrawWallCorner(21, 12, WallCorner.BottomRight); // The corner leading from long hall to brlh
            DrawWallCorner(24, 12, WallCorner.BottomLeft);  // The corner leading from long hall to brlh

            //Long hallway
            DrawWallVertical(21, 5, 7);
            DrawWallVertical(24, 5, 7);

            //Big room from long hallway (brlh)
            DrawWallHorizontal(25, 12, 10);
            DrawWallHorizontal(11, 12, 10);
            DrawWallVertical(10, 13, 10);
            DrawWallHorizontal(11, 23, 23);
            DrawWallVertical(34, 13, 10);                    
            DrawWallCorner(10, 12, WallCorner.TopLeft);     // The corner of the big room
            DrawWallCorner(10, 23, WallCorner.BottomLeft);  // The corner of the big room
            DrawWallCorner(34, 12, WallCorner.TopRight);    // The corner of the big room
            DrawWallCorner(34, 23, WallCorner.BottomRight); // The corner of the big room

            //Gem room 
            DrawWallVertical(28, 5, 4);
            DrawWallHorizontal(29, 1, 13);
            DrawWallVertical(42, 2, 7);
            DrawWallHorizontal(29, 9, 13);
            DrawWallCorner(28, 1, WallCorner.TopLeft);      // The corner of the gem room
            DrawWallCorner(28, 9, WallCorner.BottomLeft);   // The corner of the gem room
            DrawWallCorner(42, 1, WallCorner.TopRight);     // The corner of the gem room
            DrawWallCorner(42, 9, WallCorner.BottomRight);  // The corner of the gem room

            //Small room
            DrawWallHorizontal(13, 5, 3);
            DrawWallHorizontal(14, 7, 5);
            DrawWallVertical(19, 6, 1);
            DrawWallVertical(13, 6, 1);
            DrawWallCorner(19, 5, WallCorner.TopRight);     // The corner of the small room
            DrawWallCorner(13, 5, WallCorner.TopLeft);      // The corner of the small room
            DrawWallCorner(13, 7, WallCorner.BottomLeft);   // The corner of the small room
            DrawWallCorner(19, 7, WallCorner.BottomRight);  // The corner of the small room
        }

        public void fiveRoom()
        {
            // Draw the walls first
            DrawWallHorizontal(1, 0, 10);                   // Draw the top wall
            DrawWallVertical(0, 1, 6);                      // Draw left wall
            DrawWallHorizontal(1, 7, 10);                   // Draw the bottom wall	
            DrawWallVertical(11, 1, 1);                     // Draw top right wall
            DrawWallVertical(11, 5, 2);                     // Draw bottom right wall

            // Wall corners
            DrawWallCorner(0, 0, WallCorner.TopLeft);
            DrawWallCorner(11, 0, WallCorner.TopRight);
            DrawWallCorner(0, 7, WallCorner.BottomLeft);
            DrawWallCorner(11, 7, WallCorner.BottomRight);
            DrawWallCorner(11, 2, WallCorner.BottomLeft);   // The entrance to the hallway
            DrawWallCorner(11, 4, WallCorner.TopLeft);      // The entrance to the hallway

            //Draws horizontal hallway
            DrawWallHorizontal(12, 4, 4);
            DrawWallHorizontal(19, 4, 2);   // This depends on user input
            DrawWallHorizontal(25, 4, 3);   // This depends on user input
            DrawWallHorizontal(12, 2, 17);

            //Corners galore
            DrawWallCorner(28, 4, WallCorner.TopRight);     // The entrance to the other room
            DrawWallCorner(28, 2, WallCorner.BottomRight);  // The entrance to the other room

            DrawWallCorner(16, 4, WallCorner.TopRight);     // The corner leading to small room from hallway
            DrawWallCorner(18, 4, WallCorner.TopLeft);      // The corner leading to small room from hallway
            DrawWallCorner(16, 5, WallCorner.BottomRight);  // The corner leading to small room
            DrawWallCorner(18, 5, WallCorner.BottomLeft);   // The corner leading to small room

            DrawWallCorner(24, 4, WallCorner.TopLeft);      // The corner leading to the long hallway
            DrawWallCorner(21, 4, WallCorner.TopRight);     // The corner leading to the long hallway

            DrawWallCorner(21, 12, WallCorner.BottomRight); // The corner leading from long hall to brlh
            DrawWallCorner(24, 12, WallCorner.BottomLeft);  // The corner leading from long hall to brlh

            DrawWallCorner(39, 17, WallCorner.BottomRight); // The corner leading to room on immediate right
            DrawWallCorner(39, 19, WallCorner.TopRight);    // The corner leading to room on immediate right

            //Long hallway
            DrawWallVertical(21, 5, 7);
            DrawWallVertical(24, 5, 7);

            //Big room from long hallway (brlh)
            DrawWallHorizontal(25, 12, 10);
            DrawWallHorizontal(11, 12, 10);
            DrawWallVertical(10, 13, 10);
            DrawWallHorizontal(11, 23, 23);
            DrawWallVertical(34, 13, 4);                    // Else (34, 13, 10)
            DrawWallVertical(34, 20, 3);                    // This depends on user input
            DrawWallCorner(34, 19, WallCorner.TopLeft);     // This depends on user input
            DrawWallCorner(34, 17, WallCorner.BottomLeft);  // This depends on user input
            DrawWallCorner(10, 12, WallCorner.TopLeft);     // The corner of the big room
            DrawWallCorner(10, 23, WallCorner.BottomLeft);  // The corner of the big room
            DrawWallCorner(34, 12, WallCorner.TopRight);    // The corner of the big room
            DrawWallCorner(34, 23, WallCorner.BottomRight); // The corner of the big room

            //Gem room 
            DrawWallVertical(28, 5, 4);
            DrawWallHorizontal(29, 1, 13);
            DrawWallVertical(42, 2, 7);
            DrawWallHorizontal(29, 9, 13);
            DrawWallCorner(28, 1, WallCorner.TopLeft);      // The corner of the gem room
            DrawWallCorner(28, 9, WallCorner.BottomLeft);   // The corner of the gem room
            DrawWallCorner(42, 1, WallCorner.TopRight);     // The corner of the gem room
            DrawWallCorner(42, 9, WallCorner.BottomRight);  // The corner of the gem room

            //Small room
            DrawWallHorizontal(13, 5, 3);
            DrawWallHorizontal(14, 7, 5);
            DrawWallVertical(19, 6, 1);
            DrawWallVertical(13, 6, 1);
            DrawWallCorner(19, 5, WallCorner.TopRight);     // The corner of the small room
            DrawWallCorner(13, 5, WallCorner.TopLeft);      // The corner of the small room
            DrawWallCorner(13, 7, WallCorner.BottomLeft);   // The corner of the small room
            DrawWallCorner(19, 7, WallCorner.BottomRight);  // The corner of the small room

            //Hallway from brlh
            DrawWallHorizontal(35, 17, 4);
            DrawWallHorizontal(35, 19, 4);

            //Room on immediate right of brlh (roir)
            DrawWallVertical(39, 12, 5);
            DrawWallVertical(39, 20, 2);
            DrawWallVertical(42, 12, 10);    
            DrawWallHorizontal(40, 22, 2);
            DrawWallHorizontal(40, 11, 2);
            DrawWallCorner(42, 11, WallCorner.TopRight);
            DrawWallCorner(39, 11, WallCorner.TopLeft);
            DrawWallCorner(39, 22, WallCorner.BottomLeft);
            DrawWallCorner(42, 22, WallCorner.BottomRight);
        }

        public void sixRoom()
        {
            // Draw the walls first
            DrawWallHorizontal(1, 0, 10);                   // Draw the top wall
            DrawWallVertical(0, 1, 6);                      // Draw left wall
            DrawWallHorizontal(1, 7, 10);                   // Draw the bottom wall	
            DrawWallVertical(11, 1, 1);                     // Draw top right wall
            DrawWallVertical(11, 5, 2);                     // Draw bottom right wall

            // Wall corners
            DrawWallCorner(0, 0, WallCorner.TopLeft);
            DrawWallCorner(11, 0, WallCorner.TopRight);
            DrawWallCorner(0, 7, WallCorner.BottomLeft);
            DrawWallCorner(11, 7, WallCorner.BottomRight);
            DrawWallCorner(11, 2, WallCorner.BottomLeft);   // The entrance to the hallway
            DrawWallCorner(11, 4, WallCorner.TopLeft);      // The entrance to the hallway

            //Draws horizontal hallway
            DrawWallHorizontal(12, 4, 4);
            DrawWallHorizontal(19, 4, 2);   // This depends on user input
            DrawWallHorizontal(25, 4, 3);   // This depends on user input
            DrawWallHorizontal(12, 2, 17);

            //Corners galore
            DrawWallCorner(28, 4, WallCorner.TopRight);     // The entrance to the other room
            DrawWallCorner(28, 2, WallCorner.BottomRight);  // The entrance to the other room

            DrawWallCorner(16, 4, WallCorner.TopRight);     // The corner leading to small room from hallway
            DrawWallCorner(18, 4, WallCorner.TopLeft);      // The corner leading to small room from hallway
            DrawWallCorner(16, 5, WallCorner.BottomRight);  // The corner leading to small room
            DrawWallCorner(18, 5, WallCorner.BottomLeft);   // The corner leading to small room

            DrawWallCorner(24, 4, WallCorner.TopLeft);      // The corner leading to the long hallway
            DrawWallCorner(21, 4, WallCorner.TopRight);     // The corner leading to the long hallway

            DrawWallCorner(21, 12, WallCorner.BottomRight); // The corner leading from long hall to brlh
            DrawWallCorner(24, 12, WallCorner.BottomLeft);  // The corner leading from long hall to brlh

            DrawWallCorner(39, 17, WallCorner.BottomRight); // The corner leading to room on immediate right
            DrawWallCorner(39, 19, WallCorner.TopRight);    // The corner leading to room on immediate right

            DrawWallCorner(42, 13, WallCorner.BottomLeft);  // The corner leading from roir to hallway
            DrawWallCorner(42, 14, WallCorner.TopLeft);     // The corner leading from roir to hallway

            DrawWallCorner(46, 13, WallCorner.BottomRight); // The corner leading from hallway to next room
            DrawWallCorner(46, 14, WallCorner.TopRight);     // The corner leading from hallway to next room

            //Long hallway
            DrawWallVertical(21, 5, 7);
            DrawWallVertical(24, 5, 7);

            //Big room from long hallway (brlh)
            DrawWallHorizontal(25, 12, 10);
            DrawWallHorizontal(11, 12, 10);
            DrawWallVertical(10, 13, 10);
            DrawWallHorizontal(11, 23, 23);
            DrawWallVertical(34, 13, 4);                    // Else (34, 13, 10)
            DrawWallVertical(34, 20, 3);                    // This depends on user input
            DrawWallCorner(34, 19, WallCorner.TopLeft);     // This depends on user input
            DrawWallCorner(34, 17, WallCorner.BottomLeft);  // This depends on user input
            DrawWallCorner(10, 12, WallCorner.TopLeft);     // The corner of the big room
            DrawWallCorner(10, 23, WallCorner.BottomLeft);  // The corner of the big room
            DrawWallCorner(34, 12, WallCorner.TopRight);    // The corner of the big room
            DrawWallCorner(34, 23, WallCorner.BottomRight); // The corner of the big room

            //Gem room 
            DrawWallVertical(28, 5, 4);
            DrawWallHorizontal(29, 1, 13);
            DrawWallVertical(42, 2, 7);
            DrawWallHorizontal(29, 9, 13);
            DrawWallCorner(28, 1, WallCorner.TopLeft);      // The corner of the gem room
            DrawWallCorner(28, 9, WallCorner.BottomLeft);   // The corner of the gem room
            DrawWallCorner(42, 1, WallCorner.TopRight);     // The corner of the gem room
            DrawWallCorner(42, 9, WallCorner.BottomRight);  // The corner of the gem room

            //Small room
            DrawWallHorizontal(13, 5, 3);
            DrawWallHorizontal(14, 7, 5);
            DrawWallVertical(19, 6, 1);
            DrawWallVertical(13, 6, 1);
            DrawWallCorner(19, 5, WallCorner.TopRight);     // The corner of the small room
            DrawWallCorner(13, 5, WallCorner.TopLeft);      // The corner of the small room
            DrawWallCorner(13, 7, WallCorner.BottomLeft);   // The corner of the small room
            DrawWallCorner(19, 7, WallCorner.BottomRight);  // The corner of the small room

            //Hallway from brlh
            DrawWallHorizontal(35, 17, 4);
            DrawWallHorizontal(35, 19, 4);

            //Room on immediate right of brlh (roir)
            DrawWallVertical(39, 12, 5);
            DrawWallVertical(39, 20, 2);
            DrawWallVertical(42, 12, 1);    // Else (42, 12, 10)
            DrawWallVertical(42, 15, 7);    // This depends on user input
            DrawWallHorizontal(40, 22, 2);
            DrawWallHorizontal(40, 11, 2);
            DrawWallCorner(42, 11, WallCorner.TopRight);
            DrawWallCorner(39, 11, WallCorner.TopLeft);
            DrawWallCorner(39, 22, WallCorner.BottomLeft);
            DrawWallCorner(42, 22, WallCorner.BottomRight);

            //Hallway from roir
            DrawWallHorizontal(43, 13, 3);
            DrawWallHorizontal(43, 14, 3);

            //Next Room
            DrawWallVertical(46, 9, 4);
            DrawWallVertical(46, 15, 1);
            DrawWallHorizontal(47, 16, 14);
            DrawWallHorizontal(47, 8, 14);
            DrawWallVertical(61, 9, 7);
            DrawWallCorner(61, 8, WallCorner.TopRight);
            DrawWallCorner(46, 8, WallCorner.TopLeft);
            DrawWallCorner(61, 16, WallCorner.BottomRight);
            DrawWallCorner(46, 16, WallCorner.BottomLeft);
        }

                                         // **********************************************************
                                         // * THE END OF ALL THAT HAS BEEN MODIFIED IN THIS DOCUMENT *
                                         // **********************************************************

        /// <summary>
        /// Draws a vertical wall, starting at the specified position
        /// and moving "down"
        /// </summary>
        /// <param name="startX">The x position of the entire wall</param>
        /// <param name="startY">The y position of the "top" of the wall</param>
        /// <param name="length">The length of the wall</param>
        /// <param name="color">Optional color to use instead of the default</param>
        /// <param name="character">Optional character to use instead of the default</param>
        public void DrawWallVertical(int startX, int startY, int length, ConsoleColor color = ConsoleColor.White, char character = '║')
		{
			// Valid length?
			if (length <= 0)
			{
				return;
			}

			// Check for valid x placement
			if( startX < 0 || startX >= dungeonWidth )
			{
				// Nothing to draw, get out of the method early
				return;
			}

			// Loop and "draw" the wall
            Console.ForegroundColor = color;
			for (int y = startY; y < startY + length; y++)
			{
				// Valid placement?
				if (y < 0 || y >= dungeonHeight)
				{
					// Skip this character
					continue;
				}

                // Set the cursor position
                Console.CursorLeft = startX;
                Console.CursorTop = y;

				// Draw the wall
                
                Console.Write(character);
			}

            // Reset the color
            Console.ForegroundColor = ConsoleColor.Gray;
		}

		/// <summary>
		/// Draws a horizontal wall, starting at the specified position
		/// and moving "right"
		/// </summary>
		/// <param name="startX">The x position of the "left" side of the wall</param>
		/// <param name="startY">The y position of the entire wall</param>
		/// <param name="length">The length of the wall</param>
		public void DrawWallHorizontal(int startX, int startY, int length, ConsoleColor color = ConsoleColor.White, char character = '═')
		{
			// Valid length?
			if (length <= 0)
			{
				return;
			}
			
			// Check for valid y placement
			if (startY < 0 || startY >= dungeonHeight)
			{
				// Nothing to draw, get out of the method early
				return;
			}

			// Loop and "draw" the wall
            Console.ForegroundColor = color;
			for (int x = startX; x < startX + length; x++)
			{
				// Valid placement?
				if (x < 0 || x >= dungeonWidth)
				{
					// Skip this character
					continue;
				}

                // Set the cursor position
                Console.CursorLeft = x;
                Console.CursorTop = startY;

				// Draw the wall
                Console.Write(character);
			}

            // Reset the color
            Console.ForegroundColor = ConsoleColor.Gray;
		}

        /// <summary>
        /// Draws an appropriate wall corner character
        /// </summary>
        /// <param name="x">The x position of the corner</param>
        /// <param name="y">The y position of the corner</param>
        /// <param name="corner">Which corner is being drawn?</param>
		/// <param name="color">An optional color to use for this corner</param>
		/// <param name="cornerChar">An optional character to draw instead of the default</param>
		public void DrawWallCorner(int x, int y, WallCorner corner, ConsoleColor color = ConsoleColor.White, char cornerChar = ' ')
        {
            // Valid placement?
            if (x < 0 || x >= dungeonWidth ||
                y < 0 || y >= dungeonHeight)
            {
                return;
            }

            // Set the cursor position
            Console.CursorLeft = x;
            Console.CursorTop = y;

            // Which character should be drawn?
            char charToDraw = ' ';
			if (cornerChar != ' ')
			{
				// Use the requested character
				charToDraw = cornerChar;
			}
			else
			{
				// Use a default character
				switch (corner)
				{
					case WallCorner.TopLeft: charToDraw = '╔'; break;
					case WallCorner.TopRight: charToDraw = '╗'; break;
					case WallCorner.BottomLeft: charToDraw = '╚'; break;
					case WallCorner.BottomRight: charToDraw = '╝'; break;
				}
			}

			// Everything is valid, draw the corner
			Console.ForegroundColor = color;
			Console.Write(charToDraw);
			Console.ForegroundColor = ConsoleColor.Gray;
        }

		/// <summary>
		/// Draws an "object" (represented by a single character) somewhere
		/// in the dungeon
		/// </summary>
		/// <param name="x">The x position of the object</param>
		/// <param name="y">The y position of the object</param>
		/// <param name="obj">The character that represents the object</param>
        /// <param name="color">The color of the object</param>
		public void DrawObject(int x, int y, char obj, ConsoleColor color = ConsoleColor.Cyan)
		{
			// Valid placement?
			if (x < 0 || x >= dungeonWidth ||
				y < 0 || y >= dungeonHeight)
			{
				return;
			}

            // Set the cursor position
            Console.CursorLeft = x;
            Console.CursorTop = y;

			// Everything is valid, place the object
            Console.ForegroundColor = color;
            Console.Write(obj);
            Console.ForegroundColor = ConsoleColor.Gray;
		}

		
	}
}
