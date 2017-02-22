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
            List<string> strlist = new List<string> { };
            //Act
            strlist = XObject.Read("C:\\Users\\joseph.bannert\\Desktop\\XmlReflectionExercise\\employee.xml");
            //Assert
            Assert.IsNotNull(strlist[0]);
        }
    }
}
