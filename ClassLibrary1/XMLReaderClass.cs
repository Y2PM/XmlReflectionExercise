using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClassLibrary1
{
    public class XMLReaderClass
    {
        public string Read(string InputString)
        {

            XmlTextReader reader = new XmlTextReader(InputString);
            string OutputString = reader.ReadElementString();

            return OutputString;
        }
    }
}
