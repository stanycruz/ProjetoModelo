using System;

namespace ProjetoModelo.WebUI.Models
{
    public class WorkoutSheet
    {
        public int StudentId { get; set; }
        public DateTime DateTime { get; set; }
        public string Coach { get; set; }
        public string WorkoutA { get; set; }
        public DateTime DayA { get; set; }
        public string WorkoutB { get; set; }
        public DateTime DayB { get; set; }
        public string WorkoutC { get; set; }
        public DateTime DayC { get; set; }
        public string WorkoutD { get; set; }
        public DateTime DayD { get; set; }
        public string WorkoutE { get; set; }
        public DateTime DayE { get; set; }
        public string WorkoutF { get; set; }
        public DateTime DayF { get; set; }
    }
}
