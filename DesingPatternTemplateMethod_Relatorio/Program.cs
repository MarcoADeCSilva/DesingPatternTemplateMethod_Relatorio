using DesingPatternTemplateMethod_Relatorio.Dominio;
using DesingPatternTemplateMethod_Relatorio.Infraestrutura.Relatorios;
using DesingPatternTemplateMethod_Relatorio.Interface;
using System;

namespace DesingPatternTemplateMethod_Relatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco("Itaú", "Avenida Nelson Davila, 15, Centro, São José dos Campos", 
                "(12)21399052", "gerente@itau.com.br", DateTime.Now);

            banco.AdicionaItem(new ContaBancaria("Mario Lima", "1529", "05151", 5000));
            banco.AdicionaItem(new ContaBancaria("João Melão", "2089", "15062", 10000));
            banco.AdicionaItem(new ContaBancaria("Paula Maria", "3059", "15789", 7000));
            banco.AdicionaItem(new ContaBancaria("Julia Borges", "1896", "90987", 3000));

            IRelatorio simples = new Simples();
            IRelatorio complexo = new Complexo();

            //simples.ImprimeRelatorio(banco);
            complexo.ImprimeRelatorio(banco);
        }
    }
}
