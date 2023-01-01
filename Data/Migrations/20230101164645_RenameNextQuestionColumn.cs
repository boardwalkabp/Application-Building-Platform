using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class RenameNextQuestionColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_answers_questions_NextQuestionId",
                table: "answers");

            migrationBuilder.RenameColumn(
                name: "NextQuestionId",
                table: "answers",
                newName: "next_question_id");

            migrationBuilder.RenameIndex(
                name: "IX_answers_NextQuestionId",
                table: "answers",
                newName: "IX_answers_next_question_id");

            migrationBuilder.AddForeignKey(
                name: "FK_answers_questions_next_question_id",
                table: "answers",
                column: "next_question_id",
                principalTable: "questions",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_answers_questions_next_question_id",
                table: "answers");

            migrationBuilder.RenameColumn(
                name: "next_question_id",
                table: "answers",
                newName: "NextQuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_answers_next_question_id",
                table: "answers",
                newName: "IX_answers_NextQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_answers_questions_NextQuestionId",
                table: "answers",
                column: "NextQuestionId",
                principalTable: "questions",
                principalColumn: "id");
        }
    }
}
