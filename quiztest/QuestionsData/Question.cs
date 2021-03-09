using System;

namespace quiztest.QuestionsData
{
    public class Question : EventArgs
    {
        public int Id { get; set; }

        public string Qstn { get; set; }

        public string OptionA { get; set; }

        public string OptionB { get; set; }

        public string OptionC { get; set; }

        public string OptionD { get; set; }

        public Question() { }

        public Question(int id, string q, string a, string b, string c, string d)
        {
            Id = id;
            Qstn = q;
            OptionA = a;
            OptionB = b;
            OptionC = c;
            OptionD = d;
        }
    }
}
