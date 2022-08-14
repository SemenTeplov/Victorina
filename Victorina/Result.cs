namespace Victorina
{
    class Result
    {
        public Result() { }
        public Result(string login, string points) 
        {
            login_ = login;
            points_ = points;
        }

        public string getLogin() => login_;
        public string getPoint() => points_;

        private string login_;
        private string points_;
    }
}
