using System;

namespace Abstração_Herança_e_encapsulamento.Classes
{
    public class Credito : Cartão
    {
        private float Limite = 3000f;



        public void Pagar()
        {
            float valor = this.Valor;
            int vezes;

            if (valor > Limite)
            {
                Console.WriteLine("O seu limite não é suficiente para pagar esse valor!");
            }
            else
            {
                do
                {
                    Console.WriteLine($"Em quantas voce deseja parcelar o valor {Valor} ? (de 1 à 12)");
                    vezes = int.Parse(Console.ReadLine());

                    if (vezes >= 1 && vezes <= 6)
                    {
                        Console.WriteLine($"Voce optou parcelar em {vezes} vezes, dessa forma o juros sera de 5% do valor total");
                        Console.WriteLine($"Voce pagara o valor de {valor * 1.05:C2} em {vezes} de {(valor * 1.05) / vezes:C2}");
                    }
                    else if (vezes >= 7 && vezes <= 12)
                    {
                        Console.WriteLine($"Voce optou parcelar em {vezes} vezes, dessa forma o juros sera de 8% do valor total");
                        Console.WriteLine($"Voce pagara o valor de {valor * 1.08:C2} em {vezes} de {(valor * 1.08) / vezes:C2}");
                    }
                    else
                    {
                        Console.WriteLine("Está quantidade é invalida, escolha entre 1 e 12 vezes");
                    }
                } while (vezes < 1 || vezes > 12);
            }
        }
    }
}