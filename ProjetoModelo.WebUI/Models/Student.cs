using System;

namespace ProjetoModelo.WebUI.Models
{
    /// <summary>
    /// Entidade Aluno.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Id aluno.
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Nome.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Data cadastro.
        /// </summary>
        public DateTime RegistrationDate { get; set; }
        /// <summary>
        /// Endereço.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Bairro.
        /// </summary>
        public string Neighborhood { get; set; }
        /// <summary>
        /// CEP.
        /// </summary>
        public string ZipCode { get; set; }
        /// <summary>
        /// Cidade.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Estado.
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Telefone 1.
        /// </summary>
        public string Phone1 { get; set; }
        /// <summary>
        /// Telefone 2.
        /// </summary>
        public string Phone2 { get; set; }
        /// <summary>
        /// Sexo.
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// CPF.
        /// </summary>
        public string SocialSecurityNumber { get; set; }
        /// <summary>
        /// RG.
        /// </summary>
        public string Identity { get; set; }
        /// <summary>
        /// Data nascimento.
        /// </summary>
        public DateTime BornDate { get; set; }
        /// <summary>
        /// Idade.
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// E-mail.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Estado civil.
        /// </summary>
        public string MaritalStatus { get; set; }
        /// <summary>
        /// Profissão.
        /// </summary>
        public string Profession { get; set; }
        /// <summary>
        /// Objetivo.
        /// </summary>
        public string Objective { get; set; }
        /// <summary>
        /// Matriculado.
        /// </summary>
        public bool Registered { get; set; }
        /// <summary>
        /// Pagamento.
        /// </summary>
        public decimal Payment { get; set; }
        /// <summary>
        /// Matrícula.
        /// </summary>
        public Registration Registration { get; set; }
        /// <summary>
        /// Avaliação física.
        /// </summary>
        public PhysicalEvaluation PhysicalEvaluation { get; set; }
        /// <summary>
        /// Frequência.
        /// </summary>
        public Frequency Frequency { get; set; }
        /// <summary>
        /// Ficha treino.
        /// </summary>
        public WorkoutSheet WorkoutSheet { get; set; }
    }
}
