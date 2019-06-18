using System;

namespace ProjetoModelo.WebUI.Models
{
    /// <summary>
    /// Entidade Pagamento.
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// Matrícula.
        /// </summary>
        public long RegistrationId { get; set; }
        /// <summary>
        /// Valor.
        /// </summary>
        public decimal Value { get; set; }
        /// <summary>
        /// Data pagamento.
        /// </summary>
        public DateTime Payday { get; set; }
        /// <summary>
        /// Forma pagamento.
        /// </summary>
        public string FormPayment { get; set; }
        /// <summary>
        /// Valor pago.
        /// </summary>
        public decimal PaymentAmount { get; set; }
        /// <summary>
        /// Histórico.
        /// </summary>
        public string Historic { get; set; }
        /// <summary>
        /// Período.
        /// </summary>
        public string Period { get; set; }
    }
}
