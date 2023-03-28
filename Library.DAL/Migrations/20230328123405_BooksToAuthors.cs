using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.DAL.Migrations
{
    /// <inheritdoc />
    public partial class BooksToAuthors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuthorsToBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorAuthorId = table.Column<int>(type: "int", nullable: false),
                    BookAuthorBookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorsToBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorsToBooks_Authors_AuthorAuthorId",
                        column: x => x.AuthorAuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorsToBooks_Books_BookAuthorBookId",
                        column: x => x.BookAuthorBookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorsToBooks_AuthorAuthorId",
                table: "AuthorsToBooks",
                column: "AuthorAuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorsToBooks_BookAuthorBookId",
                table: "AuthorsToBooks",
                column: "BookAuthorBookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorsToBooks");
        }
    }
}
