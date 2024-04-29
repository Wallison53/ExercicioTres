using System;

// Classe base ContaBancaria
public class ContaBancaria
{
    public int NumeroDaConta { get; set; }
    public double Saldo { get; set; }

    public ContaBancaria(int numeroDaConta, double saldo)
    {
        NumeroDaConta = numeroDaConta;
        Saldo = saldo;
    }

    public virtual void Depositar(double valor)
    {
        Saldo += valor;
    }

    public virtual void Sacar(double valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque.");
        }
    }
}