using System;
using System.Speech;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {

            Grades g1 = new Grades();
            Grades g2 = g1;

            g1 = new Grades();
            g1.Name = "Bobbys gradebook";
            Console.WriteLine(g2.Name);

            /*
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello and welcome to the grade book program.");

            Grades book = new Grades();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStats stats = book.ComputeGrades();

            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Grades book2 = book;
            book2.AddGrade(75);
            */
        }
    }
}
