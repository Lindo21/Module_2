using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleUtilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUtilities.Tests
{
    [TestClass()]
    public class UtilitiesTests
    {
        [TestMethod()]
        public void writelineTest()
        {
            //Arrange
            Utilities utilities = new Utilities();
            string stringInputText = "Hello world";
            //Act
            string output = utilities.writeline(stringInputText);
            //Assert
            Assert.AreEqual(stringInputText, output);



        }
    }
}