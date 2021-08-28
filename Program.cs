using System.Runtime.Versioning;
using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var contaAtual = new ContaCorrente(207845);
            var contaNova = ConverteConta<ContaCorrente, ContaPoupanca>(contaAtual);
            Console.WriteLine($"{contaNova.Saldo}");
            

            //var conta1 = new ContaCorrente(10);
            //Console.WriteLine($"{conta.Saldo}");
            //Console.WriteLine($"{conta1.Saldo}");
            //Transferencia(10, conta, conta1);
            //Console.WriteLine($"{conta.Saldo}");
            //Console.WriteLine($"{conta1.Saldo}");
            //Console.WriteLine($"{conta.Saldo}");
        }

        public static D ConverteConta<A, D>(A contaAntes) where A : Conta where D : Conta
        {
            D contaDepois = Activator.CreateInstance<D>();
            contaDepois.Depositar(contaAntes.Saldo); //depositando só pra ver a conta nova
            contaAntes = null; //não necessario mas colocado pra 'deletar' a conta antiga
            
            
            //pra funcionar teria que passar agencia, numero e saldo como parâmetro para todos objetos
            //contaDepois.setAttributes(contaAntes.agencia, contaAntes.numero, contaAntes.saldo);
            
            return contaDepois;
        }

    //  public static void Transferencia(int valor, ContaCorrente contaOrigem, ContaCorrente contaDestino)
    //  { 
    //     contaOrigem.Sacar(valor);
    //     contaDestino.Depositar(valor);
    //  }
    }
}