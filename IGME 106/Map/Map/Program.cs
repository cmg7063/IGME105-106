using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Map
{
    /****************************************************************
     * THIS IS THE TEST CLASS FOR EXAM 3, SPRING 2016
     * 
     * CHANGING ANY OF THE CODE IN THIS CLASS AUTOMATICALLY GETS YOU
     * A ZERO FOR THIS PART OF THE EXAM. IF YOUR CODE DOESN'T WORK,
     * FIX IT IN YOUR OWN CODE.
     * 
     *             Prof. Bierre
     * **************************************************************/
    class Program
    {
        static void Main(string[] args)
        {
            // create the Graph object
            Graph myGraph = new Graph();
            
            // create and add the vertices
            Vertex v1 = new Vertex("Start", 3, 0, 0); // parameters: name,enemies,power ups,loot
            Vertex v2 = new Vertex("Dark Chamber", 3, 5, 0);
            Vertex v3 = new Vertex("Loot Haven", 5, 0, 12);
            Vertex v4 = new Vertex("Rest Chamber", 0, 7, 3);
            Vertex v5 = new Vertex("A Good Day to Die", 15, 1, 2);
            Vertex v6 = new Vertex("Load Up", 3, 20, 0);
            Vertex v7 = new Vertex("Beat This to Exit", 30, 10, 4);

            myGraph.AddVertex(v1);
            myGraph.AddVertex(v2);
            myGraph.AddVertex(v3);
            myGraph.AddVertex(v4);
            myGraph.AddVertex(v5);
            myGraph.AddVertex(v6);
            myGraph.AddVertex(v7);

            // connect the vertices
            myGraph.ConnectVertices(0, 1);
            myGraph.ConnectVertices(0, 2);
            myGraph.ConnectVertices(1, 3);
            myGraph.ConnectVertices(1, 4);
            myGraph.ConnectVertices(2, 3);
            myGraph.ConnectVertices(2, 5);
            myGraph.ConnectVertices(3, 4);
            myGraph.ConnectVertices(4, 6);
            myGraph.ConnectVertices(5, 6);

            // follow path 1: v1 - v2 - v5 - v7
            Console.WriteLine("Path 1: v1 - v2 - v5 - v7:");
            int [] path1 = {0,1,4,6};
            FollowPath(myGraph, path1);
            
            // path 2: 
            Console.WriteLine("\nPath 2: v1 - v2 - v4 - v5 - v7:");
            int[] path2 = { 0, 1, 3, 4, 6 };
            FollowPath(myGraph, path2);

            // path 3: v1 - v3 - v6 - v7
            Console.WriteLine("\nPath 3: v1 - v3 - v6 - v7:");
            int[] path3 = { 0, 2, 5, 6 };
            FollowPath(myGraph, path3);

            // pause the program after a run 
            Thread.Sleep(60000); // delay a minute - can close the cmd window before time is up
        }

        // helper method
        public static void FollowPath(Graph myGraph,int [] path)
        {
            foreach(int pos in path)
            {
                Vertex vert = myGraph.GetVertex(pos);
                if(vert == null)
                {
                    Console.WriteLine("Error: GetVertex(" + pos + ") returns a null. Invalid graph.");
                    return;
                }
                else if(pos == 0)
                {
                    Console.WriteLine("Starting at: " + vert);
                }
                else
                {
                    Console.WriteLine("Current Vertex: " + vert);
                }

                List<int> adj = myGraph.GetAdjacent(pos);
                if (adj.Count <= 0 && pos != 6)
                {
                    Console.WriteLine("Error: adjacent vertices list is null. Invalid graph.");
                    return;
                }
                else if(adj.Count <= 0 && pos == 6) // end of graph
                {
                    Console.WriteLine("Have reached the end of the graph - success");
                }
                else
                {
                    Console.Write("Vertex at " + pos + " is connected to ");
                    foreach(int vPos in adj)
                    {
                        Console.Write(vPos + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
