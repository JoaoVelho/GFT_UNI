using System;

namespace exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Multiplicando:");
            int multiplicando = int.Parse(Console.ReadLine());

            if (!CheckValid(multiplicando, "multiplicando")) {
                return;
            }

            Console.Write("Início do intervalo:");
            int inicio = int.Parse(Console.ReadLine());

            if (!CheckValid(inicio, "inicio")) {
                return;
            }

            Console.Write("Fim do intervalo:");
            int fim = int.Parse(Console.ReadLine());

            if (!CheckValid(fim, "fim")) {
                return;
            }

            if (inicio > fim) {
                Console.WriteLine("O início do intervalo deve ser menor que seu fim");
                return;
            } else if (fim - inicio >= 10) {
                Console.WriteLine("O intervalo não pode ter uma diferença maior que 10");
                return;
            }

            for (int i = inicio; i <= fim; i++) {
                int result = multiplicando * i;
                Console.WriteLine("{0} x {1} = {2}", multiplicando, i, result);
            }
        }

        static bool CheckValid(int value, string valueName) 
        {
            if (value < 0 || value > 3000) {
                Console.WriteLine("O {0} deve ser positivo e menor que 3001", valueName);
                return false;
            }
            return true;
        }
    }
}
