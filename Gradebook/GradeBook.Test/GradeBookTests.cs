using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradeBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gradebook;

namespace GradeBook.Test
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void addsItems()
        {
            int res = 1 + 2;
            Assert.AreEqual(res, 3);
        }
        [TestMethod]
        public void ComputesHighestGrade()
        {
            Grades book = new Grades();

            book.AddGrade(10);
            book.AddGrade(90);

            GradeStats result = book.ComputeGrades();

            Assert.AreEqual(90, result.HighestGrade);
        }

        public void ComputesLowestGrade()
        {
            Grades book = new Grades();

            book.AddGrade(10);
            book.AddGrade(90);

            GradeStats result = book.ComputeGrades();

            Assert.AreEqual(10, result.LowestGrade);
        }
        public void ComputesAverageGrade()
        {
            Grades book = new Grades();

            book.AddGrade(10);
            book.AddGrade(90);
            book.AddGrade(70.8f);

            GradeStats result = book.ComputeGrades();
            Assert.AreEqual(56.93, result.AverageGrade, 0.01);
        }
    }
}
