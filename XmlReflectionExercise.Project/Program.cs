using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace XmlReflectionExercise.Project
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Arrange
            XMLReaderClass XObject = new XMLReaderClass();
            //Act
            var xmlcont = XObject.Read("C:\\Users\\joseph.bannert\\Desktop\\XmlReflectionExercise\\employee.xml", "hire-date");
            foreach (var item in xmlcont)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
            */

            /*
            foreach (var item in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
            */

            /*
            //Write to a text file:
            string[] text = { "Ipv6: " + Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString(), "Ipv4: " + Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString() };

            //string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string mydocpath = Directory.GetCurrentDirectory();

            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\Ipv_4&6.txt"))
            {
                foreach (string line in text)
                    outputFile.WriteLine(line);
            }
            */

            
            //Arrange
            IpConfigChangerClass changeIPObject = new IpConfigChangerClass();
            string NewIpv4 = "0.0.0.0";
            //Act
            changeIPObject.changeSettings(NewIpv4);//Do not run until the code to put back to normal code is written.

            //Arrange
            IpConfigChangerClass IpConfigChangerObject = new IpConfigChangerClass();
            List<string> Ipv4string = null;
            //Act
            Ipv4string = IpConfigChangerObject.getIp();
            //Assert
            //

            Console.WriteLine("current IP is: " + Ipv4string[0] + ", which should be: " + NewIpv4);
            Console.ReadLine();
            

            /*
            IpConfigChangerClass IpConfigChangerObject = new IpConfigChangerClass();
            System.Net.IPAddress[] Ipv6 = null;
            Ipv6 = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            //Assert
            //VB:
            //10.0.2.15
            //FDM:
            //10.7.9.165
            foreach (var item in Ipv6)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            */
        }
    }
}
