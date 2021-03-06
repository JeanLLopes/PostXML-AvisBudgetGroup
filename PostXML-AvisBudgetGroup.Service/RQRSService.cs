﻿using PostXML_AvisBudgetGroup.Model;
using PostXML_AvisBudgetGroup.Service.Method;
using PostXML_AvisBudgetGroup.Service.WebReferenceDirectConnect;

namespace PostXML_AvisBudgetGroup.Service
{

    public class RQRSServices
    {
        public object SendPing(PingModel dataRequest)
        {
            var classRequest = PingAbgService.QueryRequestPingAbg(dataRequest);
            var xmlRequest = SerializeXmlService.SerializeXml(classRequest);
            var soapXmlRequest = PostXmlAbgService.InvokeSoapEnvelopment(xmlRequest, dataRequest.UserId, dataRequest.Password);
            var responseXmlPing = PostXmlAbgService.PostXml(dataRequest.Url, soapXmlRequest);
            var xmlResponseTreatment = ResponseTreatmentService.ResponseTreatment(responseXmlPing, "OTA_PingRS");
            return DeserializeXmlService.DeserializeXml(xmlResponseTreatment, new OTA_PingRS());
        }
    }
}
