using System;
using System.Collections.Generic;
using System.Text;

namespace oopExam
{
    internal abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Answer[] Answers { get; set; }
        public Answer RightAnswer { get; set; }

        public Question(string header, string body, int mark,
                        Answer[] answers, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers;
            RightAnswer = rightAnswer;
        }

        public Question() : this("", "", 0, new Answer[0], null)
        {
        }

        public virtual void DisplayQuestion()
        {
            Console.WriteLine($"{Header}: {Body}");
            Console.WriteLine($"Mark: {Mark}");

            foreach (Answer answer in Answers)
            {
                Console.WriteLine(answer);
            }
        }

        public bool CheckAnswer(int answerId)
        {
            return RightAnswer != null &&
                   RightAnswer.AnswerId == answerId;
        }

        public int CompareTo(Question other)
        {
            if (other == null)
                return 1;

            return Mark.CompareTo(other.Mark);
        }

        public virtual object Clone()
        {
            Question copy = (Question)MemberwiseClone();

            copy.Answers = new Answer[Answers.Length];

            for (int i = 0; i < Answers.Length; i++)
            {
                copy.Answers[i] = (Answer)Answers[i].Clone();
            }

            Answer? foundAnswer = Array.Find( copy.Answers, a => a.AnswerId == RightAnswer.AnswerId);
            if (foundAnswer != null)
            {
                copy.RightAnswer = foundAnswer;
            }

            return copy;
        }

        public override string ToString()
        {
            return $"{Header}: {Body} (Mark: {Mark})";
        }
    }
}
