using System;
using Abstração_Herança_e_encapsulamento.Classes;

namespace Abstração_Herança_e_encapsulamento
{
    class Program
    {

        static void Main(string[] args)
        {
            bool opçaoValida = false;
            do
            {
                Console.WriteLine($@"
Escolha um metodo de pagamento :

B - Boleto
C - Credito
D - Débito
X - Cancelar Pagamento          
            ");
                string opcao = Console.ReadLine().ToUpper();

                switch (opcao)
                {
                    case "B":
                        Boleto b = new Boleto();
                        b.Registrar();
                        opçaoValida = true;
                        break;
                    case "C":
                        Credito c = new Credito();
                        Console.WriteLine(c.SalvarCartao());
                        c.Pagar();
                        opçaoValida = true;
                        break;
                    case "D":
                        Debito d = new Debito();
                        Console.WriteLine(d.SalvarCartao());
                        d.Pagar();
                        opçaoValida = true;
                        break;
                    case "X":
                        Pagamento p = new Pagamento();
                        Console.WriteLine(p.Cancelar());
                        opçaoValida = true;
                        break;
                    default:
                        Console.WriteLine("Opção de pagamento invalido!");
                        opçaoValida = false;
                        break;
                }
            } while (!opçaoValida);
        }
    }
}
