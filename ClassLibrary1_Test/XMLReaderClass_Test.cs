using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary1_Test
{
    [TestClass]
    public class XMLReaderClass_Test
    {
        [TestMethod]
        public void Test_XMLReader_ReadsFromAnElement_WhenToldAnElementToRead()
        {
            //Arrange
            XMLReaderclass XObject = new XMLReaderclass();
            string elementString = new string();
            //Act
            elementString = XObject.Read("Element1");
            //Assert
            Assert.IsNotNull(string elementString);
        }
    }
}
