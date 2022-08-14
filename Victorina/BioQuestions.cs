namespace Victorina
{
    class BioQuestions : Question
    {
        public BioQuestions()
        {
            type_ = new string("Био");
        }

        public string GetType()
        {
            return type_;
        }

        private string type_;
    }
}
