using System;
using System.Collections.Generic;

namespace ProjetoModelo.WebUI.Models
{
    /// <summary>
    /// Entidade Avaliação Física.
    /// </summary>
    public class PhysicalEvaluation
    {
        /// <summary>
        /// Id aluno.
        /// </summary>
        public long StudentId { get; set; }
        /// <summary>
        /// Avaliador.
        /// </summary>
        public string Valuer { get; set; }
        /// <summary>
        /// Data.
        /// </summary>
        public DateTime DateTime { get; set; }
        /// <summary>
        /// Frequência cardíaca.
        /// </summary>
        public int HeartRate { get; set; }
        /// <summary>
        /// Peso.
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Altura.
        /// </summary>
        public double Height { get; set; }
        /// <summary>
        /// Abdome.
        /// </summary>
        public int Abdominal { get; set; }
        /// <summary>
        /// Flexão de braços.
        /// </summary>
        public int FlexionArms { get; set; }
        /// <summary>
        /// Antopométrica.
        /// </summary>
        public IList<Anthropometric> Anthropometrics { get; set; }
        /// <summary>
        /// Dobra cutânea.
        /// </summary>
        public IList<SkinFold> SkinFolds { get; set; }
        /// <summary>
        /// Diâmetro.
        /// </summary>
        public IList<Diameter> Diameters { get; set; }
        /// <summary>
        /// Circunferência.
        /// </summary>
        public IList<Circumference> Circumferences { get; set; }

        /// <summary>
        /// Avaliação Física.
        /// </summary>
        public PhysicalEvaluation()
        {
            Anthropometrics = new List<Anthropometric>();
            SkinFolds = new List<SkinFold>();
            Diameters = new List<Diameter>();
            Circumferences = new List<Circumference>();
        }
    }
}
