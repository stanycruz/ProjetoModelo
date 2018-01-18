using System;

namespace ProjetoModelo.Domain.Entities
{
    public class Frequencia
    {
        public int Id { get; private set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public Aluno Aluno { get; set; }
    }
}
