using System;

namespace ProjetoModelo.Domain.Entities
{
    public class FichaTreino
    {
        public int Id { get; private set; }
        public int IdAluno { get; set; }
        public string NomeAluno { get; set; }
        public DateTime Data { get; set; }
        public string Professor { get; set; }
        public string TreinoA { get; set; }
        public DateTime DiaA { get; set; }
        public string TreinoB { get; set; }
        public DateTime DiaB { get; set; }
        public string TreinoC { get; set; }
        public DateTime DiaC { get; set; }
        public string TreinoD { get; set; }
        public DateTime DiaD { get; set; }
        public string TreinoE { get; set; }
        public DateTime DiaE { get; set; }
        public string TreinoF { get; set; }
        public DateTime DiaF { get; set; }
    }
}
