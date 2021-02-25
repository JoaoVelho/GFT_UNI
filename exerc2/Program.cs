using System;

namespace exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um peso em Kg: ");
            int peso = int.Parse(Console.ReadLine());

            Console.Write("Informe um valor em R$: ");
            int valor = int.Parse(Console.ReadLine());

            Console.Write("Informe uma distância em Km: ");
            int distancia = int.Parse(Console.ReadLine());

            Carga carga = new Carga();
            carga.Peso = peso;
            carga.Valor = valor;

            Vagao vagao = new Vagao(carga);
            Caminhao caminhao = new Caminhao(carga);

            double freteVagao = vagao.calculaFrete(distancia);
            double freteCaminhao = caminhao.calculaFrete(distancia);

            Console.WriteLine("Frete Vagão: R${0} e Frete Caminhão: R${1}", freteVagao.ToString("N2"), freteCaminhao.ToString("N2"));
        }
    }
}
