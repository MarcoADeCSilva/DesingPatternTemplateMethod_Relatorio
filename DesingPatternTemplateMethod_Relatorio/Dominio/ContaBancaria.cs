namespace DesingPatternTemplateMethod_Relatorio.Dominio
{
    public class ContaBancaria
    {
        public ContaBancaria(string titular, string agencia, string numeroConta, decimal saldo)
        {
            Titular = titular;
            Agencia = agencia;
            NumeroConta = numeroConta;
            Saldo = saldo;
        }

        public string Titular { get; private set; }
        public string Agencia { get; private set; }
        public string NumeroConta { get; private set; }
        public decimal Saldo { get; private set; }
    }
}
