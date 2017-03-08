using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System.Collections.Generic;

namespace ClassLibrary1_Test
{
    [TestClass]
    public class XMLReaderClass_Test
    {
        [TestMethod]
        public void Test_Read_ReadsFromXmlFile_WhenGivenAFileName()
        {
            //Arrange
            XMLReaderClass XObject = new XMLReaderClass();
            List<string> strlist = null;
            //Act
            strlist = XObject.Read("C:\\Users\\joseph.bannert\\Desktop\\XmlReflectionExercise\\employee.xml", null);
            //Assert
            Assert.IsNotNull(strlist[0]);
        }

        [TestMethod]
        public void Test_Read_ReadsElement_WhenToldWhichOneToRead()
        {
            //Arrange
            XMLReaderClass XObject = new XMLReaderClass();
            List<string> strlist = new List<string> { };
            //Act
            strlist = XObject.Read("C:\\Users\\joseph.bannert\\Desktop\\XmlReflectionExercise\\employee.xml", "hire-date");
            //Assert
            Assert.AreEqual("1900-01-01", strlist[0]);
        }
    }
}
