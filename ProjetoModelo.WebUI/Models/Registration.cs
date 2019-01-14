using System;

namespace ProjetoModelo.WebUI.Models
{
    /// <summary>
    /// Entidade Matrícula.
    /// </summary>
    public class Registration
    {
        /// <summary>
        /// Id aluno.
        /// </summary>
        public long StudentId { get; set; }
        /// <summary>
        /// Data vingência.
        /// </summary>
        public DateTime EffectiveDate { get; set; }
        /// <summary>
        /// Plano.
        /// </summary>
        public string Plan { get; set; }
        /// <summary>
        /// Data vencimento.
        /// </summary>
        public DateTime DueDate { get; set; }
        /// <summary>
        /// Desconto.
        /// </summary>
        public double Discount { get; set; }
        /// <summary>
        /// Valor final.
        /// </summary>
        public double FinalValue { get; set; }
        /// <summary>
        /// Situação.
        /// </summary>
        public string Situation { get; set; }
        /// <summary>
        /// Data fim.
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// Modalidades.
        /// </summary>
        public Modality Modality { get; set; }
        /// <summary>
        /// Pagamento.
        /// </summary>
        public Payment Payment { get; set; }
    }
}
