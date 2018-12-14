using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_Sobrecarga_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta_Banco novaConta;

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial(s / n) ?");
            char condicao = char.Parse(Console.ReadLine());

            if(condicao.ToString().ToUpper() == "S")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                novaConta = new Conta_Banco(numeroConta, nomeTitular, saldo);
            }
            else
            {
                novaConta = new Conta_Banco(numeroConta, nomeTitular);
            }

            Console.WriteLine(novaConta);

            Console.Write("\nEntre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            novaConta.Deposito(deposito);
            Console.WriteLine(novaConta);

            Console.Write("\nEntre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            novaConta.Saque(saque);
            Console.WriteLine(novaConta);

            Console.ReadLine();
        }
    }
}
