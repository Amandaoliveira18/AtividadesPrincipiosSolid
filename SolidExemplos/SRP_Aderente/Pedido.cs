using System;
using System.Collections.Generic;
using System.Text;

namespace SRP_Aderente
{
    class Pedido
    {
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }
        private ILogger infoLogger; //instancia da interface logger
        private EnviarEmail enviaEmail; //instancia da classe enviaEmail
        public Pedido()
        {
            infoLogger = new RegistraLog();
            enviaEmail = new EnviarEmail();
        }
        public void IncluirPedido()
        {
            try
            {
                infoLogger.Info("Incluindo um pedido");
                enviaEmail.EMailFrom = "emailfrom@xyz.com";
                enviaEmail.EMailTo = "emailto@xyz.com";
                enviaEmail.EMailSubject = "SRP";
                enviaEmail.EMailBody = "Um";
                enviaEmail.Enviar();
            }
            catch (Exception ex)
            {
                infoLogger.Info("Erro ao enviar email:" + ex.Message);
            }
        }
        public void DeletaPedido()
        {
            try
            {
                infoLogger.Info("Pedido deletado em" + DateTime.Now);
            }
            catch (Exception ex)
            {
                infoLogger.Info("Error ao deleter pedido" + ex.Message);
            }
        }
    }
}
