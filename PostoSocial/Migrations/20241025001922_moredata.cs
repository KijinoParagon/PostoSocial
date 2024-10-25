using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostoSocial.Migrations
{
    public partial class moredata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ForumIconPath",
                table: "Forums",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "ProfilePicturePath",
                value: "butterfly.png");

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 1,
                column: "ForumIconPath",
                value: "posto.png");

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "ForumId", "ForumDescription", "ForumIconPath", "ForumName", "ForumRules" },
                values: new object[,]
                {
                    { 2, "Built for the best of games", "posto.png", "TWEWY", "There are no rules currently." },
                    { 3, "The MVC Template", "posto.png", "CIS236", "There are no rules currently." },
                    { 4, "We love you", "posto.png", "Costco", "There are no rules currently." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "ForumIconPath",
                table: "Forums");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "ProfilePicturePath",
                value: "butterfly");
        }
    }
}
