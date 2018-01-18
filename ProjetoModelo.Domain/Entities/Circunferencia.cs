namespace ProjetoModelo.Domain.Entities
{
    public class Circunferencia : AvaliacaoFisica
    {
        public int Id { get; private set; }
        public double Glutea { get; set; }
        public double Panturrilha { get; set; }
        public double Maleoar { get; set; }
        public double TroncoIM { get; set; }
        public double TroncoEM { get; set; }
    }
}
