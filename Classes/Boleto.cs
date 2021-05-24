using System;

namespace Abstração_Herança_e_encapsulamento.Classes
{
    public class Boleto : Pagamento
    {
        private string CodigoDeBarra;

        Random r = new Random();

        public void Registrar(){
            CodigoDeBarra = r.Next(3000000).ToString();

            Console.WriteLine($"O Boleto gerado com o codigo {CodigoDeBarra}");
            Console.WriteLine($"O Boleto regitrado com desconto de 12%, o valor sera de {this.Valor * 0.88:C2} ");
        }
    }
}