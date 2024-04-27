using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Client
{
    class Program
    {
        private const string SERVER_ADDRESS = "127.0.0.1";
        private const int PORT = 12345;

        static void Main(string[] args)
        {
            TcpClient clientSocket = new TcpClient();
            clientSocket.Connect(SERVER_ADDRESS, PORT);
            Console.WriteLine("Connected to server.");

            NetworkStream networkStream = clientSocket.GetStream();
            BinaryFormatter formatter = new BinaryFormatter();

            // Simulate sending occupancy data
            SendOccupancyData(networkStream, formatter);

            // Request aggregated occupancy data
            SendOccupancyDataRequest(networkStream, formatter);

            clientSocket.Close();
            Console.WriteLine("Connection closed.");
        }

        static void SendOccupancyData(NetworkStream networkStream, BinaryFormatter formatter)
        {
            Dictionary<(int, int), int> occupancyData = new Dictionary<(int, int), int>
            {
                { (1, 2), 0 },
                { (1, 3), 1 },
                { (2, 2), 0 },
                { (2, 3), 0 }
            };

            formatter.Serialize(networkStream, occupancyData);
            Console.WriteLine("Occupancy data sent to server.");
        }

        static void SendOccupancyDataRequest(NetworkStream networkStream, BinaryFormatter formatter)
        {
            Dictionary<(int, int), int> occupancyRequest = new Dictionary<(int, int), int>();
            formatter.Serialize(networkStream, occupancyRequest);
            Console.WriteLine("Request for aggregated occupancy data sent to server.");
        }
    }
}
