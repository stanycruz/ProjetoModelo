namespace ProjetoModelo.Domain.Entities
{
    public class Diametro : AvaliacaoFisica
    {
        public int Id { get; private set; }
        public double RadioUlnar { get; set; }
        public double Umeral { get; set; }
        public double Biacromial { get; set; }
        public double ToracicoTransversal { get; set; }
        public double ToracicoAnterior { get; set; }
        public double ToraxicoPosterior { get; set; }
        public double Bicristal { get; set; }
        public double Bitrocanteriano { get; set; }
        public double Femular { get; set; }
        public double Maleolar { get; set; }
    }
}
