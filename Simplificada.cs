using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PessoaFisicaSimplificada
{
    public class Simplificada
    {
        public string Documento { get; set; }
        public string Nome { get; set; }
        public string Mensagem { get; set; }
        public bool Status { get; set; }
    }
    public class Credenciais
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }

    public class Requisicao
    {
        public Credenciais Credenciais { get; set; }
        public string Documento { get; set; }
        public string DataNascimento { get; set; }
    }

}
