namespace Victorina
{
    class Client
    {
        public Client() { }
        public Client(string login, string password, string birthday) 
        {
            login_ = login;
            password_ = password;
            birthday_ = birthday;
        }

        public void SetLogin(string login)
        {
            login_ = login;
        }
        public void SetPassword(string password)
        {
            password_ = password;
        }
        public void SetBirthday(string birthday)
        {
            birthday_ = birthday;
        }

        public string GetLogin() 
        {
            return login_;
        }
        public string GetPassword()
        {
            return password_;
        }
        public string GetBirthday()
        {
            return birthday_;
        }

        private string login_;
        private string password_;
        private string birthday_;
    }
}
