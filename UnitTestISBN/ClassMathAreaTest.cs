using ClassMathArea;
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
        public void GetArea_WidthFourHeightFive_TEN()
        {   
            //Arrange
            Triangle triangle = new Triangle(4,5);
            //Act
            var result = triangle.GetArea();
            //Assert
            Assert.AreEqual(10,result);
        }
    }
}
