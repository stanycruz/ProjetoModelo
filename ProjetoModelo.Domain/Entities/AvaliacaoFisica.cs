using System;

namespace ProjetoModelo.Domain.Entities
{
    public class AvaliacaoFisica
    {
        public int Id { get; private set; }
        public int IdAluno { get; set; }
        public int Avaliador { get; set; }
        public DateTime Data { get; set; }
        public int FrequenciaCardiaca { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public int Abdominal { get; set; }
        public int FlexaoBracos { get; set; }
        public Antopometrica Antopometrica { get; set; }
        public DobraCutanea DobraCutanea { get; set; }
        public Diametro Diametro { get; set; }
        public Circunferencia Circunferencia { get; set; }
    }
}
