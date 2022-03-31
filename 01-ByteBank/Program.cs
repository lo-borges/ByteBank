 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente primeiraContaCorrente = new ContaCorrente();
            primeiraContaCorrente.saldo = 200;
            Console.WriteLine(primeiraContaCorrente.saldo);

            primeiraContaCorrente.saldo += 100;
            Console.WriteLine(primeiraContaCorrente.saldo);

            ContaCorrente segundaContaCorrente = new ContaCorrente();
            segundaContaCorrente.saldo = 50;

            Console.WriteLine("A primeira conta tem R$ " + primeiraContaCorrente.saldo);
            Console.WriteLine("A segunda conta tem R$ " + segundaContaCorrente.saldo);

            primeiraContaCorrente.Depositar(100);
            Console.WriteLine("A primeira conta tem R$ " + primeiraContaCorrente.saldo);

            primeiraContaCorrente.Transferir(45, segundaContaCorrente);
            Console.WriteLine("A primeira conta tem R$ " + primeiraContaCorrente.saldo);
            Console.WriteLine("A segunda conta tem R$ " + segundaContaCorrente.saldo);

            segundaContaCorrente.Sacar(10);
            Console.WriteLine("A segunda conta tem R$ " + segundaContaCorrente.saldo);

            Console.ReadLine();
        }
    }
}
