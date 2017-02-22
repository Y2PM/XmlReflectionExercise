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
        public List<string> Read(string FileName)
        {
            XmlTextReader reader = new XmlTextReader(FileName);
            List<string> strlist = new List<string> { };
           
            while (reader.Read())
            {
                strlist.Add(reader.ReadString());
            }
            return strlist;
        }
    }
}
