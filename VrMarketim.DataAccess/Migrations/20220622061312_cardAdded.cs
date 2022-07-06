using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace VrMarketim.DataAccess.Migrations
{
    public partial class cardAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Baskets_BasketId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_BasketId",
                table: "Purchases");

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CardNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    NameSurname = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Date = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    SecCode = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_BasketId",
                table: "Purchases",
                column: "BasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Baskets_BasketId",
                table: "Purchases",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
