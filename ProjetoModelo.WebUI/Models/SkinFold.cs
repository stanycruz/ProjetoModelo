namespace ProjetoModelo.WebUI.Models
{
    /// <summary>
    /// Entidade Dobra Cutânea.
    /// </summary>
    public class SkinFold
    {
        /// <summary>
        /// Id dobra cutânea.
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Subescapular.
        /// </summary>
        public double Subescapular { get; set; }
        /// <summary>
        /// Tríceps
        /// </summary>
        public double Triceps { get; set; }
        /// <summary>
        /// Bíceps.
        /// </summary>
        public double Biceps { get; set; }
        /// <summary>
        /// Peitoral.
        /// </summary>
        public double Breastplate { get; set; }
        /// <summary>
        /// Axilar média oblíqua.
        /// </summary>
        public double AxillaryMeanOblique { get; set; }
        /// <summary>
        /// Axilar média vertical.
        /// </summary>
        public double AxillaryMeanVertical { get; set; }
        /// <summary>
        /// Abdominal vertical.
        /// </summary>
        public double VerticalAbdominal { get; set; }
        /// <summary>
        /// Abdominal horizontal.
        /// </summary>
        public double HorizontalAbdominal { get; set; }
        /// <summary>
        /// Supra ilíaca oblíqua.
        /// </summary>
        public double SupraIliacOblique { get; set; }
        /// <summary>
        /// Supra ilíaca vertical.
        /// </summary>
        public double SupraIliacVertical { get; set; }
        /// <summary>
        /// Supra espinhal.
        /// </summary>
        public double SupraSpinal { get; set; }
        /// <summary>
        /// Coxa.
        /// </summary>
        public double Thigh { get; set; }
        /// <summary>
        /// Avaliação física.
        /// </summary>
        public PhysicalEvaluation PhysicalEvaluationId { get; set; }
    }
}
