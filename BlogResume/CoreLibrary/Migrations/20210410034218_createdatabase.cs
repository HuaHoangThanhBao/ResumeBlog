using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreLibrary.Migrations
{
    public partial class createdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chu_de",
                columns: table => new
                {
                    ChuDeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChuDe = table.Column<string>(maxLength: 50, nullable: false),
                    TinhTrang = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chu_de", x => x.ChuDeID);
                });

            migrationBuilder.CreateTable(
                name: "bai_viet",
                columns: table => new
                {
                    BaiVietID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChuDeID = table.Column<int>(nullable: false),
                    TieuDe = table.Column<string>(maxLength: 50, nullable: false),
                    MoTa = table.Column<string>(maxLength: 25, nullable: false),
                    NoiDung = table.Column<string>(nullable: false),
                    NgayDang = table.Column<DateTime>(nullable: false),
                    HinhAnh = table.Column<string>(nullable: false),
                    TinhTrang = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bai_viet", x => x.BaiVietID);
                    table.ForeignKey(
                        name: "FK_bai_viet_chu_de_ChuDeID",
                        column: x => x.ChuDeID,
                        principalTable: "chu_de",
                        principalColumn: "ChuDeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bai_viet_ChuDeID",
                table: "bai_viet",
                column: "ChuDeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bai_viet");

            migrationBuilder.DropTable(
                name: "chu_de");
        }
    }
}
