namespace ProjetoModelo.WebUI.Models
{
    public class SkinFold
    {
        public long Id { get; set; }
        public double Subescapular { get; set; }
        public double Triceps { get; set; }
        public double Biceps { get; set; }
        public double Breastplate { get; set; }
        public double AxillaryMeanOblique { get; set; }
        public double AxillaryMeanVertical { get; set; }
        public double VerticalAbdominal { get; set; }
        public double HorizontalAbdominal { get; set; }
        public double SupraIliacOblique { get; set; }
        public double SupraIliacVertical { get; set; }
        public double SupraSpinal { get; set; }
        public double Thigh { get; set; }
        public PhysicalEvaluation PhysicalEvaluationId { get; set; }
    }
}
