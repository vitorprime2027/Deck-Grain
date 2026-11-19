using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeckGrain.Migrations
{
    /// <inheritdoc />
    public partial class RelacionaUsuarioPerfil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuariosUsuarioId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_UsuariosUsuarioId",
                table: "Usuarios",
                column: "UsuariosUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Usuarios_UsuariosUsuarioId",
                table: "Usuarios",
                column: "UsuariosUsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Usuarios_UsuariosUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_UsuariosUsuarioId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "UsuariosUsuarioId",
                table: "Usuarios");
        }
    }
}
