using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_Sobrecarga_Encapsulamento
{
    class Conta_Banco
    {
        public int numeroConta { get; private set; }
        public string nomeTitular { get; private set; }
        public double saldo { get; private set; }

        public Conta_Banco(int numeroConta, string nomeTitular)
        {
            this.numeroConta = numeroConta;
            this.nomeTitular = nomeTitular;
        }

        public Conta_Banco (int numeroConta, string nomeTitular, double depositoInicial) : this(numeroConta, nomeTitular)
        {
            Deposito(depositoInicial);
        }

        public double Deposito(double deposito)
        {
            return saldo += deposito;
        }

        public double Saque(double saque)
        {
            return saldo -= (saque + 5);
        }

        public override string ToString()
        {
            return "Dados da Conta\nNumero da conta: "
                + numeroConta
                + ", Nome do Titular: "
                + nomeTitular
                + ", Saldo em conta: "
                + saldo.ToString("F2");
        }
    }
}
