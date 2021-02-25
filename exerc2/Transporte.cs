namespace exerc2
{
    public abstract class Transporte
    {
        protected readonly Carga Carga;
        public Transporte(Carga carga) {
            this.Carga = carga;
        }
        public abstract double calculaFrete(int distancia);
    }
}