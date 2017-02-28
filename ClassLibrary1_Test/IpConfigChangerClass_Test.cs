using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace ClassLibrary1_Test
{
    [TestClass]
    public class IpConfigChangerClass_Test
    {
        [TestMethod]
        public void Test_changeSettingsMethod_ChangesIPv4Adress_WhenGivenANewIPv4Address()
        {
            //Arrange

            //Act

            //Assert

        }

        [TestMethod]
        public void Test_getIPMethod_GetsIpAddress_WhenEnvoked()
        {
            //Arrange
            IpConfigChangerClass IpConfigChangerObject = new IpConfigChangerClass();
            //Act

            //Assert

        }
    }
}
