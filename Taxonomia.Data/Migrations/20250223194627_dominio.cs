using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxonomia.Data.Migrations
{
    /// <inheritdoc />
    public partial class dominio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DominioId",
                table: "Reino",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Dominio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dominio", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reino_DominioId",
                table: "Reino",
                column: "DominioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reino_Dominio_DominioId",
                table: "Reino",
                column: "DominioId",
                principalTable: "Dominio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reino_Dominio_DominioId",
                table: "Reino");

            migrationBuilder.DropTable(
                name: "Dominio");

            migrationBuilder.DropIndex(
                name: "IX_Reino_DominioId",
                table: "Reino");

            migrationBuilder.DropColumn(
                name: "DominioId",
                table: "Reino");
        }
    }
}
