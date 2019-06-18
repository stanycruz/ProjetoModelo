namespace ProjetoModelo.WebUI.Models
{
    /// <summary>
    /// Entidade Antopométrica.
    /// </summary>
    public class Anthropometric
    {
        /// <summary>
        /// Id antopomética.
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Pescoço.
        /// </summary>
        public double Neck { get; set; }
        /// <summary>
        /// Torácico.
        /// </summary>
        public double Thoracic { get; set; }
        /// <summary>
        /// Cintura.
        /// </summary>
        public double Waist { get; set; }
        /// <summary>
        /// Quadril.
        /// </summary>
        public double Hip { get; set; }
        /// <summary>
        /// Braço relaxado.
        /// </summary>
        public double RelaxedArm { get; set; }
        /// <summary>
        /// Braço contraído.
        /// </summary>
        public double ContractedArm { get; set; }
        /// <summary>
        /// Antebraço.
        /// </summary>
        public double Forearm { get; set; }
        /// <summary>
        /// Coxa superior.
        /// </summary>
        public double UpperThigh { get; set; }
        /// <summary>
        /// Coxa média.
        /// </summary>
        public double AverageThigh { get; set; }
        /// <summary>
        /// Coxa inferior.
        /// </summary>
        public double LowerThigh { get; set; }
        /// <summary>
        /// Perna.
        /// </summary>
        public double Leg { get; set; }
        /// <summary>
        /// Id avaliação física.
        /// </summary>
        public PhysicalEvaluation PhysicalEvaluationId { get; set; }
    }
}
