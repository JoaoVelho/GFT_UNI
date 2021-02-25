namespace exerc3
{
    public class SimulacaoCustoFrete
    {
        public static double[] compararFrete(int[,] lista) {
            int numCaminhoes = 0;
            int numVagoes = 0;

            double custoTotal = 0;

            double[] result = new double[3];

            for (int i = 0; i < 7; i++) {
                int peso = lista[i, 0];
                int valor = lista[i, 1];
                int distancia = lista[i, 2];

                Carga carga = new Carga();
                carga.Peso = peso;
                carga.Valor = valor;

                Vagao vagao = new Vagao(carga);
                Caminhao caminhao = new Caminhao(carga);

                double freteVagao = vagao.calculaFrete(distancia);
                double freteCaminhao = caminhao.calculaFrete(distancia);

                if (freteCaminhao <= freteVagao) {
                    numCaminhoes++;
                    custoTotal += freteCaminhao;
                } else {
                    numVagoes++;
                    custoTotal += freteVagao;
                }
            }

            result[0] = numCaminhoes;
            result[1] = numVagoes;
            result[2] = custoTotal;

            return result;
        }
    }
}