using System;

namespace ProjetoModelo.WebUI.Models
{
    /// <summary>
    /// Entidade Ficha Treino.
    /// </summary>
    public class WorkoutSheet
    {
        /// <summary>
        /// Id aluno.
        /// </summary>
        public int StudentId { get; set; }
        /// <summary>
        /// Data.
        /// </summary>
        public DateTime DateTime { get; set; }
        /// <summary>
        /// Treinador.
        /// </summary>
        public string Coach { get; set; }
        /// <summary>
        /// Treino A.
        /// </summary>
        public string WorkoutA { get; set; }
        /// <summary>
        /// Dia A.
        /// </summary>
        public DateTime DayA { get; set; }
        /// <summary>
        /// Treino B.
        /// </summary>
        public string WorkoutB { get; set; }
        /// <summary>
        /// Dia B.
        /// </summary>
        public DateTime DayB { get; set; }
        /// <summary>
        /// Treino C.
        /// </summary>
        public string WorkoutC { get; set; }
        /// <summary>
        /// Dia C.
        /// </summary>
        public DateTime DayC { get; set; }
        /// <summary>
        /// Treino D.
        /// </summary>
        public string WorkoutD { get; set; }
        /// <summary>
        /// Dia D.
        /// </summary>
        public DateTime DayD { get; set; }
        /// <summary>
        /// Treino E.
        /// </summary>
        public string WorkoutE { get; set; }
        /// <summary>
        /// Dia E.
        /// </summary>
        public DateTime DayE { get; set; }
        /// <summary>
        /// Treino F.
        /// </summary>
        public string WorkoutF { get; set; }
        /// <summary>
        /// Dia F.
        /// </summary>
        public DateTime DayF { get; set; }
    }
}
