using System;

namespace Abstração_Herança_e_encapsulamento.Classes
{
    public class Debito : Cartão
    {
        private float Saldo = 600f;

        public void Pagar(){
            float valor = this.Valor;

            if (valor > Saldo)
            {
                Console.WriteLine("Voce não possui saldo suficiente para pagar este valor");

            }
            else
            {
                Console.WriteLine($"O valor de {valor:C2} foi pago com sucesso!");
            }
        }
    }
}