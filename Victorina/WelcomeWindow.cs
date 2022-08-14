using System;

namespace Victorina
{
    class WelcomeWindow
    {
        public WelcomeWindow()
        {
            log_ = "Введите логин.";
            pas_ = "Введие пароль";
            bir_ = "Введите день рождения";
            mes_ = "Значение введено не правильно";

            list_ = new ListClients();
        }

        public void Run()
        {
            while (true)
            {
                Menu();

                if (Enter())
                {
                    menu_ = new Menu(client_);
                    menu_.GetMenu();
                }
                else
                {
                    if (NewClient())
                    {
                        menu_ = new Menu(client_);
                        menu_.GetMenu();
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private void Menu()
        {
            Console.WriteLine("Добро пожаловать.\n");
            Console.WriteLine(log_);
            userlog_ = Console.ReadLine();
            Console.WriteLine(pas_);
            userpas_ = Console.ReadLine();
            Console.WriteLine(bir_);
            userbir_ = Console.ReadLine();
        }
        private bool Enter()
        {
            client_ = list_.OutClient(userlog_);

            if ((client_.GetLogin() == userlog_) && 
                (client_.GetPassword() == userpas_) &&
                (client_.GetBirthday() == userbir_))
            {
                return true;
            }
            Console.WriteLine(mes_);
            return false;
        }
        private bool NewClient()
        {
            Console.WriteLine("Хотите создать новый аккаунт (Да или Нет)?");
            string choise = Console.ReadLine();
            if (choise == "Да")
            {
                list_.NewClient(userlog_, userpas_, userbir_);
                Console.WriteLine("Новый аккаунт создан.");

                return true;
            }

            return false;
        }

        private string log_;
        private string userlog_;
        private string pas_;
        private string userpas_;
        private string bir_;
        private string userbir_;
        private string mes_;
        private Client client_;
        private ListClients list_;
        private Menu menu_;
    }
}
