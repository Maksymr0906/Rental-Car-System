using System;
using System.Collections.Generic;
using System.IO;

namespace CourseProject
{
    public static class ClientCredentialsManager
    {
        private static readonly string CLIENTS_FILENAME;
        public static List<Client> Clients { get; set; }

        static ClientCredentialsManager()
        {
            CLIENTS_FILENAME = "clients.txt";

            if (!File.Exists(CLIENTS_FILENAME))
            {
                File.Create(CLIENTS_FILENAME).Close();
            }

            ReadClientsFromFile();
        }

        private static void ReadClientsFromFile()
        {
            Clients = new List<Client>();

            string[] lines = File.ReadAllLines(CLIENTS_FILENAME);

            foreach (var line in lines)
            {
                var client = new Client();
                client.ReadFromFile(line);
                Clients.Add(client);
            }
        }

        public static void WriteClientsToFile()
        {
            using (var writer = new StreamWriter(CLIENTS_FILENAME, false))
            {
                foreach(var client in Clients)
                {
                    client.WriteToFile(writer);
                }
            }
        }

        public static void AddClient(Client client)
        {
            Clients.Add(client);
        }

        public static void UpdateClient(Client client)
        {
            for(int i = 0; i < Clients.Count ; i++)
            {
                if (Clients[i].Id == client.Id)
                {
                    Clients[i] = client;
                }
            }
        }
    }
}
