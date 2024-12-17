using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teknoroma.Entities.Migrations
{
    /// <inheritdoc />
    public partial class GenericDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SatisDetaylari_Satislar_SatisId",
                table: "SatisDetaylari");

            migrationBuilder.DropForeignKey(
                name: "FK_Siparisler_Cariler_CariId",
                table: "Siparisler");

            migrationBuilder.DropForeignKey(
                name: "FK_StokBarkodlari_Stoklar_StokId",
                table: "StokBarkodlari");

            migrationBuilder.AddForeignKey(
                name: "FK_SatisDetaylari_Satislar_SatisId",
                table: "SatisDetaylari",
                column: "SatisId",
                principalTable: "Satislar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Siparisler_Cariler_CariId",
                table: "Siparisler",
                column: "CariId",
                principalTable: "Cariler",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StokBarkodlari_Stoklar_StokId",
                table: "StokBarkodlari",
                column: "StokId",
                principalTable: "Stoklar",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SatisDetaylari_Satislar_SatisId",
                table: "SatisDetaylari");

            migrationBuilder.DropForeignKey(
                name: "FK_Siparisler_Cariler_CariId",
                table: "Siparisler");

            migrationBuilder.DropForeignKey(
                name: "FK_StokBarkodlari_Stoklar_StokId",
                table: "StokBarkodlari");

            migrationBuilder.AddForeignKey(
                name: "FK_SatisDetaylari_Satislar_SatisId",
                table: "SatisDetaylari",
                column: "SatisId",
                principalTable: "Satislar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Siparisler_Cariler_CariId",
                table: "Siparisler",
                column: "CariId",
                principalTable: "Cariler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StokBarkodlari_Stoklar_StokId",
                table: "StokBarkodlari",
                column: "StokId",
                principalTable: "Stoklar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
