using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("rua um", "5555666", "Curitiba", "PR");
                Cliente cliente = new Cliente("Chrys", "00011122233", "99999987", endereco);
                //ContaBancaria conta = new ContaBancaria(cliente);
                ContaCorrente conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta " + conta.Situacao +": " + conta.NumeroConta + "-" + conta.DigitoVerificador);

                string senha = ("abcd1234");
                conta.Abrir(senha);
                Console.WriteLine("Conta " + conta.Situacao + ": " + conta.NumeroConta + "-" + conta.DigitoVerificador);

                conta.Sacar(10, senha);
                Console.WriteLine("Saldo: " + conta.Saldo);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
