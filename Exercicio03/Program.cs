using System;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a hora atual: ");
            int horaAtual = int.Parse(Console.ReadLine());

            if (horaAtual > 18)
            {
                Console.WriteLine("Boa Noite");
            } else if (horaAtual > 6 && horaAtual < 12) {
                Console.WriteLine("Bom dia");
            } else if (horaAtual>12 && horaAtual < 18) {
                Console.WriteLine("Boa Tarde");
            }
            Console.ReadLine();
        }
        
    }
}
