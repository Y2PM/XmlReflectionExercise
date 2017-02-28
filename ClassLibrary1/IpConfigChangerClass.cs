using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class IpConfigChangerClass
    {
        public void changeSettings(string NewIpAddress)
        {
            ManagementClass ManagementClassObject = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection ManagementObjectCollectionObject = ManagementClassObject.GetInstances();

            foreach (ManagementObject item in ManagementObjectCollectionObject)
            {

            }

        }

        public string Ipv6 { get; set; }
        public string Ipv4 { get; set; }

        public void getIp()
        {

            //string Ipv6 = null;
            //string Ipv4 = null;

            Ipv6 = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString();
            Ipv4 = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString();

        }
    }
}
