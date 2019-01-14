namespace ProjetoModelo.WebUI.Models
{
    /// <summary>
    /// Entidade Agenda Telefônica.
    /// </summary>
    public class PhoneBook
    {
        /// <summary>
        /// Id agenda telefônica.
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Descrição.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Telefone 1.
        /// </summary>
        public string Phone1 { get; set; }
        /// <summary>
        /// Telefone 2.
        /// </summary>
        public string Phone2 { get; set; }
    }
}
