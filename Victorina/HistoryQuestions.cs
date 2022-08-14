using System;

namespace Victorina
{
    class HistoryQuestions : Question
    {
        public HistoryQuestions()
        {
            type_ = new string("Ист");
        }

        public new string GetType()
        {
            return type_;
        }

        private readonly string type_;
    }
}
