using System.Diagnostics;

namespace examoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject s = new Subject(1, "oop");

            s.CreateExam();
            char c;
            do
            {
                Console.WriteLine("Do You Want To Start The Exam (Y | N)");
            } while (!char.TryParse(Console.ReadLine(), out c));

            if (c == 'y' || c == 'Y')
            {
                Console.Clear();
                Stopwatch sw = new Stopwatch();
                sw.Start();
                s.SubjectExam.ShowExam();
                Console.WriteLine(sw.Elapsed);
            }
            else
            {
                Console.WriteLine("End Exam");
            }
        }
    }
}
