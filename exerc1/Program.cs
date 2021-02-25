using System;

namespace exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Multiplicando:");
            int multiplicando = int.Parse(Console.ReadLine());

            Console.Write("Início do intervalo:");
            int inicio = int.Parse(Console.ReadLine());

            Console.Write("Fim do intervalo:");
            int fim = int.Parse(Console.ReadLine());

            for (int i = inicio; i <= fim; i++) {
                int result = multiplicando * i;
                Console.WriteLine("{0} x {1} = {2}", multiplicando, i, result);
            }
        }
    }
}
