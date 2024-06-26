// Classe ContaCorrente que herda de ContaBancaria e pode incluir TaxaDeManutencao
public class ContaCorrente : ContaBancaria
{
    public double TaxaDeManutencao { get; set; }

    public ContaCorrente(int numeroDaConta, double saldo, double taxaDeManutencao)
        : base(numeroDaConta, saldo)
    {
        TaxaDeManutencao = taxaDeManutencao;
    }
}
