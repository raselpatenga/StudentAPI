using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAPIV2.Migrations.Teacher
{
    public partial class initial_teacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblTeachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(nullable: true),
                    Mobile = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    isMarried = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTeachers", x => x.TeacherId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblTeachers");
        }
    }
}
