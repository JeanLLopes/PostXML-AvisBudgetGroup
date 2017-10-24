using System;
using System.IO;
using System.Net;
using System.Text;

namespace PostXML_AvisBudgetGroup.Service
{
    public class PostXmlAbgService
    {
        public static string PostXml(string url, string postData)
        {
            var req = WebRequest.Create(url);

            req.ContentType = "text/xml";
            req.Method = "POST";

            byte[] bytes = Encoding.ASCII.GetBytes(postData);
            req.ContentLength = bytes.Length;

            using (Stream os = req.GetRequestStream())
            {
                os.Write(bytes, 0, bytes.Length);
            }

            using (WebResponse resp = req.GetResponse())
            {
                using (var sr = new StreamReader(resp.GetResponseStream()))
                {
                    return sr.ReadToEnd().Trim();
                }
            }
        }


        public static string InvokeSoapEnvelopment(String xml, String usuario, String senha)
        {
            //REMOVE A CODIFICACAO
            xml = xml.Replace("<?xml version=\"1.0\" encoding=\"utf-8\"?>", "");


            return String.Format(
                    "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">" +
                    "<Header>" +
                    "<h:credentials xmlns=\"http://wsg.avis.com/wsbang/authInAny\" xmlns:h=\"http://wsg.avis.com/wsbang/authInAny\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">" +
                    "<userID>{0}</userID>" +
                    "<password>{1}</password>" +
                    "</h:credentials>" +
                    "</Header>" +
                    "<Body>{2}</Body>" +
                    "</s:Envelope>", usuario, senha, xml);
        }
    }
}
