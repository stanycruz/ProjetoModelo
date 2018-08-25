using System;

namespace ProjetoModelo.WebUI.Models
{
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Address { get; set; }
        public string Neighborhood { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Gender { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Identity { get; set; }
        public DateTime BornDate { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string MaritalStatus { get; set; }
        public string Profession { get; set; }
        public string Objective { get; set; }
        public bool Registered { get; set; }
        public decimal Payment { get; set; }
        public Registration Registration { get; set; }
        public PhysicalEvaluation PhysicalEvaluation { get; set; }
        public Frequency Frequency { get; set; }
        public WorkoutSheet WorkoutSheet { get; set; }
    }
}
