using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class GradeBook
    {

        public GradeBook()
        {
            grades = new List<float>();
        }

        private List<float> grades;

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public void ComputerStats()
        {

        }

        public void ResetGrades()
        {
            grades.Clear();
        }

    }
}
