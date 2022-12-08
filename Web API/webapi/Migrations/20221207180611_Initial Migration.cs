using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "book",
                columns: table => new
                {
                    BookID = table.Column<Guid>(name: "Book_ID", type: "uniqueidentifier", nullable: false),
                    bktitle = table.Column<string>(name: "bk_title", type: "nvarchar(max)", nullable: false),
                    bkname = table.Column<string>(name: "bk_name", type: "nvarchar(max)", nullable: false),
                    publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pubdate = table.Column<string>(name: "pub_date", type: "nvarchar(max)", nullable: false),
                    available = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_book", x => x.BookID);
                });

            migrationBuilder.CreateTable(
                name: "librarian",
                columns: table => new
                {
                    LibrarianID = table.Column<Guid>(name: "Librarian_ID", type: "uniqueidentifier", nullable: false),
                    officername = table.Column<string>(name: "officer_name", type: "nvarchar(max)", nullable: false),
                    phonenumber = table.Column<string>(name: "phone_number", type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    joiningdate = table.Column<string>(name: "joining_date", type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_librarian", x => x.LibrarianID);
                });

            migrationBuilder.CreateTable(
                name: "student",
                columns: table => new
                {
                    StudentID = table.Column<Guid>(name: "Student_ID", type: "uniqueidentifier", nullable: false),
                    fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    contactadd = table.Column<string>(name: "contact_add", type: "nvarchar(max)", nullable: false),
                    studentemail = table.Column<string>(name: "student_email", type: "nvarchar(max)", nullable: false),
                    studentpass = table.Column<string>(name: "student_pass", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "borrowing",
                columns: table => new
                {
                    BorrowingID = table.Column<Guid>(name: "Borrowing_ID", type: "uniqueidentifier", nullable: false),
                    dateborrowed = table.Column<string>(name: "date_borrowed", type: "nvarchar(max)", nullable: false),
                    datereturn = table.Column<string>(name: "date_return", type: "nvarchar(max)", nullable: false),
                    bookID = table.Column<Guid>(name: "book_ID", type: "uniqueidentifier", nullable: false),
                    studentID = table.Column<Guid>(name: "student_ID", type: "uniqueidentifier", nullable: false),
                    librarianID = table.Column<Guid>(name: "librarian_ID", type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_borrowing", x => x.BorrowingID);
                    table.ForeignKey(
                        name: "FK_borrowing_book_book_ID",
                        column: x => x.bookID,
                        principalTable: "book",
                        principalColumn: "Book_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_borrowing_librarian_librarian_ID",
                        column: x => x.librarianID,
                        principalTable: "librarian",
                        principalColumn: "Librarian_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_borrowing_student_student_ID",
                        column: x => x.studentID,
                        principalTable: "student",
                        principalColumn: "Student_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_borrowing_book_ID",
                table: "borrowing",
                column: "book_ID");

            migrationBuilder.CreateIndex(
                name: "IX_borrowing_librarian_ID",
                table: "borrowing",
                column: "librarian_ID");

            migrationBuilder.CreateIndex(
                name: "IX_borrowing_student_ID",
                table: "borrowing",
                column: "student_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "borrowing");

            migrationBuilder.DropTable(
                name: "book");

            migrationBuilder.DropTable(
                name: "librarian");

            migrationBuilder.DropTable(
                name: "student");
        }
    }
}
