using System;
using System.Collections.Generic;

namespace ServicoConfirmaRecargaSpTrans.Retorno
{
    public class DefaultRetorno
    {
        public string Mensagem { get; set; }
        public string MensagemLog { get; set; }
        public string MensagemStatus { get; set; }
        public int Status { get; set; }
        public List<object> ListaObjeto { get; set; } = new List<object>();
    }
    public class DefaultRetornoSptrans
    {
        public int codigoRetorno { get; set; }
        public bool codigoRetornoSpecified { get; set; }
        public object mensagem { get; set; }
    }
    public class ConfirmacaoRetorno
    {
        public long NumeroPedidoEMPRESA3 { get; set; }
        public long NumeroPedidoSpTrans { get; set; }
        public decimal Valor { get; set; }
        public string NumeroCartao { get; set; }
        public string Status { get; set; }
        public bool SaldoAtualizado { get; set; }
    }

}