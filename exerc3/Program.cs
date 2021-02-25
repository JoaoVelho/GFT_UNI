using System;

namespace exerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] lista = new int[7, 3] {
                {18550, 27500, 200},
                {8100, 35410, 554},
                {25700, 3650, 112},
                {9541, 5799, 1580},
                {25740, 45000, 321},
                {5000, 90570, 627},
                {8900, 41000, 876}
            };

            double[] result = new double[3];
            result = SimulacaoCustoFrete.compararFrete(lista);

            Console.WriteLine("Nº Caminhões: {0}\nNº Vagões: {1}\nCusto Total: R${2}", result[0], result[1], result[2].ToString("N2"));
        }
    }
}
