using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaLorena = new ContaCorrente();
            contaDaLorena.Titular = new Cliente();

            contaDaLorena.Titular.Nome = "Lorena";

            Console.WriteLine("Essa conta pertence a: " + contaDaLorena.Titular.Nome);
            Console.WriteLine("O seu saldo é de: " + contaDaLorena.Saldo);

            contaDaLorena.Depositar(150);
            Console.WriteLine("Seu novo saldo, após um depósito é de: " + contaDaLorena.Saldo);

            Console.ReadLine();
        }
    }
}
