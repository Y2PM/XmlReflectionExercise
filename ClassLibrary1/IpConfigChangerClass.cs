using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
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
    }
}
