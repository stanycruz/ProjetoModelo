using System;

namespace ProjetoModelo.Domain.Entities
{
    public class Matricula
    {
        public int Id { get; private set; }
        public Aluno Aluno { get; set; }
        public DateTime DataVigencia { get; set; }
        public string Plano { get; set; }
        public DateTime DataVencimento { get; set; }
        public double Desconto { get; set; }
        public string Situacao { get; set; }
        public DateTime DataFim { get; set; }
        public Modalidade Modalidade { get; set; }
    }
}
