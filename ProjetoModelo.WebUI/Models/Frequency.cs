using System;

namespace ProjetoModelo.WebUI.Models
{
    public class Frequency
    {
        public long StudentId { get; private set; }
        public DateTime DateEntry { get; set; }
        public DateTime DepartureDate { get; set; }
    }
}
