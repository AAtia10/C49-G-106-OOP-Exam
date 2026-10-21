namespace oopExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "C# Programming");

            Console.WriteLine(subject);

            Console.WriteLine("\nChoose Exam Type:");
            Console.WriteLine("1. Final Exam");
            Console.WriteLine("2. Practical Exam");
            Console.Write("Your choice: ");

            int examType;

            while (!int.TryParse(Console.ReadLine(), out examType) ||
                   (examType != 1 && examType != 2))
            {
                Console.Write("Enter 1 or 2: ");
            }

            Answer[] trueFalseAnswers =
            {
            new Answer(1, "True"),
            new Answer(2, "False")
        };

            Answer[] mcqAnswers =
            {
            new Answer(1, "Class"),
            new Answer(2, "Object"),
            new Answer(3, "Method"),
            new Answer(4, "Variable")
        };

            Question[] questions;

            if (examType == 1)
            {
                questions = new Question[]
                {
                new TrueFalseQuestion(
                    "True or False",
                    "C# is an object-oriented language.",
                    2,
                    trueFalseAnswers,
                    trueFalseAnswers[0]
                ),

                new MCQQuestion(
                    "Choose One Answer",
                    "Which keyword is used to create a class?",
                    3,
                    mcqAnswers,
                    mcqAnswers[0]
                )
                };
            }
            else
            {
                questions = new Question[]
                {
                new MCQQuestion(
                    "Choose One Answer",
                    "Which keyword is used to create a class?",
                    5,
                    mcqAnswers,
                    mcqAnswers[0]
                )
                };
            }

            subject.CreateExam(examType, 30, questions);

            if (subject.Exam != null)
            {
                subject.Exam.ShowExam();
            }

            Question copiedQuestion = (Question)questions[0].Clone();

            Console.WriteLine("\nCloned Question:");
            Console.WriteLine(copiedQuestion);

            Array.Sort(questions);

            Console.WriteLine("\nQuestions sorted by Mark:");
            foreach (Question question in questions)
            {
                Console.WriteLine(question);
            }
        }
    }
    }

