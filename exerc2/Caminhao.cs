namespace exerc2
{
    public class Caminhao : Transporte
    {
        public Caminhao(Carga carga) : base(carga) {}
        
        public override double calculaFrete(int distancia) {
            Carga caminhaoCarga = this.Carga;

            double frete = 0.02 * caminhaoCarga.Peso + 0.03 * caminhaoCarga.Valor + 2 * distancia; 

            if (caminhaoCarga.Valor > 40000) {
                frete -= 0.25 * frete;
            }

            return frete;
        }
    }
}