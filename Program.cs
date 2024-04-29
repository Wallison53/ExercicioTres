namespace ExercicioTres;

class Program
{
    static void Main()
    {
        ContaPoupanca contaPoupanca = new ContaPoupanca(1001, 1000, 0.03);
        ContaCorrente contaCorrente = new ContaCorrente(2001, 2000, 10);

        contaPoupanca.Depositar(500);
        contaPoupanca.Sacar(200);
        contaPoupanca.AplicarJuros();

        contaCorrente.Depositar(1000);
        contaCorrente.Sacar(500);

        Console.WriteLine("Saldo da Conta Poupança: " + contaPoupanca.Saldo);
        Console.WriteLine("Saldo da Conta Corrente: " + contaCorrente.Saldo);
    }
}

