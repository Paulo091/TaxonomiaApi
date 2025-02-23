using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxonomia.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reino",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reino", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReinoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filo_Reino_ReinoId",
                        column: x => x.ReinoId,
                        principalTable: "Reino",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FiloId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classe_Filo_FiloId",
                        column: x => x.FiloId,
                        principalTable: "Filo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ordem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClasseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ordem_Classe_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Familia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrdemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Familia_Ordem_OrdemId",
                        column: x => x.OrdemId,
                        principalTable: "Ordem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamiliaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genero_Familia_FamiliaId",
                        column: x => x.FamiliaId,
                        principalTable: "Familia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Especie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Especie_Genero_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organismo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCientifico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeComum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EspecieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organismo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organismo_Especie_EspecieId",
                        column: x => x.EspecieId,
                        principalTable: "Especie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classe_FiloId",
                table: "Classe",
                column: "FiloId");

            migrationBuilder.CreateIndex(
                name: "IX_Especie_GeneroId",
                table: "Especie",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Familia_OrdemId",
                table: "Familia",
                column: "OrdemId");

            migrationBuilder.CreateIndex(
                name: "IX_Filo_ReinoId",
                table: "Filo",
                column: "ReinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Genero_FamiliaId",
                table: "Genero",
                column: "FamiliaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ordem_ClasseId",
                table: "Ordem",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Organismo_EspecieId",
                table: "Organismo",
                column: "EspecieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Organismo");

            migrationBuilder.DropTable(
                name: "Especie");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Familia");

            migrationBuilder.DropTable(
                name: "Ordem");

            migrationBuilder.DropTable(
                name: "Classe");

            migrationBuilder.DropTable(
                name: "Filo");

            migrationBuilder.DropTable(
                name: "Reino");
        }
    }
}
