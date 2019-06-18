using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoModelo.WebUI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ficha_treino",
                columns: table => new
                {
                    aluno_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    data = table.Column<DateTime>(type: "datetime", nullable: false),
                    professor = table.Column<string>(type: "varchar(50)", nullable: true),
                    treino_a = table.Column<string>(nullable: true),
                    dia_a = table.Column<DateTime>(type: "datetime", nullable: false),
                    treino_b = table.Column<string>(nullable: true),
                    dia_b = table.Column<DateTime>(type: "datetime", nullable: false),
                    treino_c = table.Column<string>(nullable: true),
                    dia_c = table.Column<DateTime>(type: "datetime", nullable: false),
                    treino_d = table.Column<string>(nullable: true),
                    dia_d = table.Column<DateTime>(type: "datetime", nullable: false),
                    treino_e = table.Column<string>(nullable: true),
                    dia_e = table.Column<DateTime>(type: "datetime", nullable: false),
                    treino_f = table.Column<string>(nullable: true),
                    dia_f = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ficha_treino", x => x.aluno_id);
                });

            migrationBuilder.CreateTable(
                name: "modalidade",
                columns: table => new
                {
                    matricula_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    descricao = table.Column<string>(type: "varchar(50)", nullable: false),
                    valor = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modalidade", x => x.matricula_id);
                });

            migrationBuilder.CreateTable(
                name: "aluno",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    data_cadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    endereco = table.Column<string>(type: "varchar(50)", nullable: false),
                    bairro = table.Column<string>(type: "varchar(50)", nullable: false),
                    cep = table.Column<string>(type: "varchar(8)", nullable: false),
                    cidade = table.Column<string>(type: "varchar(50)", nullable: true),
                    uf = table.Column<string>(type: "varchar(2)", nullable: false),
                    fone1 = table.Column<string>(type: "varchar(50)", nullable: false),
                    fone2 = table.Column<string>(type: "varchar(50)", nullable: true),
                    genero = table.Column<string>(type: "char(1)", nullable: false),
                    cpf = table.Column<string>(type: "varchar(11)", nullable: false),
                    rg = table.Column<string>(type: "varchar(20)", nullable: false),
                    data_nascimento = table.Column<DateTime>(type: "date", nullable: false),
                    idade = table.Column<int>(nullable: false),
                    email = table.Column<string>(type: "varchar(50)", nullable: false),
                    estado_civil = table.Column<string>(type: "varchar(10)", nullable: false),
                    profissao = table.Column<string>(type: "varchar(50)", nullable: false),
                    objetivo = table.Column<string>(nullable: true),
                    matriculado = table.Column<bool>(nullable: false),
                    pagamento = table.Column<decimal>(type: "money", nullable: false),
                    WorkoutSheetStudentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aluno", x => x.id);
                    table.ForeignKey(
                        name: "FK_aluno_ficha_treino_WorkoutSheetStudentId",
                        column: x => x.WorkoutSheetStudentId,
                        principalTable: "ficha_treino",
                        principalColumn: "aluno_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "avaliacao_fisica",
                columns: table => new
                {
                    aluno_id = table.Column<long>(nullable: false),
                    avaliador = table.Column<string>(type: "varchar(50)", nullable: false),
                    data = table.Column<DateTime>(type: "datetime", nullable: false),
                    frequencia_cardiaca = table.Column<int>(nullable: false),
                    peso = table.Column<double>(nullable: false),
                    altura = table.Column<double>(nullable: false),
                    abdominal = table.Column<int>(nullable: false),
                    flexao_bracos = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_avaliacao_fisica", x => x.aluno_id);
                    table.ForeignKey(
                        name: "FK_avaliacao_fisica_aluno_aluno_id",
                        column: x => x.aluno_id,
                        principalTable: "aluno",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "frequencia",
                columns: table => new
                {
                    aluno_id = table.Column<long>(nullable: false),
                    data_entrada = table.Column<DateTime>(type: "datetime", nullable: false),
                    data_saida = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_frequencia", x => x.aluno_id);
                    table.ForeignKey(
                        name: "FK_frequencia_aluno_aluno_id",
                        column: x => x.aluno_id,
                        principalTable: "aluno",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "matricula",
                columns: table => new
                {
                    aluno_id = table.Column<long>(nullable: false),
                    data_vigencia = table.Column<DateTime>(type: "datetime", nullable: false),
                    plano = table.Column<string>(nullable: true),
                    data_vencimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    desconto = table.Column<double>(nullable: false),
                    valor_final = table.Column<double>(nullable: false),
                    situacao = table.Column<string>(type: "varchar(20)", nullable: true),
                    data_fim = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModalityRegistrationId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_matricula", x => x.aluno_id);
                    table.ForeignKey(
                        name: "FK_matricula_modalidade_ModalityRegistrationId",
                        column: x => x.ModalityRegistrationId,
                        principalTable: "modalidade",
                        principalColumn: "matricula_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_matricula_aluno_aluno_id",
                        column: x => x.aluno_id,
                        principalTable: "aluno",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "antopometrica",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    pescoco = table.Column<double>(nullable: false),
                    toracica = table.Column<double>(nullable: false),
                    cintura = table.Column<double>(nullable: false),
                    quadril = table.Column<double>(nullable: false),
                    braco_relaxado = table.Column<double>(nullable: false),
                    braco_contraido = table.Column<double>(nullable: false),
                    antebraco = table.Column<double>(nullable: false),
                    coxa_superior = table.Column<double>(nullable: false),
                    coxa_media = table.Column<double>(nullable: false),
                    coxa_inferior = table.Column<double>(nullable: false),
                    perna = table.Column<double>(nullable: false),
                    avaliacao_fisica_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_antopometrica", x => x.id);
                    table.ForeignKey(
                        name: "FK_antopometrica_avaliacao_fisica_avaliacao_fisica_id",
                        column: x => x.avaliacao_fisica_id,
                        principalTable: "avaliacao_fisica",
                        principalColumn: "aluno_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "circunferencia",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    glutea = table.Column<double>(nullable: false),
                    panturrilha = table.Column<double>(nullable: false),
                    maleoar = table.Column<double>(nullable: false),
                    troncoIM = table.Column<double>(nullable: false),
                    troncoEM = table.Column<double>(nullable: false),
                    avaliacao_fisica_id = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_circunferencia", x => x.id);
                    table.ForeignKey(
                        name: "FK_circunferencia_avaliacao_fisica_avaliacao_fisica_id",
                        column: x => x.avaliacao_fisica_id,
                        principalTable: "avaliacao_fisica",
                        principalColumn: "aluno_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "diametro",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    radio_ulnar = table.Column<double>(nullable: false),
                    umeral = table.Column<double>(nullable: false),
                    biacromial = table.Column<double>(nullable: false),
                    toracico_transversal = table.Column<double>(nullable: false),
                    toracico_anterior = table.Column<double>(nullable: false),
                    toracico_posterior = table.Column<double>(nullable: false),
                    bicristal = table.Column<double>(nullable: false),
                    bitrocanteriano = table.Column<double>(nullable: false),
                    femular = table.Column<double>(nullable: false),
                    maleolar = table.Column<double>(nullable: false),
                    avaliacao_fisica_id = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diametro", x => x.id);
                    table.ForeignKey(
                        name: "FK_diametro_avaliacao_fisica_avaliacao_fisica_id",
                        column: x => x.avaliacao_fisica_id,
                        principalTable: "avaliacao_fisica",
                        principalColumn: "aluno_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "dobra_cutanea",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    subescapular = table.Column<double>(nullable: false),
                    triceps = table.Column<double>(nullable: false),
                    biceps = table.Column<double>(nullable: false),
                    peitoral = table.Column<double>(nullable: false),
                    axilar_media_obliqua = table.Column<double>(nullable: false),
                    axilar_media_vertical = table.Column<double>(nullable: false),
                    abdominal_vertical = table.Column<double>(nullable: false),
                    abdominal_horizontal = table.Column<double>(nullable: false),
                    supra_iliaca_obliqua = table.Column<double>(nullable: false),
                    supra_iliaca_vertical = table.Column<double>(nullable: false),
                    supra_espinhal = table.Column<double>(nullable: false),
                    coxa = table.Column<double>(nullable: false),
                    avaliacao_fisica_id = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dobra_cutanea", x => x.id);
                    table.ForeignKey(
                        name: "FK_dobra_cutanea_avaliacao_fisica_avaliacao_fisica_id",
                        column: x => x.avaliacao_fisica_id,
                        principalTable: "avaliacao_fisica",
                        principalColumn: "aluno_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "pagamento",
                columns: table => new
                {
                    matricula_id = table.Column<long>(nullable: false),
                    valor = table.Column<decimal>(type: "money", nullable: false),
                    data_pagamento = table.Column<DateTime>(type: "datetime", nullable: false),
                    forma_pagamento = table.Column<string>(type: "varchar(20)", nullable: false),
                    valor_pago = table.Column<decimal>(type: "money", nullable: false),
                    historico = table.Column<string>(nullable: true),
                    periodo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pagamento", x => x.matricula_id);
                    table.ForeignKey(
                        name: "FK_pagamento_matricula_matricula_id",
                        column: x => x.matricula_id,
                        principalTable: "matricula",
                        principalColumn: "aluno_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_aluno_WorkoutSheetStudentId",
                table: "aluno",
                column: "WorkoutSheetStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_antopometrica_avaliacao_fisica_id",
                table: "antopometrica",
                column: "avaliacao_fisica_id");

            migrationBuilder.CreateIndex(
                name: "IX_circunferencia_avaliacao_fisica_id",
                table: "circunferencia",
                column: "avaliacao_fisica_id");

            migrationBuilder.CreateIndex(
                name: "IX_diametro_avaliacao_fisica_id",
                table: "diametro",
                column: "avaliacao_fisica_id");

            migrationBuilder.CreateIndex(
                name: "IX_dobra_cutanea_avaliacao_fisica_id",
                table: "dobra_cutanea",
                column: "avaliacao_fisica_id");

            migrationBuilder.CreateIndex(
                name: "IX_matricula_ModalityRegistrationId",
                table: "matricula",
                column: "ModalityRegistrationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "antopometrica");

            migrationBuilder.DropTable(
                name: "circunferencia");

            migrationBuilder.DropTable(
                name: "diametro");

            migrationBuilder.DropTable(
                name: "dobra_cutanea");

            migrationBuilder.DropTable(
                name: "frequencia");

            migrationBuilder.DropTable(
                name: "pagamento");

            migrationBuilder.DropTable(
                name: "avaliacao_fisica");

            migrationBuilder.DropTable(
                name: "matricula");

            migrationBuilder.DropTable(
                name: "modalidade");

            migrationBuilder.DropTable(
                name: "aluno");

            migrationBuilder.DropTable(
                name: "ficha_treino");
        }
    }
}
