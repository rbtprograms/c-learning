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
            Grades book = new Grades();

            book.NameChanged += OnNameChanged;
            ////the following two lines work the same
            //book.NameChanged += OnNameChanged2;
            //book.NameChanged += new NameChangedDelegate(OnNameChanged2); 

            book.Name = "Bobby's Grade Book";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStats stats = book.ComputeGrades();

            Console.WriteLine(book.Name);
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Grades book2 = book;
            book2.AddGrade(75);
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changed from {args.ExistingName} to {args.NewName}.");
        }

    }
}
