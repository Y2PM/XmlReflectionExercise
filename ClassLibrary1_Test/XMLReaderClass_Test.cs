using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace ClassLibrary1_Test
{
    [TestClass]
    public class XMLReaderClass_Test
    {
        [TestMethod]
        public void Test_XMLReader_ReadsFromAnElement_WhenToldAnElementToRead()
        {
            //Arrange
            XMLReaderClass XObject = new XMLReaderClass();
            string elementString;
            //Act
            elementString = XObject.Read("Element1");
            //Assert
            Assert.IsNotNull(elementString);
        }
    }
}
