using System;

namespace Victorina
{
    class GeoQuestions : Question
    {
        public GeoQuestions()
        {
            type_ = new string("Гео");
        }

        public string GetType()
        {
            return type_;
        }

        private string type_;
    }
}
