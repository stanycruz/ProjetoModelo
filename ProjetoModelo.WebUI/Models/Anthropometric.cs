namespace ProjetoModelo.WebUI.Models
{
    public class Anthropometric
    {
        public long Id { get; set; }
        public double Neck { get; set; }
        public double Thoracic { get; set; }
        public double Waist { get; set; }
        public double Hip { get; set; }
        public double RelaxedArm { get; set; }
        public double ContractedArm { get; set; }
        public double Forearm { get; set; }
        public double UpperThigh { get; set; }
        public double AverageThigh { get; set; }
        public double MeanThigh { get; set; }
        public double LowerThigh { get; set; }
        public double Leg { get; set; }
        public PhysicalEvaluation PhysicalEvaluation { get; set; }
    }
}
