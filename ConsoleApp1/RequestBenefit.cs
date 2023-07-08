using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    [Serializable]
    public class RequestBenefit
    {
        public string OwnerLastName { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerMiddleName { get; set; }
        [XmlElement(DataType = "date")]
        public DateTime OwnerBirthDate { get; set; }

        public static RequestBenefit LoadFromXml(string file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(RequestBenefit));
            using (FileStream reader = new FileStream(file, FileMode.Open))
            {
                return serializer.Deserialize(reader) as RequestBenefit;
            }
        }

        public void SaveToXml(string file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(RequestBenefit));
            using (FileStream writer = new FileStream(file, FileMode.OpenOrCreate))
            {
                serializer.Serialize(writer, this);
            }
        }
    }
}
