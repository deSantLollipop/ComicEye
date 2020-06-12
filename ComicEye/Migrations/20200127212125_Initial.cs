using Microsoft.EntityFrameworkCore.Migrations;

namespace ComicEye.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    categoryName = table.Column<string>(nullable: false),
                    id = table.Column<int>(nullable: false),
                    desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.categoryName);
                });

            migrationBuilder.CreateTable(
                name: "Comics",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    publisher = table.Column<string>(nullable: true),
                    shortDesc = table.Column<string>(nullable: true),
                    longDesc = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    img = table.Column<string>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    isFavourite = table.Column<bool>(nullable: false),
                    available = table.Column<bool>(nullable: false),
                    categoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comics", x => x.id);
                    table.ForeignKey(
                        name: "FK_Comics_Category_categoryName",
                        column: x => x.categoryName,
                        principalTable: "Category",
                        principalColumn: "categoryName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShopCartItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comicBookid = table.Column<int>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    ShopCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopCartItem_Comics_comicBookid",
                        column: x => x.comicBookid,
                        principalTable: "Comics",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comics_categoryName",
                table: "Comics",
                column: "categoryName");

            migrationBuilder.CreateIndex(
                name: "IX_ShopCartItem_comicBookid",
                table: "ShopCartItem",
                column: "comicBookid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopCartItem");

            migrationBuilder.DropTable(
                name: "Comics");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
