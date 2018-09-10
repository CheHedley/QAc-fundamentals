using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOThinkingTutorial;

namespace ExerciseUnitTests
{
    [TestClass]
    public class TriangleTest
    {
        Polygon triangle;
 
        [TestMethod]
        public void TestArea()
        {
            double actualArea = triangle.Area();
            Assert.AreEqual(6, actualArea, 0.0001, "The areas do not match");
        }

        [TestMethod]
        [ExpectedException(typeof(TriangleException))]
        public void TestInvalidGeometry()
        {
            triangle = new Triangle(3, 51, 4, 3);
            double actualArea = triangle.Area();
        }
    }
}
