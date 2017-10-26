using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostXML_AvisBudgetGroup.Model;
using PostXML_AvisBudgetGroup.Service;
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
                Message = "Mensagem de Teste - Ambiente de Produção",
                Version = "1.0",
                Vendor = "Avis",
                UserId = "usuario", //INSERIR USUARIO AO WEB SERVICE
                Password = "senha", //INSERIR SENHA AO WEB SERVICE
                Url = "https://qaservices.carrental.com/wsbang/HTTPSOAPRouter/ws9071",
                EchoToken = Guid.NewGuid().ToString()
            };

            #endregion
            var rQRSServices = new RQRSServices();
            Assert.IsNotNull(rQRSServices.SendPing(pingRequest));

        }
    }
}
