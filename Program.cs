using Newtonsoft.Json;
using ServicoConfirmaRecargaSpTrans.BD;
using ServicoConfirmaRecargaSpTrans.Retorno;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Web.Mvc;

namespace ServicoConfirmaRecargaSpTrans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;

            if (date.Hour < 23)
            {
                VerificaPedidosRecargaPagos();
            }
        }
        [HttpPost]
        [Route("VerificaPedidosRecargaPagos")]
        public static DefaultRetorno VerificaPedidosRecargaPagos()
        {
            var result = new DefaultRetorno();

            using (var db = new BD_EMPRESA3_Entities())
            {
                //Busca todos os itens com Status de Pago
                var pedidosItens = db.tb_pedido_item.Where(x => x.tb_pedido.cd_status_pedido == 2
                                                      && x.cd_status_pedido_item == 1 && (x.tp_pedido_item == 1 || x.tp_pedido_item == 2)
                                                      && (x.ds_pedido_operadora != null || x.ds_pedido_operadora != "")
                                                      && (
                                                      (x.cd_operadora == 74 && db.tb_parametro.FirstOrDefault().ic_ambiente_producao == false) ||
                                                      (x.cd_operadora == 77 && db.tb_parametro.FirstOrDefault().ic_ambiente_producao == true)
                                                      )
                                                      && x.dt_pre_pedido_operadora != null
                                                      && x.tb_pedido.ic_transacao_analise_risco == false).OrderBy(y => y.cd_pedido_item).Take(30).ToList();

                foreach (var itemPedido in pedidosItens)
                {

                    try
                    {
                        var codPedido = int.Parse(itemPedido.ds_pedido_operadora);
                        var confirmaPedido = ConfirmarPedido(codPedido);
                        ConfirmacaoRetorno status = new ConfirmacaoRetorno();
                        var usuario_cartao = db.tb_usuario_cartao.FirstOrDefault(x => x.cd_usuario_cartao == itemPedido.cd_usuario_cartao);
                        status.NumeroCartao = usuario_cartao.nu_cartao;
                        status.Valor = itemPedido.vl_valor_recarga;
                        status.NumeroPedidoEMPRESA3 = itemPedido.cd_pedido;
                        status.NumeroPedidoSpTrans = long.Parse(itemPedido.ds_pedido_operadora);

                        switch (confirmaPedido.codigoRetorno)
                        {
                            case 0:

                                itemPedido.dt_datahora_pedido_operadora = DateTime.Now;
                                itemPedido.cd_status_pedido_item = 5;

                                db.tb_log_pedido_item.Add(new tb_log_pedido_item()
                                {
                                    cd_pedido_item = itemPedido.cd_pedido_item,
                                    cd_status_pedido_item = 5,
                                    dt_log = DateTime.Now
                                });

                                db.SaveChanges();

                                EnviarEmailConfirmaPedido(itemPedido.cd_pedido, status.NumeroPedidoSpTrans, itemPedido.vl_valor_recarga, status.NumeroCartao, (decimal)itemPedido.vl_taxa, (decimal)itemPedido.vl_desconto, usuario_cartao.cd_usuario);

                                status.Status = "Aprovado";
                                status.SaldoAtualizado = true;

                                result.ListaObjeto.Add(status);
                                result.Mensagem = MensagemConstants.MensagemSucesso;
                                result.Status = 0;

                                break;
                            case 1:
                                status.Status = MensagemConstants.PedidoNotFound;
                                status.SaldoAtualizado = false;

                                result.ListaObjeto.Add(status);
                                result.Mensagem = MensagemConstants.PedidoNotFound;
                                result.Status = 1;
                                break;
                            case 2:
                                status.Status = MensagemConstants.NotConfirm;
                                status.SaldoAtualizado = false;

                                result.ListaObjeto.Add(status);
                                result.Mensagem = MensagemConstants.NotConfirm;
                                result.Status = 1;
                                break;
                            case 3:
                                status.Status = MensagemConstants.Confirmated;
                                status.SaldoAtualizado = false;

                                result.ListaObjeto.Add(status);
                                result.Mensagem = MensagemConstants.Confirmated;
                                result.Status = 1;
                                break;
                            case 4:
                                status.Status = MensagemConstants.ErroCotaEstudante;
                                status.SaldoAtualizado = false;

                                result.ListaObjeto.Add(status);
                                result.Mensagem = MensagemConstants.ErroCotaEstudante;
                                result.Status = 1;
                                break;
                            case 6:
                                status.Status = MensagemConstants.SemCotaEstudante;
                                status.SaldoAtualizado = false;

                                result.ListaObjeto.Add(status);
                                result.Mensagem = MensagemConstants.SemCotaEstudante;
                                result.Status = 1;
                                break;
                            case 7:
                                status.Status = MensagemConstants.ValorSuperior;
                                status.SaldoAtualizado = false;

                                result.ListaObjeto.Add(status);
                                result.Mensagem = MensagemConstants.ValorSuperior;
                                result.Status = 1;
                                break;
                            case 8:
                                status.Status = MensagemConstants.EstudantePeriodoLetivo;
                                status.SaldoAtualizado = false;

                                result.ListaObjeto.Add(status);
                                result.Mensagem = MensagemConstants.EstudantePeriodoLetivo;
                                result.Status = 1;
                                break;
                            case 998:
                                status.Status = MensagemConstants.ErroInformacoes;
                                status.SaldoAtualizado = false;

                                result.ListaObjeto.Add(status);
                                result.Mensagem = MensagemConstants.ErroInformacoes;
                                result.Status = 1;
                                break;
                            default:
                                status.Status = MensagemConstants.ErroConfirmacao;
                                status.SaldoAtualizado = false;

                                result.ListaObjeto.Add(status);
                                result.Mensagem = MensagemConstants.ErroConfirmacao;
                                result.Status = 1;
                                break;
                        }

                    }
                    catch (Exception ex)
                    {
                        result.Mensagem = "Erro ao Confirmar Pedido EMPRESA3 :" + itemPedido.cd_pedido + "Sptrans - " + itemPedido.ds_pedido_operadora + " - Erro: " + ex.Message + " -Stacktracer : " + ex.StackTrace;
                        result.Status = 1;
                        continue;
                    }
                }
                return result;
            }
        }

        [HttpPost]
        [Route("ConfirmarPedido")]
        public static DefaultRetornoSptrans ConfirmarPedido(int numeroPedido)
        {
            using (var db = new BD_EMPRESA3_Entities())
            {
                string SpTransService = db.tb_parametro_terceiro.Where(x => x.cd_parametro_terceiro == 15 && x.ds_nome_terceiro == "SpTransServices").FirstOrDefault().ds_link_terceiro;
                string url = SpTransService + "ConfirmarPedido/" + numeroPedido.ToString();

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                request.Method = "GET";
                request.ContentType = "application/json";
                request.KeepAlive = true;

                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                var pedido = JsonConvert.DeserializeObject<DefaultRetornoSptrans>(responseString);
                return pedido;
            }
        }
        [HttpPost]
        [Route("EnviarEmailConfirmaPedido")]
        public static DefaultRetorno EnviarEmailConfirmaPedido(long numeroPedidoEMPRESA3, long numeroPedidoSpTrans, decimal valor, string numCartao, decimal conveniencia, decimal descontos, long codUsuario)
        {
            DefaultRetorno result = new DefaultRetorno();
            try
            {
                var body = "<html><body leftmargin='0' topmargin='0' marginwidth='0' marginheight='0'> <div style=\"width:'100%'; height:57px; background-color:#7C32DD; vertical-align:middle; text-align:center;\"> <a href='http://www.EMPRESA3mais.com.br'><img src='https://www.EMPRESA3mais.com.br/EMPRESA3MaisMailImages/EMPRESA3LogoBanner.png' /></a> </div> <div style=\"height:30px; width:100%; background-color:#F2EFF8; vertical-align:middle; text-align:center;\"> </div> <div style=\"height:29px; width:100%; background-color:#F2EFF8; vertical-align:middle; text-align:center; background-image: url('https://www.EMPRESA3mais.com.br/EMPRESA3MaisMailImages/bodyTop.png'); background-repeat:no-repeat; background-position: center\"> </div> <div style=\"width:100%; background-color:#F2EFF8; background-image: url('https://www.EMPRESA3mais.com.br/EMPRESA3MaisMailImages/bodycenter.png'); background-repeat:repeat-y; background-position: center\"> <div style=\"width:440px; margin:auto;\"> <p style=\"width:300px; margin:auto; font-family:Calibri; font-weight:bold; font-size:18px;text-align:center\"> Olá, @userName </p> <div style=\"height:8px;\"></div> <p style=\"width:300px; margin:auto; font-family:Calibri; font-size:16px; text-align:center\">O Seu pedido foi <b>aprovado</b>! </p> <div style=\"height:8px;\"></div> <p style=\"width:300px; margin:auto; font-family:Calibri; font-size:16px; text-align:center\">Seus créditos já estão disponíveis para utilização.</p> <div style=\"height:8px;\"></div> <p style=\"width:300px; margin:auto; font-family:Calibri; font-size:16px; text-align:center\">Segue comprovante da transação:</p> <div style=\"height:8px;\"></div> <div style=\"width:440px; margin:auto;\"> <table style=\"margin:auto; border: 2px solid #7C32DD; border-radius: 7px;\" width=\"350px\"> <tr> <td width=\"50%\" style=\"text-align:left;font-family:Calibri; font-size:16px;\">Nº do Pedido - EMPRESA3</td> <td width=\"50%\" style=\"text-align:right;font-family:Calibri; font-size:16px;\">@numPedidoEMPRESA3</td> </tr> <tr> <td width=\"50%\" style=\"text-align:left;font-family:Calibri; font-size:16px;\">Nº do Pedido - SPTrans </td> <td width=\"50%\" style=\"text-align:right;font-family:Calibri; font-size:16px;\">@numPedidoSpTrans</td> </tr> <tr> <td width=\"50%\" style=\"text-align:left;font-family:Calibri; font-size:16px;\">Valor</td> <td width=\"50%\" style=\"text-align:right;font-family:Calibri; font-size:16px;\">@valor</td> </tr> <tr> <td width=\"50%\" style=\"text-align:left;font-family:Calibri; font-size:16px;\">Numero Cartão</td> <td width=\"50%\" style=\"text-align:right;font-family:Calibri; font-size:16px;\">@numCartao</td> </tr> </table> </div> <div style=\"width:100%; height:20px;\"></div> <table style=\"width:440px;\"> <tr> <td width=\"30px\"></td> <td style=\"font-family:Calibri; font-size:18px;\"><b>Detalhes do Pedido:</td> </tr> </table> <div style=\"width:100%; height:8px;\"> </div> <div style=\"width:100%;\"> <table style=\"text-align:center\"> <tr> <td style=\"text-align:center\"><img src='https://www.EMPRESA3mais.com.br/EMPRESA3MaisMailImages/ImagemOperadora/SpTrans.png' height=\"100px\" width=\"100px\" alt='itemPedido' /></td> <td width=\"120px\"></td> <td> <table> <tr> <td style=\"font-family:Calibri; text-align:right; font-size:14px;\"><b>Pedido: R$ @valor</td> </tr> <tr> <td style=\"font-family:Calibri;text-align:right; font-size:14px;\">Conveniência: R$ @taxa</td> </tr> <tr> <td style=\"font-family:Calibri; color: blue;text-align:right; font-size:14px;\">Desconto: R$ @desconto</td> </tr> <tr> <td></td> </tr> <tr> <td style=\"font-family:Calibri;text-align:right; font-size:14px;\"><b>Total: R$ @totalComDesconto </td> </tr> </table> </td> </tr> </table> </div> <div style=\"width:100%; height:10px;\"></div> </div> </div> <div style=\"height:27px; width:100%; background-color:#F2EFF8; background-image: url('https://www.EMPRESA3mais.com.br/EMPRESA3MaisMailImages/bodyunder.png'); background-repeat:no-repeat; background-position: center\"> </div> <div style=\"height:25px; width:100%; background-color:#F2EFF8\"> </div> <div style=\"height:30px; width:100%; background-color:#F2EFF8; text-align:center;\"> <a href='https://www.instagram.com/EMPRESA3maisapp/'> <img src='https://www.EMPRESA3mais.com.br/EMPRESA3MaisMailImages/Instagram.png' alt='instagram' /> </a> <a href='http://www.EMPRESA3mais.com.br'> <img src='https://www.EMPRESA3mais.com.br/EMPRESA3MaisMailImages/site.png' alt='site' /> </a> </div> <div style=\"height:20px; width:100%; background-color:#F2EFF8; text-align:center;\"></div> <div style=\"height:5px; width:100%; background-color:#F2EFF8; text-align:center;\"> </div> <div style=\"height:50px; width:100%; background-color:#F2EFF8; text-align:center\"> <a href='http://www.EMPRESA3mais.com.brstore'> <img src='https://www.EMPRESA3mais.com.br/EMPRESA3MaisMailImages/appstore.png' alt='appstore' /> </a> <a href='http://www.EMPRESA3mais.com.br'> <img src='https://www.EMPRESA3mais.com.br/EMPRESA3MaisMailImages/googleplay.png' alt='googleplay' /> </a> </div></body></html>";

                using (var dbs = new BD_EMPRESA3_Entities())
                {
                    StringBuilder builder = new StringBuilder(body);

                    var usuario = dbs.tb_usuario.FirstOrDefault(x => x.cd_usuario == codUsuario);
                    var valorDesconto = (valor + conveniencia) - descontos;
                    builder.Replace("@userName", usuario.nm_usuario);
                    builder.Replace("@numPedidoEMPRESA3", numeroPedidoEMPRESA3.ToString());
                    builder.Replace("@numPedidoSpTrans", numeroPedidoSpTrans.ToString());
                    builder.Replace("@valor", valor.ToString());
                    builder.Replace("@numCartao", numCartao.ToString());
                    builder.Replace("@taxa", conveniencia.ToString());
                    builder.Replace("@desconto", descontos.ToString());
                    builder.Replace("@totalComDesconto", valorDesconto.ToString());

                    body = builder.ToString();

                    string dsAssunto = "Confirmação Pedido - SpTrans";
                    int cdTipoEmail = 3;
                    long cdUsuario = usuario.cd_usuario;
                    string email = usuario.ds_email_usuario;
                    //Envio Direto
                    //var parametroEmail = dbs.tb_parametro_email.FirstOrDefault();
                    //var message = new MailMessage
                    //{
                    //    IsBodyHtml = true
                    //};
                    //message.To.Add(new MailAddress(email.ToLower()));
                    //message.To.Add(new MailAddress("heberth.silva@base2.com.br"));
                    //message.From = new MailAddress(parametroEmail.ds_from);
                    //message.Subject = dsAssunto;

                    //var avw = AlternateView.CreateAlternateViewFromString(body, null, MediaTypeNames.Text.Html);
                    //message.AlternateViews.Add(avw);
                    //message.Body = body;

                    //using (var smtp = new SmtpClient())
                    //{
                    //    smtp.Credentials = new NetworkCredential
                    //    {
                    //        UserName = parametroEmail.ds_usuario,
                    //        Password = parametroEmail.ds_senha
                    //    };

                    //    smtp.Host = parametroEmail.ds_host;
                    //    smtp.Port = parametroEmail.nu_porta;
                    //    smtp.EnableSsl = true;

                    //    smtp.Send(message);
                    //}

                    //envio pelo serviço

                    dbs.tb_envio_email.Add(new tb_envio_email
                    {
                        email_usuario = email,
                        ds_assunto = dsAssunto,
                        cd_tipo_email = cdTipoEmail,
                        cd_usuario = cdUsuario,
                        ds_corpo_email = body,
                        ic_envio = false,
                        dt_criacao = DateTime.Now

                    });
                    dbs.SaveChanges();
                }
                result.Status = 0;
                result.Mensagem = MensagemConstants.MensagemSucesso;
                return result;
            }
            catch (Exception ex)
            {
                result.Status = 1;
                result.Mensagem = ex.Message;
                result.MensagemStatus = ex.StackTrace;
                return result;
            }

        }
    }
}

