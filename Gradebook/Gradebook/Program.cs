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
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello and welcome to the grade book program.");

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStats stats = book.ComputeGrades();

            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            GradeBook book2 = book;
            book2.AddGrade(75);
        }
    }
}
