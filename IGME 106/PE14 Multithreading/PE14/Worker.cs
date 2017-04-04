using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace PE14
{
    class Worker
    {
        private Socket socket;

        // Parameterized constructor takes socket
        public Worker(Socket socket)
        {
            this.socket = socket;
        }

        public void Run()
        {
            StreamReader sr = new StreamReader(new NetworkStream(socket));
            StreamWriter sw = new StreamWriter(new NetworkStream(socket));

            string request = sr.ReadLine();
            Console.WriteLine("The client sent a " + request.Length + " character long string.");

            string response = "You sent: " + request + " at " + DateTime.Now.ToString();
            sw.WriteLine(response);
            sw.Flush();

            // Close connection
            socket.Close();
        }
    }
}