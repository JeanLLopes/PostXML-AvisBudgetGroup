using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace PostXML_AvisBudgetGroup.Service
{
    public class SerializeXmlService
    {
        public static string SerializeXml(Object item)
        {
            var xmlSerializer = new XmlSerializer(item.GetType());

            var xmlSettings = new XmlWriterSettings();
            xmlSettings.Indent = true;

            var memoryStream = new MemoryStream();
            var streamWriter = new StreamWriter(memoryStream);

            var xmlWriter = XmlWriter.Create(streamWriter, xmlSettings);

            xmlSerializer.Serialize(xmlWriter, item);
            xmlWriter.Flush();
            xmlWriter.Close();

            var streamReader = new StreamReader(memoryStream);

            memoryStream.Position = 0;

            var serializedObj = streamReader.ReadToEnd();

            streamReader.Close();

            return serializedObj;
        }
    }
}
