using System;
using System.Collections.Generic;
using API.Models.Domain;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class ApplicationQuestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_applications_categories_CategoryId",
                table: "applications");

            migrationBuilder.DropForeignKey(
                name: "FK_applications_clients_ClientId",
                table: "applications");

            migrationBuilder.DropIndex(
                name: "IX_applications_CategoryId",
                table: "applications");

            migrationBuilder.DropIndex(
                name: "IX_applications_ClientId",
                table: "applications");

            migrationBuilder.AddColumn<List<Choices>>(
                name: "Choices",
                table: "questions",
                type: "jsonb",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QuestionType",
                table: "questions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "applications",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "applications",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Choices",
                table: "questions");

            migrationBuilder.DropColumn(
                name: "QuestionType",
                table: "questions");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "applications",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "applications",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.CreateIndex(
                name: "IX_applications_CategoryId",
                table: "applications",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_applications_ClientId",
                table: "applications",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_applications_categories_CategoryId",
                table: "applications",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_applications_clients_ClientId",
                table: "applications",
                column: "ClientId",
                principalTable: "clients",
                principalColumn: "Id");
        }
    }
}
