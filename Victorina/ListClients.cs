using System;
using System.IO;
using System.Collections.Generic;

namespace Victorina
{
    class ListClients
    {
        public ListClients()
        {
            listClents_ = new List<Client>();
            client_ = new Client();

            arrStr = File.ReadAllLines(@"Users.txt");
            foreach (var elem in arrStr)
            {
                str = elem.Split(" ");
                client_ = new Client(str[0], str[1], str[2]);

                listClents_.Add(client_);
            }
        }

        public void NewClient()
        {
            client_ = new Client();
            listClents_.Add(client_);
        }
        public void NewClient(string log, string pas, string bir)
        {
            client_ = new Client(log, pas, bir);
            listClents_.Add(client_);
            str = new string[3] { log, pas, bir };

            File.AppendAllText(@"Users.txt", str[0] + " " 
                + str[1] + " " + str[2]);

        }
        public Client OutClient(string log)
        {
            foreach (var client in listClents_)
            { 
                if (client.GetLogin() == log)
                {
                    return client;
                }
            }
            return new Client();
        }
        public void Save(Client newClient, Client oldClient)
        {
            for (int elem = 0; elem < listClents_.Count; elem++)
            {
                if (oldClient.GetLogin() == listClents_[elem].GetLogin())
                {
                    listClents_[elem] = newClient;
                }
            }
            File.Delete(@"Users.txt");
            List <Client> copyList = new List <Client>(listClents_);

            foreach (var client in copyList)
            {
                NewClient(client.GetLogin(), 
                    client.GetPassword(), 
                    client.GetBirthday());
                Console.WriteLine(1);
            }
        }

        private Client client_;
        private List<Client> listClents_;
        private string[] arrStr;
        private string[] str;
    }
}
