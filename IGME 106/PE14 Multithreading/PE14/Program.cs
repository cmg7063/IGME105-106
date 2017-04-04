using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace PE14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parse my IP... change back to localhost before submission
            IPAddress address = IPAddress.Parse("127.0.0.1");

            TcpListener listener = null;

            try
            {
                listener = new TcpListener(address, 3333);  // Make sure the port numbers are the same as in the PE14Client
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error setting up listener: " + ex.Message);
                return;
            }
            listener.Start();

            while (true)
            {
                try
                {
                    Console.WriteLine("Waiting for client...");
                    Socket socket = listener.AcceptSocket();

                    // Create worker object
                    Worker worker = new Worker(socket);

                    // Create thread
                    Thread thread = new Thread(worker.Run);

                    thread.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection error: " + ex.Message);
                }
            }
        }
    }
}
