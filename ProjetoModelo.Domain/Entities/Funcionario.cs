using System;

namespace ProjetoModelo.Domain.Entities
{
    public class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Fone1 { get; set; }
        public string Fone2 { get; set; }
        public string Sexo { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Cref { get; set; }
        public string Nascimento { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Funcao { get; set; }
        public DateTime DataAdmissao { get; set; }
        public double Salario { get; set; }
        public DateTime DataDemissao { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string NivelAcesso { get; set; }
    }
}
