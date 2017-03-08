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
                if ((bool)item["IPEnabled"])
                {
                    //try
                    //{
                        ManagementBaseObject setIP;
                        ManagementBaseObject newIP = item.GetMethodParameters("EnableStatic");

                        newIP["IPAddress"] = new string[] { NewIpAddress };
                        //newIP["SubnetMask"] = new string[] { subnet_mask };

                        setIP = item.InvokeMethod("EnableStatic", newIP, null);
                    //}
                    //catch (Exception)
                    //{
                    //    throw;
                    //}
                }
            }
        }



        public List<string> getIp()
        {
            string Ipv6 = null;
            string Ipv4 = null;

            Ipv6 = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString();
            Ipv4 = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString();

            List<string> IpList = new List<string>();
            IpList.Add(Ipv4);
            IpList.Add(Ipv6);

            return IpList;
        }
    }
}
