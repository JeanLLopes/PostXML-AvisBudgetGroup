using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostXML_AvisBudgetGroup.Service
{
    public class ResponseTreatmentService
    {
        public static string ResponseTreatment(string responseSoap, string loadType)
        {
            if (!string.IsNullOrEmpty(responseSoap))
            {
                string payloadXML;

                int indiceInicioPayload = responseSoap.IndexOf(string.Format("<{0}", loadType), StringComparison.Ordinal);

                payloadXML = responseSoap.Substring(indiceInicioPayload);

                int qtdCharsPayloadType = loadType.Length;

                int indiceFimPayload = payloadXML.IndexOf(string.Format("</{0}>", loadType), StringComparison.Ordinal);

                payloadXML = payloadXML.Remove(indiceFimPayload + 3 + qtdCharsPayloadType);

                return payloadXML;

            }

            return string.Empty;
        }
    }
}
