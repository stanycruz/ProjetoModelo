using ProjetoModelo.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModelo.Domain.Abstract
{
    public interface IAlunoRepository
    {
        IEnumerable<Aluno> Alunos { get; }
        Aluno GetAluno(int id);
    }
}
