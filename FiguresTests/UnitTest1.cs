using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;

namespace FiguresTests
{
    [TestClass]
    public class UnitTest1
    {
        double[,] coords = new double[3, 2] {
                { 0.5, 0.5 },
                { 1.3, 1.3 },
                { 1.3, 0.5 }
            };
        [TestMethod]
        public void TestArea()
        {
            double result = Math.Abs(0.5 * ((coords[0, 0] - coords[2, 0]) * (coords[1, 1] - coords[2, 1]) - (coords[1, 0] - coords[2, 0]) * (coords[0, 1] - coords[2,1])));
            var tr1 = new Figures.Treangle(coords[0, 0], coords[1, 0], coords[2, 0], coords[0, 1], coords[1, 1], coords[2, 1]);
            double resLib = tr1.GetSquare(); 
            Assert.AreEqual(resLib, result);
        }
        [TestMethod]
        public void TestRect()
        {
            double p1, p2, p3, d1, d2, d3;

            p1 = Math.Sqrt((coords[1,0] - coords[0, 0]) * (coords[1, 0] - coords[0, 0]) + (coords[1, 1] - coords[0, 1]) * (coords[1, 1] - coords[0, 1]));
            p2 = Math.Sqrt((coords[2, 0] - coords[0, 0]) * (coords[2, 0] - coords[0, 0]) + (coords[2, 1] - coords[0, 1]) * (coords[2, 1] - coords[0, 1]));
            p3 = Math.Sqrt((coords[2, 0] - coords[1, 0]) * (coords[2, 0] - coords[1, 0]) + (coords[2, 1] - coords[1, 1]) * (coords[2, 1] - coords[1, 1]));

            d1 = p1 * p1;
            d2 = p2 * p2;
            d3 = p3 * p3;

            bool res;

            if ((d1 - d2 + d3 < 0.0001) || (d2 - d1 + d3 < 0.0001) || (d3 - d1 + d2 < 0.0001))
                res = true;
            else
                res = false;

            var tr1 = new Figures.Treangle(coords[0, 0], coords[1, 0], coords[2, 0], coords[0, 1], coords[1, 1], coords[2, 1]);
            bool resLib = tr1.IsRect();

            Assert.AreEqual(resLib, res);

        }
        [TestMethod]
        public void TestCircleArea()
        {
            double result = Math.PI * 5 * 5;
            var c1 = new Figures.Circle(5);
            double resLib = c1.GetSquare();
            Assert.AreEqual(resLib, result);
        }
    }
}
