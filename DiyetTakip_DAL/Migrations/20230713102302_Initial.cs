using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyetTakip_DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Fotograf = table.Column<string>(type: "nvarchar", nullable: true),
                    AktifMİ = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AdminMi = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Cinsiyet = table.Column<bool>(type: "bit", nullable: false),
                    Boy = table.Column<int>(type: "int", nullable: false),
                    Kilo = table.Column<double>(type: "float", nullable: false),
                    DiyetZorlukSeviyesi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HareketSeviyesi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeslenmeTercihi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    VucutKitleEndeksi = table.Column<double>(type: "float", nullable: false),
                    BazalMetobalizma = table.Column<double>(type: "float", nullable: false),
                    GunlukKaloriIhtiyaci = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.KullaniciID);
                });

            migrationBuilder.CreateTable(
                name: "Ogunler",
                columns: table => new
                {
                    OgunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AktifMİ = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogunler", x => x.OgunId);
                });

            migrationBuilder.CreateTable(
                name: "Yiyecekler",
                columns: table => new
                {
                    YiyecekID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    MiktarTuru = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Kalori = table.Column<double>(type: "float", nullable: false),
                    KarbonhidratMiktari = table.Column<double>(type: "float", nullable: false),
                    YagMiktari = table.Column<double>(type: "float", nullable: false),
                    ProteinMiktari = table.Column<double>(type: "float", nullable: false),
                    Fotograf = table.Column<string>(type: "nvarchar", nullable: true),
                    AktifMİ = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yiyecekler", x => x.YiyecekID);
                    table.ForeignKey(
                        name: "FK_Yiyecekler_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciYiyecekAlerjiler",
                columns: table => new
                {
                    KullaniciYiyecekAlerjiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciID = table.Column<int>(type: "int", nullable: false),
                    YiyecekID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciYiyecekAlerjiler", x => x.KullaniciYiyecekAlerjiID);
                    table.ForeignKey(
                        name: "FK_KullaniciYiyecekAlerjiler_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciYiyecekAlerjiler_Yiyecekler_YiyecekID",
                        column: x => x.YiyecekID,
                        principalTable: "Yiyecekler",
                        principalColumn: "YiyecekID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgunTakipleri",
                columns: table => new
                {
                    OgunTakibiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciID = table.Column<int>(type: "int", nullable: false),
                    OgunID = table.Column<int>(type: "int", nullable: false),
                    YiyecekID = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Miktar = table.Column<int>(type: "int", nullable: false),
                    UrunToplamKalori = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgunTakipleri", x => x.OgunTakibiID);
                    table.ForeignKey(
                        name: "FK_OgunTakipleri_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgunTakipleri_Ogunler_OgunID",
                        column: x => x.OgunID,
                        principalTable: "Ogunler",
                        principalColumn: "OgunId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgunTakipleri_Yiyecekler_YiyecekID",
                        column: x => x.YiyecekID,
                        principalTable: "Yiyecekler",
                        principalColumn: "YiyecekID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tarifler",
                columns: table => new
                {
                    TarifID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TarifDetayi = table.Column<string>(type: "nvarchar", nullable: true),
                    YiyecekID = table.Column<int>(type: "int", nullable: false),
                    HazirlamaSuresi = table.Column<int>(type: "int", nullable: false),
                    AktifMİ = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarifler", x => x.TarifID);
                    table.ForeignKey(
                        name: "FK_Tarifler_Yiyecekler_YiyecekID",
                        column: x => x.YiyecekID,
                        principalTable: "Yiyecekler",
                        principalColumn: "YiyecekID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "KullaniciID", "Ad", "AdminMi", "BazalMetobalizma", "BeslenmeTercihi", "Boy", "Cinsiyet", "DiyetZorlukSeviyesi", "DogumTarihi", "Email", "GunlukKaloriIhtiyaci", "HareketSeviyesi", "Kilo", "Sifre", "Soyad", "VucutKitleEndeksi" },
                values: new object[] { 1, "admin", true, 0.0, "", 1, true, "", new DateTime(1998, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1", 0.0, "", 0.0, "123", "1", 0.0 });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "KullaniciID", "Ad", "AdminMi", "BazalMetobalizma", "BeslenmeTercihi", "Boy", "Cinsiyet", "DiyetZorlukSeviyesi", "DogumTarihi", "Email", "GunlukKaloriIhtiyaci", "HareketSeviyesi", "Kilo", "Sifre", "Soyad", "VucutKitleEndeksi" },
                values: new object[] { 2, "admin", true, 0.0, "", 1, true, "", new DateTime(1998, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin2", 0.0, "", 0.0, "123", "2", 0.0 });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "KullaniciID", "Ad", "AdminMi", "BazalMetobalizma", "BeslenmeTercihi", "Boy", "Cinsiyet", "DiyetZorlukSeviyesi", "DogumTarihi", "Email", "GunlukKaloriIhtiyaci", "HareketSeviyesi", "Kilo", "Sifre", "Soyad", "VucutKitleEndeksi" },
                values: new object[] { 3, "admin", true, 0.0, "", 1, true, "", new DateTime(1998, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin3", 0.0, "", 0.0, "123", "3", 0.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_Email",
                table: "Kullanicilar",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciYiyecekAlerjiler_KullaniciID",
                table: "KullaniciYiyecekAlerjiler",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciYiyecekAlerjiler_YiyecekID",
                table: "KullaniciYiyecekAlerjiler",
                column: "YiyecekID");

            migrationBuilder.CreateIndex(
                name: "IX_OgunTakipleri_KullaniciID",
                table: "OgunTakipleri",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_OgunTakipleri_OgunID",
                table: "OgunTakipleri",
                column: "OgunID");

            migrationBuilder.CreateIndex(
                name: "IX_OgunTakipleri_YiyecekID",
                table: "OgunTakipleri",
                column: "YiyecekID");

            migrationBuilder.CreateIndex(
                name: "IX_Tarifler_YiyecekID",
                table: "Tarifler",
                column: "YiyecekID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Yiyecekler_KategoriID",
                table: "Yiyecekler",
                column: "KategoriID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KullaniciYiyecekAlerjiler");

            migrationBuilder.DropTable(
                name: "OgunTakipleri");

            migrationBuilder.DropTable(
                name: "Tarifler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Ogunler");

            migrationBuilder.DropTable(
                name: "Yiyecekler");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
