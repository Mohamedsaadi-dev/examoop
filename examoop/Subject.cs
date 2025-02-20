﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examoop
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public Exam SubjectExam { get; set; }


        public Subject(int _subjectId, string _subjectName)
        {
            SubjectId = _subjectId;
            SubjectName = _subjectName;
        }
        public void CreateExam()
        {

            int examType, examTime, numOfQuestions;
            do
            {
                Console.WriteLine(" Please Enter 1 To Create Practical \n  Please Enter Create 2 For Final ");
             
            } while (!int.TryParse(Console.ReadLine(), out examType) || examType < 1 || examType > 2);

            do
            {
                Console.WriteLine(" Please Enter Exam Time");
            } while (!int.TryParse(Console.ReadLine(), out examTime) || examTime < 30 || examTime > 180);


            do
            {
                Console.WriteLine(" Please Enter  Number Of Questions");
            } while (!int.TryParse(Console.ReadLine(), out numOfQuestions) || numOfQuestions < 1);

            if (examType == 1)
            {
                SubjectExam = new PracticalExam(examTime, numOfQuestions);
            }
            else SubjectExam = new FinalExam(examTime, numOfQuestions);
            Console.Clear();
            SubjectExam.CreateListOfQuestion();
        }
    }
}
