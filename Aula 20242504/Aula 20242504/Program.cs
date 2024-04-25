using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20242504
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente cc = new ContaCorrente(13, 24, 1000);
                cc.Sacar(6000);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine("Informação do objeto. Mensagem: " +ex.Message);
                Console.WriteLine("Informação do objeto. Conta: " + ex.numConta);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finalizando...");
            }
        }
    }
}
