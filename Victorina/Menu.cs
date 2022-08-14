using System;

namespace Victorina
{
    class Menu
    {
        public Menu() { }
        public Menu(Client client)
        {
            v = new victorina();

            header_ = "\nМеню\n";
            textNewGame_ = "1. Новая игра.";
            textViewResults_ = "2. Результаты.";
            textViewResults20_ = "3. 20 лучших.";
            textSetting_ = "4. Настройки.";
            textQuit_ = "5 Выйти";
            mesError_ = "Неверный выбор";
            choise = "";

            clients_ = new ListClients();
            newClient_ = new Client();
            client_ = new Client();
            client_.SetLogin(client.GetLogin());
            client_.SetPassword(client.GetPassword());
            client_.SetBirthday(client.GetBirthday());

            tableResults_ = new TableResults();
        }

        public void GetMenu()
        {
            while (choise != "5")
            {
                Console.WriteLine(header_);
                Console.WriteLine(textNewGame_);
                Console.WriteLine(textViewResults_);
                Console.WriteLine(textViewResults20_);
                Console.WriteLine(textSetting_);
                Console.WriteLine(textQuit_);

                choise = Console.ReadLine();

                if (choise == "1")
                {
                    v.Play();
                    result_ = new Result(client_.GetLogin(), v.GetCount().ToString());
                    tableResults_.SaveResult(result_);
                }
                else if (choise == "2")
                {
                    tableResults_.GetList();
                }
                else if (choise == "3")
                {
                    tableResults_.GetList(20);
                }
                else if (choise == "4")
                {
                    Console.WriteLine("Введите новый логин");
                    newClient_.SetLogin(Console.ReadLine());
                    Console.WriteLine("Введите новый пароль");
                    newClient_.SetPassword(Console.ReadLine());
                    Console.WriteLine("Введите новый день рождения");
                    newClient_.SetBirthday(Console.ReadLine());

                    clients_.Save(newClient_, client_);
                }
            }
        }
        public void GerError()
        {
            Console.WriteLine(mesError_);
        }

        private string header_;
        private string textNewGame_;
        private string textViewResults_;
        private string textViewResults20_;
        private string textSetting_;
        private string textQuit_;
        private string mesError_;
        private string choise;

        private victorina v;
        private Client client_;
        private Client newClient_;
        private Result result_;
        private TableResults tableResults_;
        private ListClients clients_;
    }
}
