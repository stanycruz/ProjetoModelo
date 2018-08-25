using System;

namespace ProjetoModelo.WebUI.Models
{
    public class Registration
    {
        public long StudentId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string Plan { get; set; }
        public DateTime DueDate { get; set; }
        public double Discount { get; set; }
        public string Situation { get; set; }
        public DateTime EndDate { get; set; }
        public Modality Modality { get; set; }
        public Payment Payment { get; set; }
    }
}
