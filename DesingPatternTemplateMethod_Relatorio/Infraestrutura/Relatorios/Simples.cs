using DesingPatternTemplateMethod_Relatorio.Dominio;
using System;
using System.Linq;
using System.Reflection;

namespace DesingPatternTemplateMethod_Relatorio.Infraestrutura.Relatorios
{
    public class Simples : TemplateRelatorio
    {
        public override void Cabecalho(Banco banco)
        {            
            var cabecalho = string.Join("         ", banco.NomeDoBanco);
            cabecalho += Environment.NewLine + "__________________________________________________\r\n\r\n";

            Console.WriteLine(cabecalho);            
        }

        public override void Corpo(Banco banco)
        {
            const int NameAlignment = -20;
            const int ValueAlignment = 10;

            Console.WriteLine($"|{"Nome do titular",NameAlignment}|{"Saldo R$",ValueAlignment:F2}|");
            Console.WriteLine("___________________________________");


            foreach (var conta in banco.Contas)
            {
                Console.WriteLine($"|{conta.Titular,NameAlignment}|{conta.Saldo,ValueAlignment:F2}|");                                
            }            
        }

        public override void Rodape(Banco banco)
        {
            var rodape = Environment.NewLine + "\r\n\r\n__________________________________________________";
            rodape += Environment.NewLine + string.Join("         ", banco.Telefone); 

            Console.WriteLine(rodape);
            Console.ReadKey();            
        }
    }
}
