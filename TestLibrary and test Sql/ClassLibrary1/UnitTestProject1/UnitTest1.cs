using FigursLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Тесты для треугольнка
        [TestMethod]
        public void CircleTestS()
        {
            int r = 4;
            double expected = 50.27;
            double actual = 0;
            actual = Circles.Circle(r);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CircleTestS2()
        {
            int r = 5;
            double expected = 78.54;
            double actual = 0;
            actual = Circles.Circle(r);
            Assert.AreEqual(expected, actual);
        }
        //тесты площади
        [TestMethod]
        public void TriangleTestS()
        {
            int a = 3;
            double expected = 3.90;
            double actual = 0;
            actual = Triangles.TriangleS(a,a,a);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TriangleTestS2()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            double expected = 6.00;
            double actual = 0;
            actual = Triangles.TriangleS(a,b,c);
            Assert.AreEqual(expected, actual);
        }
        //тесты площади для вырожденого и не существующих треугольников
        [TestMethod]
        public void TriangleTestS2Degeneration()
        {
            int a = 3;
            int b = 1;
            int c = 4;
            double expected = 0;
            double actual = 0;
            actual = Triangles.TriangleS(a,b,c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TriangleTestS2Existence()
        {
            int a = 0;
            int b = 3;
            int c = 4;
            double expected = 0;
            double actual = 0;
            actual = Triangles.TriangleS(a,b,c);
            Assert.AreEqual(expected, actual);
        }
        // тесты на виды треугольник
        [TestMethod]
        public void TriangleType1()
        {
            int a = 3;
            int b = 3;
            int c = 2;
            string expected = "Равнобедренный";
            string actual = Triangles.TriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TriangleType2()
        {
            int a = 3;
            int b = 3;
            int c = 3;
            string expected = "Равносторонний";
            string actual = Triangles.TriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TriangleType3()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            string expected = "Разносторонний";
            string actual = Triangles.TriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TriangleTypeDegeneration()
        {
            int a = 3;
            int b = 4;
            int c = 7;
            string expected = "треугольник вырожденый";
            string actual = Triangles.TriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TriangleTypeSideNull()
        {
            int a = 3;
            int b = 4;
            int c = 0;
            string expected = "Сторона 0";
            string actual = Triangles.TriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
    }
}
