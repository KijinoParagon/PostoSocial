using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostoSocial.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePicturePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Forums",
                columns: table => new
                {
                    ForumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForumName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ForumDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForumRules = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums", x => x.ForumId);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ForumId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountId", "Email", "Password", "ProfilePicturePath", "UserName" },
                values: new object[] { 1, "andrew.honey@southeasttech.edu", "ice", "butterfly", "samuraiofice" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "ForumId", "ForumDescription", "ForumName", "ForumRules" },
                values: new object[] { 1, "Forum for Posto...", "Posto", "There are no rules currently." });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CategoryId", "ForumId", "PostBody", "PostTitle" },
                values: new object[] { 1, 1, 1, "This is Posto Social Media", "Yeet" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Forums");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
