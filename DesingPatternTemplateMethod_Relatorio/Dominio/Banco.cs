using System;
using System.Collections.Generic;

namespace DesingPatternTemplateMethod_Relatorio.Dominio
{
    public class Banco
    {
        public Banco(string nomeDoBanco, string endereco, string telefone, string email, DateTime dataAtual)
        {
            NomeDoBanco = nomeDoBanco;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            DataAtual = dataAtual;
            this.Contas = new List<ContaBancaria>();
        }

        public string NomeDoBanco { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public DateTime DataAtual { get; private set; }
        public List<ContaBancaria> Contas { get; private set; }

        public void AdicionaItem(ContaBancaria contaBancaria)
        {
            Contas.Add(contaBancaria);
        }
    }
}
