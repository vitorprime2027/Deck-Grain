using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeckGrain.Migrations
{
    /// <inheritdoc />
    public partial class CriandoRelacionamentosCompletos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_Usuarios_UsuarioId",
                table: "Comentarios");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Comentarios",
                newName: "PerfilId");

            migrationBuilder.RenameIndex(
                name: "IX_Comentarios_UsuarioId",
                table: "Comentarios",
                newName: "IX_Comentarios_PerfilId");

            migrationBuilder.AddColumn<int>(
                name: "PerfilId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PerfilId",
                table: "Notificacoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Configuracoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EtiquetaPost",
                columns: table => new
                {
                    EtiquetasId = table.Column<int>(type: "int", nullable: false),
                    PostsPostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtiquetaPost", x => new { x.EtiquetasId, x.PostsPostId });
                    table.ForeignKey(
                        name: "FK_EtiquetaPost_Etiquetas_EtiquetasId",
                        column: x => x.EtiquetasId,
                        principalTable: "Etiquetas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EtiquetaPost_Posts_PostsPostId",
                        column: x => x.PostsPostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PerfilId",
                table: "Posts",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Notificacoes_PerfilId",
                table: "Notificacoes",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Configuracoes_UsuarioId",
                table: "Configuracoes",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EtiquetaPost_PostsPostId",
                table: "EtiquetaPost",
                column: "PostsPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_Perfis_PerfilId",
                table: "Comentarios",
                column: "PerfilId",
                principalTable: "Perfis",
                principalColumn: "PerfilId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Configuracoes_Usuarios_UsuarioId",
                table: "Configuracoes",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notificacoes_Perfis_PerfilId",
                table: "Notificacoes",
                column: "PerfilId",
                principalTable: "Perfis",
                principalColumn: "PerfilId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Perfis_PerfilId",
                table: "Posts",
                column: "PerfilId",
                principalTable: "Perfis",
                principalColumn: "PerfilId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_Perfis_PerfilId",
                table: "Comentarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Configuracoes_Usuarios_UsuarioId",
                table: "Configuracoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Notificacoes_Perfis_PerfilId",
                table: "Notificacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Perfis_PerfilId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "EtiquetaPost");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PerfilId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Notificacoes_PerfilId",
                table: "Notificacoes");

            migrationBuilder.DropIndex(
                name: "IX_Configuracoes_UsuarioId",
                table: "Configuracoes");

            migrationBuilder.DropColumn(
                name: "PerfilId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PerfilId",
                table: "Notificacoes");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Configuracoes");

            migrationBuilder.RenameColumn(
                name: "PerfilId",
                table: "Comentarios",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Comentarios_PerfilId",
                table: "Comentarios",
                newName: "IX_Comentarios_UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_Usuarios_UsuarioId",
                table: "Comentarios",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
