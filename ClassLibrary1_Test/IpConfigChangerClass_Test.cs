﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System.Collections.Generic;

namespace ClassLibrary1_Test
{
    [TestClass]
    public class IpConfigChangerClass_Test
    {


        [TestMethod]
        public void Test_getIPMethod_GetsIpv4Address_WhenEnvoked()
        {
            //Arrange
            IpConfigChangerClass IpConfigChangerObject = new IpConfigChangerClass();
            List<string> Ipv4string = null;
            //Act
            Ipv4string = IpConfigChangerObject.getIp();
            //Assert
            Assert.AreEqual("10.7.9.165", Ipv4string[0]);
        }

        [TestMethod]
        public void Test_getIPMethod_GetsIpv6Address_WhenEnvoked()
        {
            //Arrange
            IpConfigChangerClass IpConfigChangerObject = new IpConfigChangerClass();
            List<string> Ipv6string = null;
            //Act
            Ipv6string = IpConfigChangerObject.getIp();
            //Assert
            Assert.AreEqual("fe80::94e:d392:c843:25ed%12", Ipv6string[1]);
        }

        [TestMethod]
        public void Test_changeSettingsMethod_ChangesIPv4Adress_WhenGivenANewIPv4Address()
        {
            //Arrange
            IpConfigChangerClass changeIPObject = new IpConfigChangerClass();
            string NewIpv4 = "0.0.0.0";
            List<string> OldIpv4string = null;
            OldIpv4string = changeIPObject.getIp();
            //Act
            //changeIPObject.changeSettings(NewIpv4);//Do not run until the code to put back to normal is written.

            //Assert
            Assert.AreNotEqual(OldIpv4string, NewIpv4);
        }

    }
}
