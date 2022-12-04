using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstExerciseApi.Migrations
{
    /// <inheritdoc />
    public partial class AlunoKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Alunos_AlunoId",
                table: "Matriculas");

            migrationBuilder.DropIndex(
                name: "IX_Matriculas_AlunoId",
                table: "Matriculas");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Matriculas");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_IdAluno",
                table: "Matriculas",
                column: "IdAluno");

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Alunos_IdAluno",
                table: "Matriculas",
                column: "IdAluno",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Alunos_IdAluno",
                table: "Matriculas");

            migrationBuilder.DropIndex(
                name: "IX_Matriculas_IdAluno",
                table: "Matriculas");

            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "Matriculas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_AlunoId",
                table: "Matriculas",
                column: "AlunoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Alunos_AlunoId",
                table: "Matriculas",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
