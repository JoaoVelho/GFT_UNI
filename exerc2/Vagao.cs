namespace exerc2
{
    public class Vagao : Transporte
    {
        public Vagao(Carga carga) : base(carga) {}
        
        public override double calculaFrete(int distancia) {
            Carga vagaoCarga = this.Carga;

            double frete = 0.07 * vagaoCarga.Peso + 0.01 * vagaoCarga.Valor + 0.5 * distancia;

            if (vagaoCarga.Peso < 15000) {
                frete += 5000;
            }

            return frete;
        }
    }
}