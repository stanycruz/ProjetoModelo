using System;
using System.Collections.Generic;

namespace ProjetoModelo.WebUI.Models
{
    public class PhysicalEvaluation
    {
        public long StudentId { get; set; }
        public string Valuer { get; set; }
        public DateTime DateTime { get; set; }
        public int HeartRate { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Abdominal { get; set; }
        public int FlexionArms { get; set; }
        public IList<Anthropometric> Anthropometrics { get; set; }
        public IList<SkinFold> SkinFolds { get; set; }
        public IList<Diameter> Diameters { get; set; }
        public IList<Circumference> Circumferences { get; set; }

        public PhysicalEvaluation()
        {
            Anthropometrics = new List<Anthropometric>();
            SkinFolds = new List<SkinFold>();
            Diameters = new List<Diameter>();
            Circumferences = new List<Circumference>();
        }
    }
}
