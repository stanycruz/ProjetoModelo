using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.Domain.Entities
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Data/hora do cadastro")]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Informe o nome", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o endereço")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Informe o bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Informe o CEP")]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Informe a Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Informe a UF")]
        [Display(Name = "UF")]
        public string Uf { get; set; }

        [Display(Name = "Telefone celular")]
        public string Fone1 { get; set; }

        [Display(Name = "Telefone fixo")]
        public string Fone2 { get; set; }

        [Display(Name = "Gênero")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Informe o CPF")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Informe o RG")]
        [Display(Name = "RG")]
        public string Rg { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data nascimento")]
        public DateTime? Nascimento { get; set; }

        [Required(ErrorMessage = "Informe a idade")]
        public int? Idade { get; set; }

        [Required(ErrorMessage = "Informe o e-mail")]
        [RegularExpression("^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})$", ErrorMessage = "Informe um e-mail válido")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Estado civil")]
        public string EstadoCivil { get; set; }

        [Display(Name = "Profissão")]
        public string Profissao { get; set; }

        public string Empresa { get; set; }

        [Required(ErrorMessage = "Digite o valor cobrado")]
        [Display(Name = "Valor cobrado")]
        public decimal Debito { get; set; }

        public string Foto { get; set; }

        [Required(ErrorMessage = "Digite o objetivo")]
        public string Objetivo { get; set; }

        [Display(Name = "Está matriculado")]
        public string Matriculado { get; set; }

        [Display(Name = "Avaliação física")]
        public AvaliacaoFisica AvaliacaoFisica { get; set; }

        [Display(Name = "Freqüência")]
        public Frequencia Frequencia { get; set; }

        [Display(Name = "Ficha de treino")]
        public FichaTreino FichaTreino { get; set; }
    }
}
