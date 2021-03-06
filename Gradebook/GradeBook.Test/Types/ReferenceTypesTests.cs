﻿using System;
using Gradebook;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GradeBook.Test.Types
{

    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void MyTestMethod()
        {
            string name = "bobby";
            name = name.ToUpper();

            Assert.AreEqual(name, "BOBBY");
        }
        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2019, 1, 1);
            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            int y = Increment(x);

            Assert.AreEqual(x, 46);
            Assert.AreEqual(y, 47);
        }
        private int Increment(int number)
        {
            return number += 1;
        }
        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            Grades book1 = new Grades();
            Grades book2 = book1;

            GiveBookAName(ref book2);
            Assert.AreEqual("A Gradebook", book2.Name);
        }

        private void GiveBookAName(ref Grades book)
        {
            book = new Grades();
            book.Name = "A Gradebook";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Bobby";
            string name2 = "bobby";
            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;
            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradesVariablesHoldAReference()
        {
            Grades g1 = new Grades();
            Grades g2 = g1;

            g1 = new Grades();
            g1.Name = "Bobbys gradebook";
            Assert.AreNotEqual(g1.Name, g2.Name);
        }
    }
}
