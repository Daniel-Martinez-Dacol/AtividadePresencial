using System;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random dado = new Random();
            Console.Write("Digite o nome do primero jogador: ");
            String nome1 = Console.ReadLine();
            Console.Write("\nDigite o nome do primero jogador: ");
            String nome2 = Console.ReadLine();

            int resultado1, resultado2, ponto1 = 0, ponto2 = 0;

            //Rodada 1: 
            Console.WriteLine("1ª Rodada:");
            resultado1 = dado.Next(6);
            resultado2 = dado.Next(6);
            Console.WriteLine($"{nome1}: {resultado1}\n{nome2}: {resultado2}\n");

            if (resultado1 > resultado2)
            {
                Console.WriteLine($"O jogador {nome1} jogou {resultado1} e ganhou a 1ª rodada!\n");
                ponto1++;
            }
            else if (resultado2 > resultado1)
            {
                Console.WriteLine($"O jogador {nome2} jogou {resultado2} e ganhou a 1ª rodada!\n");
                ponto2++;
            }

            //Rodada 2:
            Console.WriteLine("2ª Rodada: ");
            resultado1 = dado.Next(6);
            resultado2 = dado.Next(6);
            Console.WriteLine($"{nome1}: {resultado1}\n{nome2}: {resultado2}\n");

            if (resultado1 > resultado2)
            {
                Console.WriteLine($"O jogador {nome1} jogou {resultado1} e ganhou a 2ª rodada!\n");
                ponto1++;
            }
            else if (resultado2 > resultado1)
            {
                Console.WriteLine($"O jogador {nome2} jogou {resultado2} e ganhou a 2ª rodada!\n");
                ponto2++;
            }

            //Rodada 3:
            Console.WriteLine("3ª Rodada: ");
            resultado1 = dado.Next(6);
            resultado2 = dado.Next(6);
            Console.WriteLine($"{nome1}: {resultado1}\n{nome2}: {resultado2}\n");

            if (resultado1 > resultado2)
            {
                Console.WriteLine($"O jogador {nome1} jogou {resultado1} e ganhou a 3ª rodada!");
                ponto1++;
            }
            else if (resultado2 > resultado1)
            {
                Console.WriteLine($"O jogador {nome2} jogou {resultado2} e ganhou a 3ª rodada!");
                ponto2++;
            }
          
            if (ponto1 > ponto2)
            {
                Console.WriteLine($"Parabéns {nome1}, você ganhou o jogo!\n");
            }
            else if (ponto2 > ponto1)
            {
                Console.WriteLine($"Parabéns {nome2}, você ganhou o jogo!\n");
            }
            else if (ponto1 == ponto2) {
                //Caso de empate: 
                Console.WriteLine("Caso de empate 1x1 na rodada 3: ");
                resultado1 = dado.Next(6);
                resultado2 = dado.Next(6);
                Console.WriteLine($"{nome1}: {resultado1}\n{nome2}: {resultado2}\n");

                if (resultado1 > resultado2)
                {
                    ponto1++;
                }
                else if (resultado2 > resultado1)
                {
                    ponto2++;
                }
                Console.WriteLine("Houve um empate definitivo, tentem novamente!\n");
            }
            Console.ReadLine();
        }
    }
}
