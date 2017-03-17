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
            string subnet_mask = "0.0.0.0";

            foreach (ManagementObject item in ManagementObjectCollectionObject)
            {
                if ((bool)item["IPEnabled"])
                {
                    Console.WriteLine("IPEnabled item found");

                    try
                    {
                        ManagementBaseObject setIP;
                        ManagementBaseObject newIP = item.GetMethodParameters("EnableStatic");

                        newIP["IPAddress"] = new string[] { NewIpAddress };
                        newIP["SubnetMask"] = new string[] { subnet_mask };

                        setIP = item.InvokeMethod("EnableStatic", newIP, null);
                    }
                    #region return value feedback attempt
                    //if (setIP.Equals(1) || setIP.Equals(0))//Trying to get the return value to judge whether this has worked or not. [https://msdn.microsoft.com/en-us/library/aa390383(v=vs.85).aspx]
                    //{
                    //    Console.WriteLine("InvokeMethod Succsess");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("InvokeMethod Failure" + setIP);
                    //}
                    //} 
                    #endregion
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }



        public List<string> getIp()
        {
            string Ipv6 = null;
            string Ipv4 = null;

            Ipv6 = Dns.GetHostEntry(Dns.GetHostName()).AddressList[3].ToString();
            Ipv4 = Dns.GetHostEntry(Dns.GetHostName()).AddressList[2].ToString();

            List<string> IpList = new List<string>();
            IpList.Add(Ipv4);
            IpList.Add(Ipv6);

            return IpList;
        }
    }
}
