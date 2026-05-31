using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dodoEF.Migrations
{
    /// <inheritdoc />
    public partial class Lection_0805_isdone_Complited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evelobilitile_DbPersonal_personalId",
                table: "Evelobilitile");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingr_Tovar_tovarid",
                table: "Ingr");

            migrationBuilder.DropForeignKey(
                name: "FK_Oder_DbPersonal_PersonalId",
                table: "Oder");

            migrationBuilder.DropTable(
                name: "OderTovar");

            migrationBuilder.DropIndex(
                name: "IX_Oder_plategid",
                table: "Oder");

            migrationBuilder.DropIndex(
                name: "IX_Ingr_tovarid",
                table: "Ingr");

            migrationBuilder.DropIndex(
                name: "IX_Evelobilitile_personalId",
                table: "Evelobilitile");

            migrationBuilder.DropColumn(
                name: "tovarid",
                table: "Ingr");

            migrationBuilder.DropColumn(
                name: "personalId",
                table: "Evelobilitile");

            migrationBuilder.RenameColumn(
                name: "PersonalId",
                table: "Oder",
                newName: "personalId");

            migrationBuilder.RenameIndex(
                name: "IX_Oder_PersonalId",
                table: "Oder",
                newName: "IX_Oder_personalId");

            migrationBuilder.AlterColumn<int>(
                name: "personalId",
                table: "Oder",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "OrderTovars",
                columns: table => new
                {
                    OderId = table.Column<int>(type: "integer", nullable: false),
                    TovarId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTovars", x => new { x.OderId, x.TovarId });
                    table.ForeignKey(
                        name: "FK_OrderTovars_Oder_OderId",
                        column: x => x.OderId,
                        principalTable: "Oder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderTovars_Tovar_TovarId",
                        column: x => x.TovarId,
                        principalTable: "Tovar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalEvelobilitile",
                columns: table => new
                {
                    PersonalId = table.Column<int>(type: "integer", nullable: false),
                    EvelobilitileId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalEvelobilitile", x => new { x.PersonalId, x.EvelobilitileId });
                    table.ForeignKey(
                        name: "FK_PersonalEvelobilitile_DbPersonal_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "DbPersonal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalEvelobilitile_Evelobilitile_EvelobilitileId",
                        column: x => x.EvelobilitileId,
                        principalTable: "Evelobilitile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TovarIngrs",
                columns: table => new
                {
                    TovarId = table.Column<int>(type: "integer", nullable: false),
                    IngrId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TovarIngrs", x => new { x.TovarId, x.IngrId });
                    table.ForeignKey(
                        name: "FK_TovarIngrs_Ingr_IngrId",
                        column: x => x.IngrId,
                        principalTable: "Ingr",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TovarIngrs_Tovar_TovarId",
                        column: x => x.TovarId,
                        principalTable: "Tovar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Oder_plategid",
                table: "Oder",
                column: "plategid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderTovars_TovarId",
                table: "OrderTovars",
                column: "TovarId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalEvelobilitile_EvelobilitileId",
                table: "PersonalEvelobilitile",
                column: "EvelobilitileId");

            migrationBuilder.CreateIndex(
                name: "IX_TovarIngrs_IngrId",
                table: "TovarIngrs",
                column: "IngrId");

            migrationBuilder.AddForeignKey(
                name: "FK_Oder_DbPersonal_personalId",
                table: "Oder",
                column: "personalId",
                principalTable: "DbPersonal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oder_DbPersonal_personalId",
                table: "Oder");

            migrationBuilder.DropTable(
                name: "OrderTovars");

            migrationBuilder.DropTable(
                name: "PersonalEvelobilitile");

            migrationBuilder.DropTable(
                name: "TovarIngrs");

            migrationBuilder.DropIndex(
                name: "IX_Oder_plategid",
                table: "Oder");

            migrationBuilder.RenameColumn(
                name: "personalId",
                table: "Oder",
                newName: "PersonalId");

            migrationBuilder.RenameIndex(
                name: "IX_Oder_personalId",
                table: "Oder",
                newName: "IX_Oder_PersonalId");

            migrationBuilder.AlterColumn<int>(
                name: "PersonalId",
                table: "Oder",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "tovarid",
                table: "Ingr",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "personalId",
                table: "Evelobilitile",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OderTovar",
                columns: table => new
                {
                    odersId = table.Column<int>(type: "integer", nullable: false),
                    tovarsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OderTovar", x => new { x.odersId, x.tovarsId });
                    table.ForeignKey(
                        name: "FK_OderTovar_Oder_odersId",
                        column: x => x.odersId,
                        principalTable: "Oder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OderTovar_Tovar_tovarsId",
                        column: x => x.tovarsId,
                        principalTable: "Tovar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Oder_plategid",
                table: "Oder",
                column: "plategid");

            migrationBuilder.CreateIndex(
                name: "IX_Ingr_tovarid",
                table: "Ingr",
                column: "tovarid");

            migrationBuilder.CreateIndex(
                name: "IX_Evelobilitile_personalId",
                table: "Evelobilitile",
                column: "personalId");

            migrationBuilder.CreateIndex(
                name: "IX_OderTovar_tovarsId",
                table: "OderTovar",
                column: "tovarsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Evelobilitile_DbPersonal_personalId",
                table: "Evelobilitile",
                column: "personalId",
                principalTable: "DbPersonal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingr_Tovar_tovarid",
                table: "Ingr",
                column: "tovarid",
                principalTable: "Tovar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Oder_DbPersonal_PersonalId",
                table: "Oder",
                column: "PersonalId",
                principalTable: "DbPersonal",
                principalColumn: "Id");
        }
    }
}
