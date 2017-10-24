using PostXML_AvisBudgetGroup.Model;
using PostXML_AvisBudgetGroup.Service.WebReferenceDirectConnect;
using System;

namespace PostXML_AvisBudgetGroup.Service.Method
{
    public class PingAbgService
    {
        public static RequestPing QueryRequestPingAbg(PingModel objectItem)
        {
            //RequestPing
            var requestPing = new RequestPing();

            //RequestPing - OTA_PingRQ
            var otaPingRq = new OTA_PingRQ();
            otaPingRq.EchoToken = Guid.NewGuid().ToString();
            otaPingRq.Version = objectItem.Version;


            //RequestPing - OTA_PingRQ - EchoData
            otaPingRq.EchoData = objectItem.Message;


            requestPing.OTA_PingRQ = otaPingRq;

            return requestPing;
        }
    }
}
