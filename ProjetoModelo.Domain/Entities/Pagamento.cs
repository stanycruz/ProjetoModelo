using System;

namespace ProjetoModelo.Domain.Entities
{
    public class Pagamento
    {
        public int Id { get; set; }
        public Matricula IdMatricula { get; set; }
        public double Valor { get; set; }
        public DateTime DataPgto { get; set; }
        public string FormaPgto { get; set; }
        public double ValorPgto { get; set; }
        public string Aluno { get; set; }
        public string Historico { get; set; }
        public string Periodo { get; set; }
    }
}
