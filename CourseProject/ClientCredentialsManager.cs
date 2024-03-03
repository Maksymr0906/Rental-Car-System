using System;
using System.Collections.Generic;
using System.IO;

namespace CourseProject
{
    public static class ClientCredentialsManager
    {
        private static readonly string USERS_FILENAME;
        public static List<User> Users { get; set; }

        static ClientCredentialsManager()
        {
            USERS_FILENAME = "users.txt";

            if (!File.Exists(USERS_FILENAME))
            {
                File.Create(USERS_FILENAME).Close();
            }

            Users = new List<User>();

            string[] lines = File.ReadAllLines(USERS_FILENAME);

            foreach (var line in lines)
            {
                string[] data = line.Split(',');
                var client = new Client()
                {
                    Id = Guid.Parse(data[0]),
                    Login = data[1],
                    Password = data[2],
                    Name = data[3],
                    Surname = data[4],
                    DateOfBirthday = Convert.ToDateTime(data[5]),
                    Money = Convert.ToDouble(data[6])
                };

                Users.Add(client);
            }
        }
        public static List<Client> ReadClientCredentialsFromFile()
        {
            var clientCredentials = new List<Client>();

            string[] lines = File.ReadAllLines(USERS_FILENAME);

            foreach (var line in lines)
            {
                string[] data = line.Split(',');
                var client = new Client()
                {
                    Id = Guid.Parse(data[0]),
                    Login = data[1],
                    Password = data[2],
                    Name = data[3],
                    Surname = data[4],
                    DateOfBirthday = Convert.ToDateTime(data[5]),
                    Money = Convert.ToDouble(data[6])
                };

                clientCredentials.Add(client);
            }

            return clientCredentials;
        }

        public static void WriteClientToFile(Client client)
        {
            using (var writer = new StreamWriter(USERS_FILENAME, true))
            {
                client.WriteToFile(writer);
            }
        }

        public static void AddClient(Client client)
        {
            Users.Add(client);
        }

        public static void UpdateClient(Client client)
        {
            for(int i = 0; i < Users.Count ; i++)
            {
                if (Users[i].Id == client.Id)
                {
                    Users[i] = client;
                }
            }
        }
    }
}
