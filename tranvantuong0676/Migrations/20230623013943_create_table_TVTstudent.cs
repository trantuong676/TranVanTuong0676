using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tranvantuong0676.Migrations
{
    /// <inheritdoc />
    public partial class create_table_TVTstudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TVTstudent",
                columns: table => new
                {
                    TVTstudentID = table.Column<string>(type: "TEXT", nullable: false),
                    TVTstudentName = table.Column<string>(type: "TEXT", nullable: false),
                    TVTStudentSex = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TVTstudent", x => x.TVTstudentID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TVTstudent");
        }
    }
}
