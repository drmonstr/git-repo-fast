using System;
using ConsoleApp2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaTriangleMethodTest
{
    [TestClass]
    public class AreaRightTriangleTest
    {
        private double a = 7;
        private double b = 5;
        private double c = 8.6023252670426267;

        [TestMethod]
        public void IsTrueHypotenuse()
        {
            double hypotenuse = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Assert.AreEqual(hypotenuse, c);
        }

        [TestMethod]
        public void IsNegativeSideA()
        {
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Assert.AreNotEqual(-2, Program.GetAreaTriangle(a,b,c));
        }

        [TestMethod]
        public void IsNegativeSideB()
        {
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Assert.AreNotEqual(-3, Program.GetAreaTriangle(a, b, c));
        }
    }
}