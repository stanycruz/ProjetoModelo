using ProjetoModelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoModelo.WebUI.Models
{
    public class AlunosListView
    {
        public IEnumerable<Aluno> Alunos { get; set; }
    }
}