using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20242504
{
    internal class SaldoInsuficienteException : Exception
    {
        public int numConta { get; set; }

        public SaldoInsuficienteException(int numConta, String mensagem) : base(mensagem)
        {
            this.numConta = numConta;
        }
    }
}
