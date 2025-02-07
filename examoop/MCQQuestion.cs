using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examoop
{
    public class MCQQuestion :Question
    {
        public override string Header => "MCQ Question";
        public MCQQuestion()
        {
            AnswerList = new Answer[3];
        }
        public override void AddQuestions()
        {
            Console.WriteLine(Header);
            Console.WriteLine("Enter The Body Of Question");
            Body = Console.ReadLine();
            int mark;
            do
            {
                Console.WriteLine("Enter The Mark Of Question");
            } while (!int.TryParse(Console.ReadLine(), out mark) || mark < 1);
            Marks = mark;
            Console.WriteLine("Enter The Answers Of Question");

            for (int i = 0; i < 3; i++)
            {
                AnswerList[i] = new Answer
                {
                    AnswerId = i + 1
                };
                Console.WriteLine($"Enter The Answer Number {i + 1} Text");
                AnswerList[i].AnswerText = Console.ReadLine();
            }
            int rightAnswerId;
            do
            {
                Console.WriteLine("Enter The Id Of Right Answer");
            } while (!int.TryParse(Console.ReadLine(), out rightAnswerId) || rightAnswerId < 1 || rightAnswerId > 3);
            RightAnswer.AnswerId = rightAnswerId;
            RightAnswer.AnswerText = AnswerList[rightAnswerId - 1].AnswerText;
            Console.Clear();
        }
    }
}
