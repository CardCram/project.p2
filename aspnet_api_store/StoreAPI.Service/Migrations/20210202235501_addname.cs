using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreAPI.Service.Migrations
{
    public partial class addname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Deck",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Answer", "Question" },
                values: new object[] { "1", "1x1" });

            migrationBuilder.UpdateData(
                table: "Deck",
                keyColumn: "EntityId",
                keyValue: 1,
                column: "Name",
                value: "Math");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Deck");

            migrationBuilder.UpdateData(
                table: "Card",
                keyColumn: "EntityId",
                keyValue: 1,
                columns: new[] { "Answer", "Question" },
                values: new object[] { "George Washington", "Who was the first president?" });
        }
    }
}
