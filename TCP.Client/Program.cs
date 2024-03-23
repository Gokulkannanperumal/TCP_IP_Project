using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCP.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Set the server's IP address and port toconnect
                string serverIp = "192.168.1.4";
                int port = 12345;

                // Create a TCP/IP socket
                TcpClient client = new TcpClient(serverIp, port);

                // Get a stream object for reading and writing
                NetworkStream stream = client.GetStream();

                // Prompt the user for input
                Console.Write("Enter a message to send: ");
                string message = Console.ReadLine();

                // Convert the message to bytes
                byte[] data = Encoding.ASCII.GetBytes(message);

                // Send the data to the server
                stream.Write(data, 0, data.Length);

                Console.WriteLine("Sent: {0}", message);

                // Receive the response from the server
                data = new byte[2048];
                int bytesRead = stream.Read(data, 0, data.Length);
                string response = Encoding.ASCII.GetString(data, 0, bytesRead);

                Console.WriteLine("Received: {0}", response);
                Console.ReadKey();
                // Close the connection
                client.Close();

               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
