using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenVanSon_02.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_NguyenVanSonDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NguyenVanSonDb",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguyenVanSonDb", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NguyenVanSonDb");
        }
    }
}
