using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    public class Grades
    {

        public Grades()
        {
            grades = new List<float>();
        }

        private List<float> grades;

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStats ComputeGrades()
        {
            GradeStats stats = new GradeStats();

            float sum = 0;
            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(stats.HighestGrade, grade);
                stats.LowestGrade = Math.Min(stats.LowestGrade, grade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void ResetGrades()
        {
            grades.Clear();
        }

    }
}
