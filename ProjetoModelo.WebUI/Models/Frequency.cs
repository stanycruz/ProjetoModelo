using System;

namespace ProjetoModelo.WebUI.Models
{
    /// <summary>
    /// Entidade Frequência.
    /// </summary>
    public class Frequency
    {
        /// <summary>
        /// Id estudante.
        /// </summary>
        public long StudentId { get; private set; }
        /// <summary>
        /// Data entrada.
        /// </summary>
        public DateTime DateEntry { get; set; }
        /// <summary>
        /// Data saída.
        /// </summary>
        public DateTime DepartureDate { get; set; }
    }
}
