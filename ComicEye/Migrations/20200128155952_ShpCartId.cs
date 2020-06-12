using Microsoft.EntityFrameworkCore.Migrations;

namespace ComicEye.Migrations
{
    public partial class ShpCartId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ShopCartId",
                table: "ShopCartItem",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ShopCart",
                columns: table => new
                {
                    ShopCartId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCart", x => x.ShopCartId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopCartItem_ShopCartId",
                table: "ShopCartItem",
                column: "ShopCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCartItem_ShopCart_ShopCartId",
                table: "ShopCartItem",
                column: "ShopCartId",
                principalTable: "ShopCart",
                principalColumn: "ShopCartId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopCartItem_ShopCart_ShopCartId",
                table: "ShopCartItem");

            migrationBuilder.DropTable(
                name: "ShopCart");

            migrationBuilder.DropIndex(
                name: "IX_ShopCartItem_ShopCartId",
                table: "ShopCartItem");

            migrationBuilder.AlterColumn<string>(
                name: "ShopCartId",
                table: "ShopCartItem",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
