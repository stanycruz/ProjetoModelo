namespace ProjetoModelo.Domain.Entities
{
    public class Antopometrica : AvaliacaoFisica
    {
        public int Id { get; private set; }
        public double Pescoco { get; set; }
        public double Toraxica { get; set; }
        public double Cintura { get; set; }
        public double Quadril { get; set; }
        public double BracoRelaxado { get; set; }
        public double BracoContraido { get; set; }
        public double Antebraco { get; set; }
        public double CoxaSuperior { get; set; }
        public double CoxaMedia { get; set; }
        public double CoxaInferior { get; set; }
        public double Perna { get; set; }
    }
}
