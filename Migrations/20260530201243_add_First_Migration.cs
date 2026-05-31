using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dodoEF.Migrations
{
    /// <inheritdoc />
    public partial class add_First_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tovar_Ingr_ingrId",
                table: "Tovar");

            migrationBuilder.DropTable(
                name: "OderPlateg");

            migrationBuilder.DropIndex(
                name: "IX_Tovar_ingrId",
                table: "Tovar");

            migrationBuilder.DropColumn(
                name: "ingrId",
                table: "Tovar");

            migrationBuilder.AddColumn<int>(
                name: "plategid",
                table: "Oder",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tovarid",
                table: "Ingr",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Oder_plategid",
                table: "Oder",
                column: "plategid");

            migrationBuilder.CreateIndex(
                name: "IX_Ingr_tovarid",
                table: "Ingr",
                column: "tovarid");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingr_Tovar_tovarid",
                table: "Ingr",
                column: "tovarid",
                principalTable: "Tovar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Oder_Plateg_plategid",
                table: "Oder",
                column: "plategid",
                principalTable: "Plateg",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingr_Tovar_tovarid",
                table: "Ingr");

            migrationBuilder.DropForeignKey(
                name: "FK_Oder_Plateg_plategid",
                table: "Oder");

            migrationBuilder.DropIndex(
                name: "IX_Oder_plategid",
                table: "Oder");

            migrationBuilder.DropIndex(
                name: "IX_Ingr_tovarid",
                table: "Ingr");

            migrationBuilder.DropColumn(
                name: "plategid",
                table: "Oder");

            migrationBuilder.DropColumn(
                name: "tovarid",
                table: "Ingr");

            migrationBuilder.AddColumn<int>(
                name: "ingrId",
                table: "Tovar",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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
                name: "IX_Tovar_ingrId",
                table: "Tovar",
                column: "ingrId");

            migrationBuilder.CreateIndex(
                name: "IX_OderPlateg_plategsId",
                table: "OderPlateg",
                column: "plategsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tovar_Ingr_ingrId",
                table: "Tovar",
                column: "ingrId",
                principalTable: "Ingr",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
