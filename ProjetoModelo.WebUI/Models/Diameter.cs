namespace ProjetoModelo.WebUI.Models
{
    /// <summary>
    /// Entidade Diâmetro.
    /// </summary>
    public class Diameter
    {
        /// <summary>
        /// Id diâmetro.
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Rádio ulnar.
        /// </summary>
        public double RadioUlnar { get; set; }
        /// <summary>
        /// Umeral.
        /// </summary>
        public double Umeral { get; set; }
        /// <summary>
        /// Biacromial.
        /// </summary>
        public double Biacromial { get; set; }
        /// <summary>
        /// Torácico transversal.
        /// </summary>
        public double TransverseThoracic { get; set; }
        /// <summary>
        /// Torácico anterior.
        /// </summary>
        public double AnteriorThoracic { get; set; }
        /// <summary>
        /// Torácico anterior.
        /// </summary>
        public double PosteriorThoracic { get; set; }
        /// <summary>
        /// Bicristal.
        /// </summary>
        public double Bicristal { get; set; }
        /// <summary>
        /// Bitrocanteriano.
        /// </summary>
        public double Bitrocanterian { get; set; }
        /// <summary>
        /// Femular.
        /// </summary>
        public double Femular { get; set; }
        /// <summary>
        /// Maleolar.
        /// </summary>
        public double Maleolar { get; set; }
        /// <summary>
        /// Id avaliação física.
        /// </summary>
        public PhysicalEvaluation PhysicalEvaluationId { get; set; }
    }
}
