using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirmaERDCF.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Firmas",
                columns: table => new
                {
                    FirmaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirmaRegNr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lühinimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Koduleht = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kontaktisik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KontaktTel = table.Column<int>(type: "int", nullable: false),
                    KontaktEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmas", x => x.FirmaId);
                });

            migrationBuilder.CreateTable(
                name: "Harukontor",
                columns: table => new
                {
                    HaruKontoriId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HarukontoriRegNr = table.Column<int>(type: "int", nullable: false),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lühinimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Koduleht = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kontaktisik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KontaktTel = table.Column<int>(type: "int", nullable: false),
                    KontaktEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirmaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harukontor", x => x.HaruKontoriId);
                    table.ForeignKey(
                        name: "FK_Harukontor_Firmas_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmas",
                        principalColumn: "FirmaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Töötaja",
                columns: table => new
                {
                    TöötajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perenimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isikukood = table.Column<int>(type: "int", nullable: false),
                    KontaktAadress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KontaktTel = table.Column<int>(type: "int", nullable: false),
                    KontaktEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TöölAl = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TöölKuni = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HarukontoriId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Töötaja", x => x.TöötajaId);
                    table.ForeignKey(
                        name: "FK_Töötaja_Harukontor_HarukontoriId",
                        column: x => x.HarukontoriId,
                        principalTable: "Harukontor",
                        principalColumn: "HaruKontoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ametinimetused",
                columns: table => new
                {
                    AmetinimetuseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ametinimetus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmetisAl = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmetisKuni = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Osakond = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtseseÜlemuseEesnimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtseseÜlemusePerenimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtseseÜlemuseKontakttel = table.Column<int>(type: "int", nullable: false),
                    OtsesÜlemuseEpost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöötajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ametinimetused", x => x.AmetinimetuseId);
                    table.ForeignKey(
                        name: "FK_Ametinimetused_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "TöötajaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Haiguslehed",
                columns: table => new
                {
                    HaigusleheId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ÕigusHaiguslehele = table.Column<bool>(type: "bit", nullable: false),
                    HaiguspäeviKokku = table.Column<int>(type: "int", nullable: false),
                    HaigusleheAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HaigusleheLõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kasutatudhaigusepäevi = table.Column<int>(type: "int", nullable: false),
                    AllesolevaidHaigusepäevi = table.Column<int>(type: "int", nullable: false),
                    AegunudHaigusepäevi = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöötajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haiguslehed", x => x.HaigusleheId);
                    table.ForeignKey(
                        name: "FK_Haiguslehed_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "TöötajaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Laenutus",
                columns: table => new
                {
                    LaenutuseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EsemeNimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LaenutuseAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LaenutuseLõpp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöötajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laenutus", x => x.LaenutuseId);
                    table.ForeignKey(
                        name: "FK_Laenutus_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "TöötajaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lapsed",
                columns: table => new
                {
                    LapseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LapseEesnimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LapsePerenimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LapseSünniaeg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LapseVanus = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöötajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lapsed", x => x.LapseId);
                    table.ForeignKey(
                        name: "FK_Lapsed_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "TöötajaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ligipääsuload",
                columns: table => new
                {
                    LigipääsuloaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LigipääsuÕigus = table.Column<bool>(type: "bit", nullable: false),
                    LigipääsuTase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ligipääsuAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LigipääsuLõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöötajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ligipääsuload", x => x.LigipääsuloaId);
                    table.ForeignKey(
                        name: "FK_Ligipääsuload_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "TöötajaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Puhkused",
                columns: table => new
                {
                    PuhkuseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PuhkusePäevi = table.Column<int>(type: "int", nullable: false),
                    PuhkuseAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PuhkuseLõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KasutatudPäevad = table.Column<int>(type: "int", nullable: false),
                    AllesolevadPäevad = table.Column<int>(type: "int", nullable: false),
                    AegunudPuhkusePäevad = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöötajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puhkused", x => x.PuhkuseId);
                    table.ForeignKey(
                        name: "FK_Puhkused_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "TöötajaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tervisekontroll",
                columns: table => new
                {
                    TerviseKontrolliId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TerviseKontrolliVajadus = table.Column<bool>(type: "bit", nullable: false),
                    EelmiseTerviseKontrolliKp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UueTerviseKontrolliKp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöötajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tervisekontroll", x => x.TerviseKontrolliId);
                    table.ForeignKey(
                        name: "FK_Tervisekontroll_Töötaja_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Töötaja",
                        principalColumn: "TöötajaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ametinimetused_TöötajaId",
                table: "Ametinimetused",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Haiguslehed_TöötajaId",
                table: "Haiguslehed",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Harukontor_FirmaId",
                table: "Harukontor",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Laenutus_TöötajaId",
                table: "Laenutus",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Lapsed_TöötajaId",
                table: "Lapsed",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ligipääsuload_TöötajaId",
                table: "Ligipääsuload",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Puhkused_TöötajaId",
                table: "Puhkused",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tervisekontroll_TöötajaId",
                table: "Tervisekontroll",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Töötaja_HarukontoriId",
                table: "Töötaja",
                column: "HarukontoriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ametinimetused");

            migrationBuilder.DropTable(
                name: "Haiguslehed");

            migrationBuilder.DropTable(
                name: "Laenutus");

            migrationBuilder.DropTable(
                name: "Lapsed");

            migrationBuilder.DropTable(
                name: "Ligipääsuload");

            migrationBuilder.DropTable(
                name: "Puhkused");

            migrationBuilder.DropTable(
                name: "Tervisekontroll");

            migrationBuilder.DropTable(
                name: "Töötaja");

            migrationBuilder.DropTable(
                name: "Harukontor");

            migrationBuilder.DropTable(
                name: "Firmas");
        }
    }
}
