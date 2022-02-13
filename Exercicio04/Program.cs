using System;

namespace Exercicio04
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] numero = new int[5];
            int mediaAritmetica,soma = 0, contadorPositivos = 0, contadorNegativos = 0;
            for (int i = 0; i < 5; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numero[i] = num;
                soma += numero[i];
                if (numero[i] > 0)
                {
                    contadorPositivos++;
                }
                else
                {
                    contadorNegativos++;
                }
            }
            mediaAritmetica = soma / 5;
            Console.WriteLine($"A Média Aritmética: {mediaAritmetica}\nA Quantidade de valores positivos é: {contadorPositivos}\nA Quantidade de valores negativos é: {contadorNegativos}");
            Console.ReadLine();
       }
    }
}
