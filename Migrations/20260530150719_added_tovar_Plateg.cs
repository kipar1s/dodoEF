using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dodoEF.Migrations
{
    /// <inheritdoc />
    public partial class added_tovar_Plateg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plateg_Oder_oderid",
                table: "Plateg");

            migrationBuilder.DropIndex(
                name: "IX_Plateg_oderid",
                table: "Plateg");

            migrationBuilder.DropColumn(
                name: "oderid",
                table: "Plateg");

            migrationBuilder.CreateTable(
                name: "OderPlateg",
                columns: table => new
                {
                    odersId = table.Column<int>(type: "integer", nullable: false),
                    plategsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OderPlateg", x => new { x.odersId, x.plategsId });
                    table.ForeignKey(
                        name: "FK_OderPlateg_Oder_odersId",
                        column: x => x.odersId,
                        principalTable: "Oder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OderPlateg_Plateg_plategsId",
                        column: x => x.plategsId,
                        principalTable: "Plateg",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OderPlateg_plategsId",
                table: "OderPlateg",
                column: "plategsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OderPlateg");

            migrationBuilder.AddColumn<int>(
                name: "oderid",
                table: "Plateg",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Plateg_oderid",
                table: "Plateg",
                column: "oderid");

            migrationBuilder.AddForeignKey(
                name: "FK_Plateg_Oder_oderid",
                table: "Plateg",
                column: "oderid",
                principalTable: "Oder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
