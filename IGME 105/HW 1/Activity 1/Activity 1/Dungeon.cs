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
