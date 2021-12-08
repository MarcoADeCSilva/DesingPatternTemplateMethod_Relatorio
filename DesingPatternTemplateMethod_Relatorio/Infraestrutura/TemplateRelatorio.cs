using DesingPatternTemplateMethod_Relatorio.Dominio;
using DesingPatternTemplateMethod_Relatorio.Interface;

namespace DesingPatternTemplateMethod_Relatorio.Infraestrutura
{
    public abstract class TemplateRelatorio : IRelatorio
    {
        public void ImprimeRelatorio(Banco banco)
        {
            Cabecalho(banco);
            Corpo(banco);
            Rodape(banco);
        }

        public abstract void Cabecalho(Banco banco);
        public abstract void Corpo(Banco banco);
        public abstract void Rodape(Banco banco);
    }
}
