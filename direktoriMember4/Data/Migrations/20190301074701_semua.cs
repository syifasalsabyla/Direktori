using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace direktoriMember4.Data.Migrations
{
    public partial class semua : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    MemberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NamaMember = table.Column<string>(nullable: true),
                    AlamatMember = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.MemberID);
                });

            migrationBuilder.CreateTable(
                name: "Produk",
                columns: table => new
                {
                    ProdukID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NamaProduk = table.Column<string>(nullable: true),
                    Keterangan = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produk", x => x.ProdukID);
                });

            migrationBuilder.CreateTable(
                name: "SOHeader",
                columns: table => new
                {
                    SOHeaderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MemberID = table.Column<int>(nullable: false),
                    NamaMember = table.Column<string>(nullable: true),
                    Tanggal = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOHeader", x => x.SOHeaderID);
                    table.ForeignKey(
                        name: "FK_SOHeader_Member_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SOLine",
                columns: table => new
                {
                    SOLineID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SOHeaderID = table.Column<int>(nullable: false),
                    ProdukID = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Keterangan = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOLine", x => x.SOLineID);
                    table.ForeignKey(
                        name: "FK_SOLine_Produk_ProdukID",
                        column: x => x.ProdukID,
                        principalTable: "Produk",
                        principalColumn: "ProdukID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SOLine_SOHeader_SOHeaderID",
                        column: x => x.SOHeaderID,
                        principalTable: "SOHeader",
                        principalColumn: "SOHeaderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SOHeader_MemberID",
                table: "SOHeader",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLine_ProdukID",
                table: "SOLine",
                column: "ProdukID");

            migrationBuilder.CreateIndex(
                name: "IX_SOLine_SOHeaderID",
                table: "SOLine",
                column: "SOHeaderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SOLine");

            migrationBuilder.DropTable(
                name: "Produk");

            migrationBuilder.DropTable(
                name: "SOHeader");

            migrationBuilder.DropTable(
                name: "Member");
        }
    }
}
