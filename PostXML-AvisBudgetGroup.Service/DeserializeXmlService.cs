using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PostXML_AvisBudgetGroup.Service
{
    public class DeserializeXmlService
    {
        public static object DeserializeXml(string xmlReturn, Object item)
        {
            var xmlReader = new XmlTextReader(new StringReader(xmlReturn));

            var xmlSerializer = new XmlSerializer(item.GetType());

            object deserializedObject = null;

            deserializedObject = xmlSerializer.Deserialize(xmlReader);

            return deserializedObject;
        }
    }
}
