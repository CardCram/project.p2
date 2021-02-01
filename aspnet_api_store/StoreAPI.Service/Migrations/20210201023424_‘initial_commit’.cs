using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreAPI.Service.Migrations
{
    public partial class initial_commit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deck",
                columns: table => new
                {
                    EntityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deck", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    EntityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeckEntityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_Card_Deck_DeckEntityId",
                        column: x => x.DeckEntityId,
                        principalTable: "Deck",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Deck",
                column: "EntityId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Card",
                columns: new[] { "EntityId", "Answer", "DeckEntityId", "Question" },
                values: new object[] { 1, "George Washington", 1, "Who was the first president?" });

            migrationBuilder.CreateIndex(
                name: "IX_Card_DeckEntityId",
                table: "Card",
                column: "DeckEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "Deck");
        }
    }
}
