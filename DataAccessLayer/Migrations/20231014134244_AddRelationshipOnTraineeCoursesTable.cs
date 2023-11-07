using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class AddRelationshipOnTraineeCoursesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TraineeCourses_CourseId",
                table: "TraineeCourses",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_TraineeCourses_Courses_CourseId",
                table: "TraineeCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TraineeCourses_Trainees_TraineeId",
                table: "TraineeCourses",
                column: "TraineeId",
                principalTable: "Trainees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TraineeCourses_Courses_CourseId",
                table: "TraineeCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_TraineeCourses_Trainees_TraineeId",
                table: "TraineeCourses");

            migrationBuilder.DropIndex(
                name: "IX_TraineeCourses_CourseId",
                table: "TraineeCourses");
        }
    }
}
