using System.Collections.Generic;
using API.Models.Domain;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class FixColumnNamesAndSetDefaultAppStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "questions");

            migrationBuilder.DropColumn(
                name: "Applications",
                table: "clients");

            migrationBuilder.DropColumn(
                name: "Applications",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "Questions",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "applications");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "users",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "users",
                newName: "role");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "users",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "users",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "VerifiedAt",
                table: "users",
                newName: "verified_at");

            migrationBuilder.RenameColumn(
                name: "VerificationToken",
                table: "users",
                newName: "verification_token");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "users",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "ResetTokenExpires",
                table: "users",
                newName: "reset_token_expires");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "users",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "PasswordSalt",
                table: "users",
                newName: "password_salt");

            migrationBuilder.RenameColumn(
                name: "PasswordResetToken",
                table: "users",
                newName: "reset_token");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "users",
                newName: "password_hash");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "users",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "Options",
                table: "questions",
                newName: "options");

            migrationBuilder.RenameColumn(
                name: "Choices",
                table: "questions",
                newName: "choices");

            migrationBuilder.RenameColumn(
                name: "Body",
                table: "questions",
                newName: "body");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "questions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "questions",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "QuestionType",
                table: "questions",
                newName: "question_type");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "questions",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "clients",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "clients",
                newName: "role");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "clients",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "clients",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "clients",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "clients",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "VerifiedAt",
                table: "clients",
                newName: "verified_at");

            migrationBuilder.RenameColumn(
                name: "VerificationToken",
                table: "clients",
                newName: "verification_token");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "clients",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "ResetTokenExpires",
                table: "clients",
                newName: "reset_token_expires");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "clients",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "PasswordSalt",
                table: "clients",
                newName: "password_salt");

            migrationBuilder.RenameColumn(
                name: "PasswordResetToken",
                table: "clients",
                newName: "reset_token");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "clients",
                newName: "password_hash");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "clients",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "categories",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "categories",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "categories",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "categories",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "applications",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "applications",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Questions",
                table: "applications",
                newName: "questions");

            migrationBuilder.RenameColumn(
                name: "Answers",
                table: "applications",
                newName: "answers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "applications",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "applications",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "applications",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "CompletedAt",
                table: "applications",
                newName: "completed_at");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "applications",
                newName: "client_id");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "applications",
                newName: "category_id");

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "users",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "clients",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "username",
                table: "users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "users",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "users",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "verified_at",
                table: "users",
                newName: "VerifiedAt");

            migrationBuilder.RenameColumn(
                name: "verification_token",
                table: "users",
                newName: "VerificationToken");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "users",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "reset_token_expires",
                table: "users",
                newName: "ResetTokenExpires");

            migrationBuilder.RenameColumn(
                name: "reset_token",
                table: "users",
                newName: "PasswordResetToken");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "users",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "password_salt",
                table: "users",
                newName: "PasswordSalt");

            migrationBuilder.RenameColumn(
                name: "password_hash",
                table: "users",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "users",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "options",
                table: "questions",
                newName: "Options");

            migrationBuilder.RenameColumn(
                name: "choices",
                table: "questions",
                newName: "Choices");

            migrationBuilder.RenameColumn(
                name: "body",
                table: "questions",
                newName: "Body");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "questions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "questions",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "question_type",
                table: "questions",
                newName: "QuestionType");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "questions",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "username",
                table: "clients",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "clients",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "clients",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "clients",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "clients",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "clients",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "verified_at",
                table: "clients",
                newName: "VerifiedAt");

            migrationBuilder.RenameColumn(
                name: "verification_token",
                table: "clients",
                newName: "VerificationToken");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "clients",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "reset_token_expires",
                table: "clients",
                newName: "ResetTokenExpires");

            migrationBuilder.RenameColumn(
                name: "reset_token",
                table: "clients",
                newName: "PasswordResetToken");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "clients",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "password_salt",
                table: "clients",
                newName: "PasswordSalt");

            migrationBuilder.RenameColumn(
                name: "password_hash",
                table: "clients",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "clients",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "categories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "categories",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "categories",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "applications",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "applications",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "questions",
                table: "applications",
                newName: "Questions");

            migrationBuilder.RenameColumn(
                name: "answers",
                table: "applications",
                newName: "Answers");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "applications",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "applications",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "applications",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "completed_at",
                table: "applications",
                newName: "CompletedAt");

            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "applications",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "category_id",
                table: "applications",
                newName: "CategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "users",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "questions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "clients",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<List<Application>>(
                name: "Applications",
                table: "clients",
                type: "jsonb",
                nullable: true);

            migrationBuilder.AddColumn<List<Application>>(
                name: "Applications",
                table: "categories",
                type: "jsonb",
                nullable: true);

            migrationBuilder.AddColumn<List<Question>>(
                name: "Questions",
                table: "categories",
                type: "jsonb",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "applications",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
