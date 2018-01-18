namespace ProjetoModelo.Domain.Concrete.Sql
{
    public static class SqlAluno
    {
        public static string Aluno_Select = "SELECT * FROM Aluno";
        //public static string Aluno_Select_WithDetail = "SELECT * FROM Aluno AS A INNER JOIN AlunoDetail AS B ON A.AlunoID = B.AlunoID;";
        //public static string Aluno_Select_WithItem = "SELECT * FROM Aluno AS A INNER JOIN AlunoItem AS B ON A.AlunoID = B.AlunoID;";
        //public static string Aluno_Select_ByKind = "SELECT * FROM Aluno WHERE Kind IN @Kind;";
        //public static string Aluno_Select_ByCode = "SELECT * FROM Aluno WHERE Code = @Code;";
        public static string Aluno_Select_ByID = "SELECT * FROM Aluno WHERE Id = @Id";
        //public static string Aluno_Select_Then_Item_Select = "SELECT * FROM Aluno; SELECT * FROM AlunoItem;";

        public static string Aluno_Insert = "INSERT INTO Aluno " +
                                            "   (DataCadastro  " +
                                            "   ,Nome          " +
                                            "   ,Endereco      " +
                                            "   ,Bairro        " +
                                            "   ,Cep           " +
                                            "   ,Cidade        " +
                                            "   ,Uf            " +
                                            "   ,Fone1         " +
                                            "   ,Fone2         " +
                                            "   ,Sexo          " +
                                            "   ,Cpf           " +
                                            "   ,Rg            " +
                                            "   ,Nascimento    " +
                                            "   ,Idade         " +
                                            "   ,Email         " +
                                            "   ,EstadoCivil   " +
                                            "   ,Profissao     " +
                                            "   ,Empresa       " +
                                            "   ,Debito        " +
                                            "   ,Objetivo      " +
                                            "   ,Matriculado)  " +
                                            "VALUES            " +
                                            "   (@DataCadastro " +
                                            "   ,@Nome         " +
                                            "   ,@Endereco     " +
                                            "   ,@Bairro       " +
                                            "   ,@Cep          " +
                                            "   ,@Cidade       " +
                                            "   ,@Uf           " +
                                            "   ,@Fone1        " +
                                            "   ,@Fone2        " +
                                            "   ,@Sexo         " +
                                            "   ,@Cpf          " +
                                            "   ,@Rg           " +
                                            "   ,@Nascimento   " +
                                            "   ,@Idade        " +
                                            "   ,@Email        " +
                                            "   ,@EstadoCivil  " +
                                            "   ,@Profissao    " +
                                            "   ,@Empresa      " +
                                            "   ,@Debito       " +
                                            "   ,@Objetivo     " +
                                            "   ,@Matriculado) ";

        public static string Aluno_Update = "UPDATE Aluno						" +
                                            "   SET Nome = @Nome				" +
                                            "      ,Endereco = @Endereco		" +
                                            "      ,Bairro = @Bairro			" +
                                            "      ,Cep = @Cep					" +
                                            "      ,Cidade = @Cidade			" +
                                            "      ,Uf = @Uf					" +
                                            "      ,Fone1 = @Fone1				" +
                                            "      ,Fone2 = @Fone2				" +
                                            "      ,Sexo = @Sexo				" +
                                            "      ,Cpf = @Cpf					" +
                                            "      ,Rg = @Rg					" +
                                            "      ,Nascimento = @Nascimento	" +
                                            "      ,Idade = @Idade				" +
                                            "      ,Email = @Email				" +
                                            "      ,EstadoCivil = @EstadoCivil	" +
                                            "      ,Profissao = @Profissao		" +
                                            "      ,Empresa = @Empresa			" +
                                            "      ,Debito = @Debito			" +
                                            "      ,Objetivo = @Objetivo		" +
                                            "      ,Matriculado = @Matriculado	" +
                                            " WHERE Id = @Id					";

        public static string Aluno_Delete = "DELETE FROM Aluno WHERE Id = @Id";
        //public static string Proc_Aluno_Insert = "Aluno_Insert";
    }
}
