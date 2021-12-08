using DesingPatternTemplateMethod_Relatorio.Dominio;
using System;

namespace DesingPatternTemplateMethod_Relatorio.Infraestrutura.Relatorios
{
    public class Complexo : TemplateRelatorio
    {
        public override void Cabecalho(Banco banco)
        {
            var cabecalho = string.Join("         ", banco.NomeDoBanco,banco.Endereco, banco.Telefone);
            cabecalho += Environment.NewLine + "__________________________________________________________________________________________\r\n\r\n";

            Console.WriteLine(cabecalho);
        }

        public override void Corpo(Banco banco)
        {
            const int NameAlignment = -20;
            const int ValueAlignment = 10;

            Console.WriteLine($"|{"Nome do titular",NameAlignment}|{"Agência",ValueAlignment}|{"Conta",ValueAlignment}|{"Saldo R$",ValueAlignment:F2}|");
            Console.WriteLine("_______________________________________________________");


            foreach (var conta in banco.Contas)
            {
                Console.WriteLine($"|{conta.Titular,NameAlignment}|{conta.Agencia,ValueAlignment}|{conta.NumeroConta,ValueAlignment}|{conta.Saldo,ValueAlignment:F2}|");
            }
        }

        public override void Rodape(Banco banco)
        {
            var rodape = Environment.NewLine + "\r\n\r\n__________________________________________________________________________________________";
            rodape += Environment.NewLine + string.Join("         ", banco.Email, banco.DataAtual);

            Console.WriteLine(rodape);
            Console.ReadKey();
        }
    }
}
