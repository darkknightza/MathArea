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
            Triangle triangle = new Triangle(4,5);
            //Act
            var result = triangle.GetArea();
            //Assert
            Assert.AreEqual(10,result);
        }

        [TestMethod]
        public void TriangleGetPerimetor_WidthThreeHeightFour_12()
        {
            //Arrange
            Triangle triangle = new Triangle(3, 4);
            //Act
            var result = triangle.GetPerimetor();
            //Assert
            Assert.AreEqual(12, Math.Round(result, 1));
        }

        [TestMethod]
        public void RectangleGetArea_WidthThreeHeightFour_12()
        {
            //Arrange
            ICalArea rectangle = new Rectangle(3,4);
            //Act
            var result = rectangle.GetArea();
            //Assert
            Assert.AreEqual(12, Math.Round(result, 1));
        }

        [TestMethod]
        public void RectangleGetPerimetor_WidthThreeHeightFour_14()
        {
            //Arrange
            ICalArea rectangle = new Rectangle(3, 4);
            //Act
            var result = rectangle.GetPerimetor();
            //Assert
            Assert.AreEqual(14, Math.Round(result, 1));
        }

        [TestMethod]
        public void SquareGetArea_WidthFour_12()
        {
            //Arrange
            ICalArea square = new Square(4);
            //Act
            var result = square.GetArea();
            //Assert
            Assert.AreEqual(16, Math.Round(result, 1));
        }

        [TestMethod]
        public void SquareGetPerimetor_WidthThree_12()
        {
            //Arrange
            ICalArea square = new Square(3);
            //Act
            var result = square.GetPerimetor();
            //Assert
            Assert.AreEqual(12, Math.Round(result, 1));
        }

        [TestMethod]
        public void EllipseGetArea_WidthThreeHeightFour_37()
        {
            //Arrange
            ICalArea ellipse = new Ellipse(3,4);
            //Act
            var result = ellipse.GetArea();
            //Assert
            Assert.AreEqual(37.7, Math.Round(result, 1));
        }

        [TestMethod]
        public void EllipseGetPerimetor_WidthThreeHeightFour_22()
        {
            //Arrange
            ICalArea ellipse = new Ellipse(3,4);
            //Act
            var result = ellipse.GetPerimetor();
            //Assert
            Assert.AreEqual(22, Math.Round(result, 1));
        }

        [TestMethod]
        public void CircleGetArea_RediusThree_28()
        {
            //Arrange
            ICalArea circle = new Circle(3);
            //Act
            var result = circle.GetArea();
            //Assert
            Assert.AreEqual(28.3, Math.Round(result, 1));
        }

        [TestMethod]
        public void CircleGetPerimetor_RediusThree_18()
        {
            //Arrange
            ICalArea circle = new Circle(3);
            //Act
            var result = circle.GetPerimetor();
            //Assert
            Assert.AreEqual(18.8, Math.Round(result, 1));
        }
    }
}
