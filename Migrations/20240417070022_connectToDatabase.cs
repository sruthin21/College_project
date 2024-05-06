using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Updated_Project.Migrations
{
    /// <inheritdoc />
    public partial class connectToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InternalMarksMaximum = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    InternalMarksSecured = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    SemesterMarksMaximum = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    SemesterMarksSecured = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
