using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teknoroma.Entities.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Birimler",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BirimKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birimler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cariler",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CariHesapNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sehir = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Bakiye = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cariler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departmanlar",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DepartmanAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UstId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmanlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departmanlar_Departmanlar_UstId",
                        column: x => x.UstId,
                        principalTable: "Departmanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dovizler",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DovizKodu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DovizAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Kur = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dovizler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KategoriAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subeler",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubeAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sehir = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subeler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tedarikciler",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tedarikciler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Faturalar",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CariId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FaturaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToplamTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KDV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faturalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faturalar_Cariler_CariId",
                        column: x => x.CariId,
                        principalTable: "Cariler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Siparisler",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CariId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SiparisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Durum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CariId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparisler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Siparisler_Cariler_CariId",
                        column: x => x.CariId,
                        principalTable: "Cariler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Siparisler_Cariler_CariId1",
                        column: x => x.CariId1,
                        principalTable: "Cariler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Kasalar",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KasaKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubeKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DovizId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Bakiye = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kasalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kasalar_Dovizler_DovizId",
                        column: x => x.DovizId,
                        principalTable: "Dovizler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kurlar",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DovizId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KurTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlisKuru = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SatisKuru = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DovizId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kurlar_Dovizler_DovizId",
                        column: x => x.DovizId,
                        principalTable: "Dovizler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kurlar_Dovizler_DovizId1",
                        column: x => x.DovizId1,
                        principalTable: "Dovizler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Depolar",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DepoAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depolar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Depolar_Subeler_SubeId",
                        column: x => x.SubeId,
                        principalTable: "Subeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TcNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    DepartmanId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Cinsiyet = table.Column<bool>(type: "bit", nullable: true),
                    Gorev = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DepartmanId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personeller_Departmanlar_DepartmanId",
                        column: x => x.DepartmanId,
                        principalTable: "Departmanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personeller_Departmanlar_DepartmanId1",
                        column: x => x.DepartmanId1,
                        principalTable: "Departmanlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Personeller_Subeler_SubeId",
                        column: x => x.SubeId,
                        principalTable: "Subeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KasaHareketler",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KasaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DovizId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HareketTipi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Giris = table.Column<double>(type: "double", nullable: true),
                    Cikis = table.Column<double>(type: "double", nullable: true),
                    Tutar = table.Column<double>(type: "double", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KasaHareketler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KasaHareketler_Dovizler_DovizId",
                        column: x => x.DovizId,
                        principalTable: "Dovizler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KasaHareketler_Kasalar_KasaId",
                        column: x => x.KasaId,
                        principalTable: "Kasalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stoklar",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StokAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StokKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DepoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StokAdet = table.Column<int>(type: "int", nullable: false),
                    BirimId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BirimId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DepoId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    KategoriId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stoklar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stoklar_Birimler_BirimId",
                        column: x => x.BirimId,
                        principalTable: "Birimler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stoklar_Birimler_BirimId1",
                        column: x => x.BirimId1,
                        principalTable: "Birimler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stoklar_Depolar_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depolar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stoklar_Depolar_DepoId1",
                        column: x => x.DepoId1,
                        principalTable: "Depolar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stoklar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Satislar",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CariId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PersonelId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SatisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToplamTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CariId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satislar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Satislar_Cariler_CariId",
                        column: x => x.CariId,
                        principalTable: "Cariler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Satislar_Cariler_CariId1",
                        column: x => x.CariId1,
                        principalTable: "Cariler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Satislar_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Satislar_Subeler_SubeId",
                        column: x => x.SubeId,
                        principalTable: "Subeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FaturaDetaylar",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FaturaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StokId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Miktar = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaturaDetaylar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FaturaDetaylar_Faturalar_FaturaId",
                        column: x => x.FaturaId,
                        principalTable: "Faturalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FaturaDetaylar_Stoklar_StokId",
                        column: x => x.StokId,
                        principalTable: "Stoklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StokBarkodlar",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StokId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Barkod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StokBarkodlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StokBarkodlar_Stoklar_StokId",
                        column: x => x.StokId,
                        principalTable: "Stoklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StokFotograflar",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StokId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FotografYolu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StokFotograflar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StokFotograflar_Stoklar_StokId",
                        column: x => x.StokId,
                        principalTable: "Stoklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StokHareketler",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StokId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DepoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StokHareketler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StokHareketler_Depolar_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depolar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StokHareketler_Stoklar_StokId",
                        column: x => x.StokId,
                        principalTable: "Stoklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciYorumlari",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KullaniciId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StokId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    YorumMetni = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    YorumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciYorumlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciYorumlari_AspNetUsers_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciYorumlari_Stoklar_StokId",
                        column: x => x.StokId,
                        principalTable: "Stoklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SatisDetaylari",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SatisId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StokId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Miktar = table.Column<int>(type: "int", nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatisDetaylari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SatisDetaylari_Satislar_SatisId",
                        column: x => x.SatisId,
                        principalTable: "Satislar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SatisDetaylari_Stoklar_StokId",
                        column: x => x.StokId,
                        principalTable: "Stoklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PersonelId",
                table: "AspNetUsers",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Birimler_Id",
                table: "Birimler",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cariler_Id",
                table: "Cariler",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departmanlar_Id",
                table: "Departmanlar",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departmanlar_UstId",
                table: "Departmanlar",
                column: "UstId");

            migrationBuilder.CreateIndex(
                name: "IX_Depolar_Id",
                table: "Depolar",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Depolar_SubeId",
                table: "Depolar",
                column: "SubeId");

            migrationBuilder.CreateIndex(
                name: "IX_Dovizler_Id",
                table: "Dovizler",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FaturaDetaylar_FaturaId",
                table: "FaturaDetaylar",
                column: "FaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_FaturaDetaylar_Id",
                table: "FaturaDetaylar",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FaturaDetaylar_StokId",
                table: "FaturaDetaylar",
                column: "StokId");

            migrationBuilder.CreateIndex(
                name: "IX_Faturalar_CariId",
                table: "Faturalar",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_Faturalar_Id",
                table: "Faturalar",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KasaHareketler_DovizId",
                table: "KasaHareketler",
                column: "DovizId");

            migrationBuilder.CreateIndex(
                name: "IX_KasaHareketler_Id",
                table: "KasaHareketler",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KasaHareketler_KasaId",
                table: "KasaHareketler",
                column: "KasaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kasalar_DovizId",
                table: "Kasalar",
                column: "DovizId");

            migrationBuilder.CreateIndex(
                name: "IX_Kasalar_Id",
                table: "Kasalar",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kategoriler_Id",
                table: "Kategoriler",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kategoriler_KategoriAdi",
                table: "Kategoriler",
                column: "KategoriAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciYorumlari_Id",
                table: "KullaniciYorumlari",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciYorumlari_KullaniciId",
                table: "KullaniciYorumlari",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciYorumlari_StokId",
                table: "KullaniciYorumlari",
                column: "StokId");

            migrationBuilder.CreateIndex(
                name: "IX_Kurlar_DovizId",
                table: "Kurlar",
                column: "DovizId");

            migrationBuilder.CreateIndex(
                name: "IX_Kurlar_DovizId1",
                table: "Kurlar",
                column: "DovizId1");

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_DepartmanId",
                table: "Personeller",
                column: "DepartmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_DepartmanId1",
                table: "Personeller",
                column: "DepartmanId1");

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_SubeId",
                table: "Personeller",
                column: "SubeId");

            migrationBuilder.CreateIndex(
                name: "IX_SatisDetaylari_SatisId",
                table: "SatisDetaylari",
                column: "SatisId");

            migrationBuilder.CreateIndex(
                name: "IX_SatisDetaylari_StokId",
                table: "SatisDetaylari",
                column: "StokId");

            migrationBuilder.CreateIndex(
                name: "IX_Satislar_CariId",
                table: "Satislar",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_Satislar_CariId1",
                table: "Satislar",
                column: "CariId1");

            migrationBuilder.CreateIndex(
                name: "IX_Satislar_PersonelId",
                table: "Satislar",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Satislar_SubeId",
                table: "Satislar",
                column: "SubeId");

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_CariId",
                table: "Siparisler",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_CariId1",
                table: "Siparisler",
                column: "CariId1");

            migrationBuilder.CreateIndex(
                name: "IX_StokBarkodlar_StokId",
                table: "StokBarkodlar",
                column: "StokId");

            migrationBuilder.CreateIndex(
                name: "IX_StokFotograflar_StokId",
                table: "StokFotograflar",
                column: "StokId");

            migrationBuilder.CreateIndex(
                name: "IX_StokHareketler_DepoId",
                table: "StokHareketler",
                column: "DepoId");

            migrationBuilder.CreateIndex(
                name: "IX_StokHareketler_Id",
                table: "StokHareketler",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StokHareketler_StokId",
                table: "StokHareketler",
                column: "StokId");

            migrationBuilder.CreateIndex(
                name: "IX_Stoklar_BirimId",
                table: "Stoklar",
                column: "BirimId");

            migrationBuilder.CreateIndex(
                name: "IX_Stoklar_BirimId1",
                table: "Stoklar",
                column: "BirimId1");

            migrationBuilder.CreateIndex(
                name: "IX_Stoklar_DepoId",
                table: "Stoklar",
                column: "DepoId");

            migrationBuilder.CreateIndex(
                name: "IX_Stoklar_DepoId1",
                table: "Stoklar",
                column: "DepoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Stoklar_KategoriId",
                table: "Stoklar",
                column: "KategoriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FaturaDetaylar");

            migrationBuilder.DropTable(
                name: "KasaHareketler");

            migrationBuilder.DropTable(
                name: "KullaniciYorumlari");

            migrationBuilder.DropTable(
                name: "Kurlar");

            migrationBuilder.DropTable(
                name: "SatisDetaylari");

            migrationBuilder.DropTable(
                name: "Siparisler");

            migrationBuilder.DropTable(
                name: "StokBarkodlar");

            migrationBuilder.DropTable(
                name: "StokFotograflar");

            migrationBuilder.DropTable(
                name: "StokHareketler");

            migrationBuilder.DropTable(
                name: "Tedarikciler");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Faturalar");

            migrationBuilder.DropTable(
                name: "Kasalar");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Satislar");

            migrationBuilder.DropTable(
                name: "Stoklar");

            migrationBuilder.DropTable(
                name: "Dovizler");

            migrationBuilder.DropTable(
                name: "Cariler");

            migrationBuilder.DropTable(
                name: "Personeller");

            migrationBuilder.DropTable(
                name: "Birimler");

            migrationBuilder.DropTable(
                name: "Depolar");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Departmanlar");

            migrationBuilder.DropTable(
                name: "Subeler");
        }
    }
}
