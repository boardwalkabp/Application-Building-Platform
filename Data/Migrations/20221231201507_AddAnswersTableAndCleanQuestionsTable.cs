using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAnswersTableAndCleanQuestionsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_questions_categories_CategoryId",
                table: "questions");

            migrationBuilder.DropIndex(
                name: "IX_questions_CategoryId",
                table: "questions");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "questions");

            migrationBuilder.DropColumn(
                name: "options",
                table: "questions");

            migrationBuilder.CreateTable(
                name: "answers",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    value = table.Column<string>(type: "text", nullable: false),
                    questionid = table.Column<Guid>(name: "question_id", type: "uuid", nullable: false),
                    NextQuestionId = table.Column<Guid>(type: "uuid", nullable: true),
                    createdat = table.Column<DateTime>(name: "created_at", type: "timestamp without time zone", nullable: false),
                    updatedat = table.Column<DateTime>(name: "updated_at", type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_answers", x => x.id);
                    table.ForeignKey(
                        name: "FK_answers_questions_NextQuestionId",
                        column: x => x.NextQuestionId,
                        principalTable: "questions",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_answers_questions_question_id",
                        column: x => x.questionid,
                        principalTable: "questions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_answers_NextQuestionId",
                table: "answers",
                column: "NextQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_answers_question_id",
                table: "answers",
                column: "question_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "answers");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "questions",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "options",
                table: "questions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_questions_CategoryId",
                table: "questions",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_questions_categories_CategoryId",
                table: "questions",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "id");
        }
    }
}
