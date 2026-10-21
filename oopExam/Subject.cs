using System;
using System.Collections.Generic;
using System.Text;

namespace oopExam
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public Exam Exam { get; private set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam(int examType, int timeInMinutes,
                               Question[] questions)
        {
            switch (examType)
            {
                case 1:
                    Exam = new FinalExam(timeInMinutes, questions);
                    break;

                case 2:
                    Exam = new PracticalExam(timeInMinutes, questions);
                    break;

                default:
                    Console.WriteLine("Invalid exam type.");
                    Exam = null;
                    break;
            }
        }

        public override string ToString()
        {
            return $"Subject ID: {SubjectId}, Subject Name: {SubjectName}";
        }
    }
}
