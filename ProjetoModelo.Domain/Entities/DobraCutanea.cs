namespace ProjetoModelo.Domain.Entities
{
    public class DobraCutanea : AvaliacaoFisica
    {
        public int Id { get; private set; }
        public double Subescapular { get; set; }
        public double Triceps { get; set; }
        public double Biceps { get; set; }
        public double Peitoral { get; set; }
        public double AxilarMediaObliqua { get; set; }
        public double AxilarMediaVertical { get; set; }
        public double AbdominalVertical { get; set; }
        public double AbdominalHorizontal { get; set; }
        public double SupraIliacaObliqua { get; set; }
        public double SupraIliacaVertical { get; set; }
        public double SupraEspinhal { get; set; }
        public double Coxa { get; set; }
    }
}
