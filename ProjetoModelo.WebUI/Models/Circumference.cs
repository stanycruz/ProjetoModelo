namespace ProjetoModelo.WebUI.Models
{
    /// <summary>
    /// Entidade Circunferêcia.
    /// </summary>
    public class Circumference
    {
        /// <summary>
        /// Id circunferência.
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Glútea.
        /// </summary>
        public double Gluteal { get; set; }
        /// <summary>
        /// Panturrilha.
        /// </summary>
        public double Calf { get; set; }
        /// <summary>
        /// Maleolar.
        /// </summary>
        public double Maleoar { get; set; }
        /// <summary>
        /// Tronco IM.
        /// </summary>
        public double IMTrunk { get; set; }
        /// <summary>
        /// Tronco EM.
        /// </summary>
        public double EMTrunk { get; set; }
        /// <summary>
        /// Id avaliação física.
        /// </summary>
        public PhysicalEvaluation PhysicalEvaluationId { get; set; }
    }
}
