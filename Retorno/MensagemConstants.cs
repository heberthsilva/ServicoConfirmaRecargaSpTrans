using System;
using System.Collections.Generic;

namespace ServicoConfirmaRecargaSpTrans.Retorno
{
    public class MensagemConstants
    {
        public static string MensagemSucesso = "Sucesso.";

        public static string PedidoNotFound = "Não Existe pedido com o número fornecido.";
        public static string NotConfirm = "Não é possível confirmar o pedido com o número informado.";
        public static string Confirmated = "O pedido informado já foi confirmado.";
        public static string ErroCotaEstudante = "Ocorreu um problema no momento da baixa da cota do estudante e devido a isso não foi possível confirmar o pedido.";
        public static string SemCotaEstudante = "O estudante não possui cota disponível para o mês atual."; 
        public static string ValorSuperior = "O valor pretendido para compra pelo estudante é superior ao valor que o mesmo possui disponível."; 
        public static string EstudantePeriodoLetivo = "O usuário ainda não adquiriu o benefício de estudante para compra de créditos no período letivo corrente"; 
        public static string ErroInformacoes = "Não foi possível efetuar a confirmação do pedido devido a\r\ninconsistências nas informações do mesmo.";
        public static string ErroConfirmacao = "Não foi possível efetuar a confirmação do pedido devido a\r\ninconsistências nas informações do mesmo.";


    }
}