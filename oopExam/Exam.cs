using System;
using System.Collections.Generic;
using System.Text;

namespace oopExam
{
    internal abstract class Exam
    {
        public int TimeInMinutes { get; set; }

        public Question[] Questions { get; set; }

        public int NumberOfQuestions
        {
            get { return Questions.Length; }
        }

        public Exam(int timeInMinutes, Question[] questions)
        {
            TimeInMinutes = timeInMinutes;
            Questions = questions;
        }

        public abstract void ShowExam();
    }

}

