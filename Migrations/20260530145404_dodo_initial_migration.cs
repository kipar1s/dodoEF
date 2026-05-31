using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dodoEF.Migrations
{
    /// <inheritdoc />
    public partial class dodo_initial_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    Tatle = table.Column<string>(type: "longchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "longchar", nullable: false),
                    Telefon = table.Column<int>(type: "integer", nullable: false),
                    Adress_C = table.Column<string>(type: "longchar", nullable: false),
                    Login = table.Column<string>(type: "longchar", nullable: false),
                    Password = table.Column<string>(type: "longchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "longchar", nullable: false),
                    Cost = table.Column<int>(type: "integer", nullable: false),
                    date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingr", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbPersonal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "longchar", nullable: false),
                    Stage = table.Column<int>(type: "integer", nullable: false),
                    Login = table.Column<string>(type: "longchar", nullable: false),
                    Password = table.Column<string>(type: "longchar", nullable: false),
                    categoriId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbPersonal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DbPersonal_Categori_categoriId",
                        column: x => x.categoriId,
                        principalTable: "Categori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tovar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    ingrId = table.Column<int>(type: "integer", nullable: false),
                    FullName = table.Column<string>(type: "longchar", nullable: false),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    Catifori_T = table.Column<string>(type: "longchar", nullable: false),
                    Callory = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tovar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tovar_Ingr_ingrId",
                        column: x => x.ingrId,
                        principalTable: "Ingr",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evelobilitile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    Pizziria = table.Column<int>(type: "integer", nullable: false),
                    personalId = table.Column<int>(type: "integer", nullable: false),
                    FullName_P = table.Column<string>(type: "longchar", nullable: false),
                    Reit_K_D = table.Column<int>(type: "integer", nullable: false),
                    Enum_Oder = table.Column<string>(type: "longchar", nullable: false),
                    Enum_Evel = table.Column<string>(type: "longchar", nullable: false),
                    Procent = table.Column<string>(type: "longchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evelobilitile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evelobilitile_DbPersonal_personalId",
                        column: x => x.personalId,
                        principalTable: "DbPersonal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Oder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    clientId = table.Column<int>(type: "integer", nullable: false),
                    date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Summa = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<string>(type: "longchar", nullable: false),
                    Adress_d = table.Column<string>(type: "longchar", nullable: false),
                    PersonalId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oder_Client_clientId",
                        column: x => x.clientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Oder_DbPersonal_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "DbPersonal",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateTable(
                name: "Plateg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    oderid = table.Column<int>(type: "integer", nullable: false),
                    Status_PL = table.Column<string>(type: "longchar", nullable: false),
                    Sposob_PL = table.Column<string>(type: "longchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plateg", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plateg_Oder_oderid",
                        column: x => x.oderid,
                        principalTable: "Oder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DbPersonal_categoriId",
                table: "DbPersonal",
                column: "categoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Evelobilitile_personalId",
                table: "Evelobilitile",
                column: "personalId");

            migrationBuilder.CreateIndex(
                name: "IX_Oder_clientId",
                table: "Oder",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "IX_Oder_PersonalId",
                table: "Oder",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_OderTovar_tovarsId",
                table: "OderTovar",
                column: "tovarsId");

            migrationBuilder.CreateIndex(
                name: "IX_Plateg_oderid",
                table: "Plateg",
                column: "oderid");

            migrationBuilder.CreateIndex(
                name: "IX_Tovar_ingrId",
                table: "Tovar",
                column: "ingrId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evelobilitile");

            migrationBuilder.DropTable(
                name: "OderTovar");

            migrationBuilder.DropTable(
                name: "Plateg");

            migrationBuilder.DropTable(
                name: "Tovar");

            migrationBuilder.DropTable(
                name: "Oder");

            migrationBuilder.DropTable(
                name: "Ingr");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "DbPersonal");

            migrationBuilder.DropTable(
                name: "Categori");
        }
    }
}
