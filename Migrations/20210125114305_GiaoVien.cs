using Microsoft.EntityFrameworkCore.Migrations;

namespace demoCatalogue.Migrations
{
    public partial class GiaoVien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GiaoVien",
                columns: table => new
                {
                    MaGiaoVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenGiaoVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TuoiGiaoVien = table.Column<int>(type: "int", nullable: false),
                    KhoaGiaoVien = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoVien", x => x.MaGiaoVien);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GiaoVien");
        }
    }
}
