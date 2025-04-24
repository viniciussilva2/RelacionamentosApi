using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RelacionamentoApi.Migrations
{
    /// <inheritdoc />
    public partial class casamorador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Moradores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moradores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CasaMorador",
                columns: table => new
                {
                    CasasId = table.Column<int>(type: "int", nullable: false),
                    MoradoresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CasaMorador", x => new { x.CasasId, x.MoradoresId });
                    table.ForeignKey(
                        name: "FK_CasaMorador_Casas_CasasId",
                        column: x => x.CasasId,
                        principalTable: "Casas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CasaMorador_Moradores_MoradoresId",
                        column: x => x.MoradoresId,
                        principalTable: "Moradores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CasaMorador_MoradoresId",
                table: "CasaMorador",
                column: "MoradoresId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CasaMorador");

            migrationBuilder.DropTable(
                name: "Moradores");
        }
    }
}
