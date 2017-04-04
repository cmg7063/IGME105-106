using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    class Graph
    {
        // Attributes
        private int[,] adjMatrix = new int [7,7];
        private Vertex[] vertices = new Vertex[7];
        private int numVerts;

        // Constructor
        public Graph()
        {
        }

        // Methods
        public void AddVertex(Vertex vertex)
        {
            if(numVerts < 7)
            {
                vertices[numVerts] = vertex;
                numVerts++;
            }
        }

        public Vertex GetVertex(int position)
        {
            // If an invalid location is passed in, return null
            if (position > 6 || position < 0)
            {
                return null;
            }
            // Otherwise, return the Vertex object from that location
            return vertices[position];      
        }

        public void ConnectVertices(int head, int tail)
        {
            // Connection between start and end locations in array
            adjMatrix[head, tail] = 1;
        }

        public List<int> GetAdjacent(int position)
        {
            List<int> adjList = new List<int>();
            for(int i = 0; i < 7; i++)
            {
                if(adjMatrix[position, i] == 1)
                {
                    adjList.Add(i);               
                }
            }
            return adjList;
        }
    }
}
