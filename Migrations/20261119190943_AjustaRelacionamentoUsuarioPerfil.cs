using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeckGrain.Migrations
{
    /// <inheritdoc />
    public partial class AjustaRelacionamentoUsuarioPerfil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perfis_Usuarios_UsuarioId",
                table: "Perfis");
            migrationBuilder.DropIndex(
                name: "IX_Perfis_UsuarioId",
                table: "Perfis");

            migrationBuilder.CreateIndex(
                name: "IX_Perfis_UsuarioId",
                table: "Perfis",
                column: "UsuarioId",
                unique: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Perfis_Usuarios_UsuarioId",
                table: "Perfis",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Perfis_UsuarioId",
                table: "Perfis");

            migrationBuilder.CreateIndex(
                name: "IX_Perfis_UsuarioId",
                table: "Perfis",
                column: "UsuarioId");
        }
    }
}
