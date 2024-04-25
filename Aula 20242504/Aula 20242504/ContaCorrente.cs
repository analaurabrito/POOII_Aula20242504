using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20242504
{
    internal class ContaCorrente
    {
        public int agencia;
        public int numero;
        public double saldo;
        public bool isVivo;

        public ContaCorrente(int agencia, int numero, double saldo, bool isVivo)
        {
            this.agencia = agencia;
            this.numero = numero;
            this.saldo = saldo;
            this.isVivo = isVivo;
        }

        public void Sacar(double valor)
        {
            if(saldo < valor)
            {
                Console.WriteLine("Impossível.");
                throw new SaldoInsuficienteException(numero, "Sem saldo.");
            }
            else
            {
                saldo -= valor;
            }
        }
    }
}
