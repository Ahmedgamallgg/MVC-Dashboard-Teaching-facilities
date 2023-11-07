using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class AddRelationshipOnCourseLessonsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CourseLessons_CourseId",
                table: "CourseLessons",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseLessons_Courses_CourseId",
                table: "CourseLessons",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseLessons_Courses_CourseId",
                table: "CourseLessons");

            migrationBuilder.DropIndex(
                name: "IX_CourseLessons_CourseId",
                table: "CourseLessons");
        }
    }
}
