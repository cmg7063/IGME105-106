using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomQueue
{
	class Program
	{
		static void Main(string[] args)
		{
            GameQueue gq = new GameQueue();
            string player;

            gq.Enqueue("DafriendOrDafoe");
            gq.Enqueue("FoofieCake");
            gq.Enqueue("OldSchoolZinger");
            gq.Enqueue("hunterkiller223");
            gq.Enqueue("Fripberries");
            gq.Enqueue("Lancer2586");
            gq.Enqueue("J0ker5150");
            gq.Enqueue("fallenMTK");
            gq.Enqueue("LennoxMcGee");
            gq.Enqueue("JoshTheArty504");
            gq.Enqueue("L1z4rd$q4d");

            while (gq.IsEmpty == false)
            {
                player = gq.Dequeue();
                Console.WriteLine("Player '" + player + "' has joined the server: " + gq.Count + " player(s) left in queue");
            }
		}
	}
}
