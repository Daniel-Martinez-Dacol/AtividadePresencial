using System;

namespace ListaDeExercicioPresencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largura = int.Parse(Console.ReadLine()); // 50
            int altura = int.Parse(Console.ReadLine());  // 10       
            string tabela = "";
            
            for (int i = 0; i < altura; i++)
            {
                tabela += "\n";
                for (int j = 0; j < largura; j++)
                {
                    if (j % 2 == 0)
                    {
                        tabela += "A";
                    } else {
                        tabela += "B";
                    }                                 
                                            
                }
            }
            Console.WriteLine(tabela);
            Console.ReadLine();
        }
    }
}
