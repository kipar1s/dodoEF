using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dodoEF.Migrations
{
    /// <inheritdoc />
    public partial class cdacha_kur_06062026 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oder_DbPersonal_personalId",
                table: "Oder");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderTovars_Oder_OderId",
                table: "OrderTovars");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderTovars_Tovar_TovarId",
                table: "OrderTovars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderTovars",
                table: "OrderTovars");

            migrationBuilder.RenameTable(
                name: "OrderTovars",
                newName: "OderTovars");

            migrationBuilder.RenameIndex(
                name: "IX_OrderTovars_TovarId",
                table: "OderTovars",
                newName: "IX_OderTovars_TovarId");

            migrationBuilder.AlterColumn<int>(
                name: "personalId",
                table: "Oder",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "Num_Car",
                table: "DbPersonal",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Num_VY",
                table: "DbPersonal",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OderTovars",
                table: "OderTovars",
                columns: new[] { "OderId", "TovarId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Oder_DbPersonal_personalId",
                table: "Oder",
                column: "personalId",
                principalTable: "DbPersonal",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OderTovars_Oder_OderId",
                table: "OderTovars",
                column: "OderId",
                principalTable: "Oder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OderTovars_Tovar_TovarId",
                table: "OderTovars",
                column: "TovarId",
                principalTable: "Tovar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oder_DbPersonal_personalId",
                table: "Oder");

            migrationBuilder.DropForeignKey(
                name: "FK_OderTovars_Oder_OderId",
                table: "OderTovars");

            migrationBuilder.DropForeignKey(
                name: "FK_OderTovars_Tovar_TovarId",
                table: "OderTovars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OderTovars",
                table: "OderTovars");

            migrationBuilder.DropColumn(
                name: "Num_Car",
                table: "DbPersonal");

            migrationBuilder.DropColumn(
                name: "Num_VY",
                table: "DbPersonal");

            migrationBuilder.RenameTable(
                name: "OderTovars",
                newName: "OrderTovars");

            migrationBuilder.RenameIndex(
                name: "IX_OderTovars_TovarId",
                table: "OrderTovars",
                newName: "IX_OrderTovars_TovarId");

            migrationBuilder.AlterColumn<int>(
                name: "personalId",
                table: "Oder",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderTovars",
                table: "OrderTovars",
                columns: new[] { "OderId", "TovarId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Oder_DbPersonal_personalId",
                table: "Oder",
                column: "personalId",
                principalTable: "DbPersonal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderTovars_Oder_OderId",
                table: "OrderTovars",
                column: "OderId",
                principalTable: "Oder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderTovars_Tovar_TovarId",
                table: "OrderTovars",
                column: "TovarId",
                principalTable: "Tovar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
