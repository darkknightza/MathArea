using ClassMathArea;
using ConsoleApp1;
using ConsoleApp1.ClassArea;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestISBN
{
    [TestClass]
    public class ClassMathAreaTest
    {
        [TestMethod]
        public void TriangleGetArea_WidthFourHeightFive_TEN()
        {
            //Arrange
            int width = 4;
            int height = 5;
            Triangle triangle = new Triangle(width, height);
            //Act
            var result = triangle.GetArea();
            //Assert
            int resultArea = 10;
            Assert.AreEqual(resultArea, result);
        }

        [TestMethod]
        public void TriangleGetPerimetor_WidthThreeHeightFour_12()
        {
            //Arrange
            int width = 3;
            int height = 4;
            Triangle triangle = new Triangle(width, height);
            //Act
            var result = triangle.GetPerimetor();
            //Assert
            int resultPerimetor = 12;
            Assert.AreEqual(resultPerimetor, Math.Round(result, 1));
        }

        [TestMethod]
        public void RectangleGetArea_WidthThreeHeightFour_12()
        {
            //Arrange
            int width = 3;
            int height = 4;
            ICalArea rectangle = new Rectangle(width, height);
            //Act
            var result = rectangle.GetArea();
            //Assert
            int resultArea = 12;
            Assert.AreEqual(resultArea, Math.Round(result, 1));
        }

        [TestMethod]
        public void RectangleGetPerimetor_WidthThreeHeightFour_14()
        {
            //Arrange
            int width = 3;
            int height = 4;
            ICalArea rectangle = new Rectangle(width, height);
            //Act
            var result = rectangle.GetPerimetor();
            //Assert
            int resultPerimetor = 14;
            Assert.AreEqual(resultPerimetor, Math.Round(result, 1));
        }

        [TestMethod]
        public void SquareGetArea_WidthFour_16()
        {
            //Arrange
            int width = 4;
            ICalArea square = new Square(width);
            //Act
            var result = square.GetArea();
            //Assert
            int resultArea = 16;
            Assert.AreEqual(resultArea, Math.Round(result, 1));
        }

        [TestMethod]
        public void SquareGetPerimetor_WidthThree_12()
        {
            //Arrange
            int width = 3;
            ICalArea square = new Square(width);
            //Act
            var result = square.GetPerimetor();
            //Assert
            int resultPerimetor = 12;
            Assert.AreEqual(resultPerimetor, Math.Round(result, 1));
        }

        [TestMethod]
        public void EllipseGetArea_WidthThreeHeightFour_37()
        {
            //Arrange
            int width = 3;
            int height = 4;
            ICalArea ellipse = new Ellipse(width, height);
            //Act
            var result = ellipse.GetArea();
            //Assert
            double resultArea = 37.7;
            Assert.AreEqual(resultArea, Math.Round(result, 1));
        }

        [TestMethod]
        public void EllipseGetPerimetor_WidthThreeHeightFour_22()
        {
            //Arrange
            int width = 3;
            int height = 4;
            ICalArea ellipse = new Ellipse(width, height);
            //Act
            var result = ellipse.GetPerimetor();
            //Assert
            int resultPerimetor = 22;
            Assert.AreEqual(resultPerimetor, Math.Round(result, 1));
        }

        [TestMethod]
        public void CircleGetArea_RediusThree_28()
        {
            //Arrange
            int redius = 3;
            ICalArea circle = new Circle(redius);
            //Act
            var result = circle.GetArea();
            //Assert
            double resultArea = 28.3;
            Assert.AreEqual(resultArea, Math.Round(result, 1));
        }

        [TestMethod]
        public void CircleGetPerimetor_RediusThree_18()
        {
            //Arrange
            int redius = 3;
            ICalArea circle = new Circle(redius);
            //Act
            var result = circle.GetPerimetor();
            //Assert
            double resultPerimetor = 18.8;
            Assert.AreEqual(resultPerimetor, Math.Round(result, 1));
        }
    }
}
