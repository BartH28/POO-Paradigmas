using System;

namespace Abstração_Herança_e_encapsulamento.Classes
{
    public abstract class Cartão : Pagamento
    {
        public string Bandeira;
        public string Numero;
        public string Titular;
        public string CVV;

        public string SalvarCartao(){
            Console.WriteLine("Digite a bandeira  do cartão");
            Bandeira = Console.ReadLine();

            Console.WriteLine("Digite o Numero do cartão");
            Numero = Console.ReadLine();

            Console.WriteLine("Digite o titular do cartão");
            Titular = Console.ReadLine();

            Console.WriteLine("Digite o CVV do cartão");
            CVV = Console.ReadLine();

            return "O Cartão foi salvo";
        }
    }
}