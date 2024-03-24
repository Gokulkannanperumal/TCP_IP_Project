using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using TCPObj;

namespace TCP.Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = null;
            try
            {
                // Set the server's IP address and port
                IPAddress ipAddress = IPAddress.Parse("192.168.1.4");
                int port = 12345;

                // Create a TCP/IP socket
                server = new TcpListener(ipAddress, port);

                // Start listening for client connections
                server.Start();

                Console.WriteLine("Server is listening on port 12345");

                // Enter the listening loop
                while (true)
                {
                    Console.WriteLine("Waiting for a connection...");

                    // Accept the client connection
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine($"Connection from {((IPEndPoint)client.Client.RemoteEndPoint).Address}");

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    BinaryFormatter formatter = new BinaryFormatter();
                    loginObj login = (loginObj)formatter.Deserialize(stream);
                    string result = string.Empty;
                    if (login.username.ToUpper() == "GOKUL" && login.password == "9786")
                    {
                        result = "Valid";
                    }
                    else
                        result = "Invalid";

                    // Buffer for the data
                    //byte[] bytes = new byte[2048];
                    //int bytesRead;

                        //// Loop to receive all the data sent by the client
                        //while ((bytesRead = stream.Read(bytes, 0, bytes.Length)) != 0)
                        //{
                        //    // Convert the data bytes to a string
                        //    string data = Encoding.ASCII.GetString(bytes, 0, bytesRead);
                        //    Console.WriteLine($"Received: {data}");

                        //    // Echo the data back to the client
                        byte[] response = Encoding.ASCII.GetBytes(result);
                        stream.Write(response, 0, response.Length);
                    //}

                    // Close the connection
                    client.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                // Stop listening for new clients
                server?.Stop();
            }
        }
    }
}
