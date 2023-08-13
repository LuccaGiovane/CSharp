using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytebank.Titular;

namespace Bytebank.Contas
{
    internal class ContaCorrente
    {
        private int numero_agencia;
        public int Numero_Agencia
        {
            get { return numero_agencia; }
            set 
            {
                if(value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }
        //private string conta;
        public string Conta { get; set; }
        private double saldo = 100;
        public Cliente Titular { get; set; }
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Não foi possivel realizar o saque. Saldo insuficiente.");

            }
            else
            {
                saldo -= valor;
            }
        }

        public void Transferir(double valor, ContaCorrente contaDestinataria)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente. Transferencia nao realizada.");
            }
            else
            {
                saldo -= valor;
                contaDestinataria.Depositar(valor);
            }

        }

        public void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }
    }
}
