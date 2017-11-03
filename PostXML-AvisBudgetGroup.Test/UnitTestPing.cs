using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostXML_AvisBudgetGroup.Model;
using PostXML_AvisBudgetGroup.Service;
using PostXML_AvisBudgetGroup_WCF.WebReferenceABG;
using System;

namespace PostXML_AvisBudgetGroup.Test
{
    [TestClass]
    public class UnitTestPing
    {
        [TestMethod]
        public void TestMethodPingRequest()
        {
            #region OBJETO
            var pingRequest = new PingModel
            {
                Message = "Mensagem de Teste - Ambiente de Producao",
                Version = "1.0",
                Vendor = "Avis",
                UserId = "***", //INSERIR USUARIO AO WEB SERVICE
                Password = "***", //INSERIR SENHA AO WEB SERVICE
                Url = "https://qaservices.carrental.com/wsbang/HTTPSOAPRouter/ws9071",
                EchoToken = Guid.NewGuid().ToString()
            };

            #endregion
            var rQRSServices = new RQRSServices();
            var resultDeserialize = (Service.WebReferenceDirectConnect.OTA_PingRS)rQRSServices.SendPing(pingRequest);
            Assert.IsNotNull(resultDeserialize.EchoToken);

        }
    }
}
