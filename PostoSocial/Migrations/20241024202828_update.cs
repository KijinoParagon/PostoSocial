using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostoSocial.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "AccountId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "AccountId", "CategoryId", "ForumId", "PostBody", "PostTitle" },
                values: new object[,]
                {
                    { 2, 1, 1, 1, "welcome", "Yo, second post" },
                    { 3, 1, 1, 1, "lorem ipsum", "I make so many posts" },
                    { 4, 1, 1, 1, "To zanarkand", "dos amet" },
                    { 5, 1, 1, 1, "cheese", "Lol, I'm so random" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AccountId",
                table: "Posts",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ForumId",
                table: "Posts",
                column: "ForumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Accounts_AccountId",
                table: "Posts",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Forums_ForumId",
                table: "Posts",
                column: "ForumId",
                principalTable: "Forums",
                principalColumn: "ForumId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Accounts_AccountId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Forums_ForumId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_AccountId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_ForumId",
                table: "Posts");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Posts");
        }
    }
}
