using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class AdjacencyList
    {
        // Attributes
        //private Dictionary<string, List<string>> list;
        private string[] vertices;
        private int[,] matrix;

        public AdjacencyList()
        {
            vertices = new string[5];
            vertices[0] = "MASTER BEDROOM";
            vertices[1] = "BATHROOM";
            vertices[2] = "DINING ROOM";
            vertices[3] = "STUDY";
            vertices[4] = "FAMILY ROOM";

            matrix = new int[5, 5];
            matrix[0, 0] = 0;
            matrix[0, 1] = 1;
            matrix[0, 2] = 1;
            matrix[0, 3] = 0;
            matrix[0, 4] = 0;

            matrix[1, 0] = 1;
            matrix[1, 1] = 0;
            matrix[1, 2] = 0;
            matrix[1, 3] = 1;
            matrix[1, 4] = 0;

            matrix[2, 0] = 1;
            matrix[2, 1] = 0;
            matrix[2, 3] = 1;
            matrix[2, 4] = 1;
            matrix[2, 2] = 0;

            matrix[3, 0] = 0;
            matrix[3, 1] = 1;
            matrix[3, 2] = 1;
            matrix[3, 4] = 0;
            matrix[3, 3] = 0;

            matrix[4, 0] = 0;
            matrix[4, 1] = 0;
            matrix[4, 2] = 1;
            matrix[4, 3] = 0;
            matrix[4, 4] = 0;

            /* 
            list = new Dictionary<string, List<string>>();
            List<string> mastEdges = new List<string> {"STUDY", "BATHROOM"};
            list.Add("MASTER BEDROOM", mastEdges);

            List<string> bathEdges = new List<string> { "STUDY", "MASTER BEDROOM"};
            list.Add("BATHROOM", bathEdges);

            List<string> studEdges = new List<string> { "DINING ROOM", "MASTER BEDROOM", "BATHROOM" };
            list.Add("STUDY", studEdges);

            List<string> famEdges = new List<string> { "DINING ROOM"};
            list.Add("FAMILY ROOM", famEdges);

            List<string> dinEdges = new List<string> { "FAMILY ROOM", "STUDY" };
            list.Add("DINING ROOM", dinEdges);
            */
        }

        public List<string> GetAdjacentList(string room)
        {
            string userInput = room.ToUpper();
            if(userInput == "MASTER BEDROOM")
            {
                List<string> roomList = new List<string>();
                roomList.Add("BATHROOM");
                roomList.Add("DINING ROOM");
                return roomList;
            }
            else if(userInput == "BATHROOM")
            {
                List<string> roomList = new List<string>();
                roomList.Add("MASTER BEDROOM");
                roomList.Add("STUDY");
                return roomList;
            }
            else if(userInput == "DINING ROOM")
            {
                List<string> roomList = new List<string>();
                roomList.Add("MASTER BEDROOM");
                roomList.Add("STUDY");
                roomList.Add("FAMILY ROOM");
                return roomList;
            }
            else if(userInput == "STUDY")
            {
                List<string> roomList = new List<string>();
                roomList.Add("BATHROOM");
                roomList.Add("DINING ROOM");
                return roomList;
            }
            else if(userInput == "FAMILY ROOM")
            {
                List<string> roomList = new List<string>();
                roomList.Add("DINING ROOM");
                return roomList;
            }
            return null;
        }

        public bool IsConnected(string room1, string room2)
        {
            string userInput_1 = room1.ToUpper();
            string userInput_2 = room2.ToUpper();

            if (userInput_1 == "MASTER BEDROOM" && userInput_2 == "BATHROOM" || userInput_2 == "DINING ROOM")
            {
                return true;
            }
            else if (userInput_1 == "BATHROOM" && userInput_2 == "MASTER BEDROOM" || userInput_2 == "STUDY")
            {
                return true;
            }
            else if (userInput_1 == "LIVING ROOM" && userInput_2 == "FAMILY ROOM" || userInput_2 == "MASTER BEDROOM" || userInput_2 == "STUDY")
            {
                return true;
            }
            if (userInput_1 == "STUDY" && userInput_2 == "BATHROOM" || userInput_2 == "DINING ROOM")
            {
                return true;
            }
            if (userInput_1 == "FAMILY ROOM" && userInput_2 == "DINING ROOM")
            {
                return true;
            }
            return false;
        }
        /*
        public List<string> GetAdjacentList(string room)
        {
            if (list.ContainsKey(room) == true)
            {
                return list[room];
            }
            return null;
        }

        public bool IsConnected(string room1, string room2)
        {
            if(list.ContainsKey(room1) == true)
            {
                if (list[room1].Contains(room2))
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        */
    }
}
