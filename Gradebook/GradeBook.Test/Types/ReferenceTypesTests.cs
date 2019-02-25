using System;
using Gradebook;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GradeBook.Test.Types
{

    [TestClass]
    public class ReferenceTypesTests
    {
        [TestMethod]
        public void VariablesHoldAReference()
        {
            Grades g1 = new Grades();
            Grades g2 = g1;

            g1.Name = "Bobbys gradebook";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
