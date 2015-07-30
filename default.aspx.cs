using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestSharp;

namespace PessoaFisicaSimplificada
{
    public partial class defaultaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var client = new RestClient("http://www.soawebservices.com.br/restservices/test-drive/cdc/pessoafisicasimplificada.ashx");
            var request = new RestRequest(Method.POST);

            // Credenciais de Acesso
            Credenciais credenciais = new Credenciais();
            credenciais.Email = "seu email";
            credenciais.Senha = "sua senha";

            // Requisicao
            Requisicao requisicao = new Requisicao();
            requisicao.Credenciais = credenciais;
            requisicao.Documento = "99999999999";
            requisicao.DataNascimento = "01/01/1900";
            
            // Adiciona Payload a requisicao
            request.AddJsonBody(requisicao);


            IRestResponse<Simplificada> response = client.Execute<Simplificada>(request);
            Simplificada simplificada = new Simplificada();

            simplificada = response.Data;


            if (simplificada.Status == true)
            {
                this.nome.InnerText = simplificada.Nome;
            }
            else
            {
                this.nome.InnerText = String.Format("Ocorreu um erro: {}", simplificada.Mensagem);
            }
        }
    }
}
