using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booksaw.Migrations
{
    /// <inheritdoc />
    public partial class createdtablebestselling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BestSelling",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BestSelling",
                table: "Books");
        }
    }
}
