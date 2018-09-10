using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace ExerciseUnitTests
{
    [TestClass]
    public class QuadraticEquationTest
    {
        QuadraticEquation qe;
        [TestInitialize()]
        public void Initialise()
        {
            qe = new QuadraticEquation();
        }
        [TestMethod]
        public void TestDiscriminant()
        {
            qe.A = 1;
            qe.B = 2;
            qe.C = 3;
            qe = new QuadraticEquation();
            double actualDiscriminant = qe.GetDiscriminant();
            double expectedDiscriminant = Math.Pow(qe.B, 2) - 4 * qe.A * qe.C;

            Assert.AreEqual(expectedDiscriminant, actualDiscriminant, 0.000001, " The expected discriminant did not match");
        }
        [TestMethod]
        public void TestFirstRealRoot()
        {
            //a=1, b=3, c=1
            qe.A = 1;
            qe.B = 3;
            qe.C = 1;

            double actualRootOne = qe.GetRoot1();
            double expectedRootOne = (-qe.B + Math.Pow((qe.B * qe.B - 4 * qe.A * qe.A),0.5))/ 2 * qe.A;

            Assert.AreEqual(expectedRootOne, actualRootOne, 0.000001, "The expected first real root did not match.");
        }
        [TestMethod]
        public void TestSecondRealRoot()
        {
            //a=1, b=3, c=1
            qe.A = 1;
            qe.B = 3;
            qe.C = 1;

            double actualRootTwo = qe.GetRoot2();
            double expectedRootTwo = (-qe.B - Math.Pow((qe.B * qe.B - 4 * qe.A * qe.A), 0.5)) / 2 * qe.A;


            Assert.AreEqual(expectedRootTwo, actualRootTwo, 0.000001, "The expected second real root did not match.");
        }
        [TestMethod]
        public void TestOneRealRoot()
        {
            //a=1, b=2, c=1
        }
        
    }
}
