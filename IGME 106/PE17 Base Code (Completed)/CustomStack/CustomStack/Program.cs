using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomStack
{
	class Program
	{
		static void Main(string[] args)
		{
            string command; // String value for stack commands
            GameStack gameStack = new GameStack();

            // Populate stack with commands
            gameStack.Push("Move forward");
            gameStack.Push("Picking up an item");
            gameStack.Push("Shooting weapon");
            gameStack.Push("Move forward");
            gameStack.Push("Move forward");
            gameStack.Push("Move forward");
            gameStack.Push("Healing self");
            gameStack.Push("Move left");
            gameStack.Push("Move left");
            gameStack.Push("Picking up an item");

            while(gameStack.IsEmpty == false) // Pull commands off gameStack until count is zero
            {
                command = gameStack.Pop();
                Console.WriteLine(command);
            }
        }
	}
}
