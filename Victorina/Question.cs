using System.Collections.Generic;

namespace Victorina
{
    abstract public class Question
    {
        public Question() 
        {
            question_ = new string("");
            answers_ = new List<string>();
            trueAnswer_ = new string("");
        }
        public Question(string question, string trueAnswer, params string[] answers)
        {
            question_ = new string(question);
            answers_ = new List<string>();
            trueAnswer_ = new string(trueAnswer);

            foreach (var str in answers)
            {
                answers_.Add(str);
            }
        }

        public void SetQuestions(string question)
        {
            question_ = question;
        }
        public void SetAnswers(params string[] answers)
        {
            foreach (var str in answers)
            {
                answers_.Add(str);
            }
        }
        public void SetTrueAnswer(string trueAnswer)
        {
            trueAnswer_ = trueAnswer;
        }

        public string GetQuestions()
        {
            return question_;
        }
        public List<string> GetAnswers()
        {
            return answers_;
        }
        public string GetTrueAnswer()
        {
            return trueAnswer_;
        }

        private string question_;
        private List<string> answers_;
        private string trueAnswer_;
    }
}
