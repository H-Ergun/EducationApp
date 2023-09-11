﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationApp.Migrations
{
    /// <inheritdoc />
    public partial class first4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnrollmentRequests_Students_StudentId",
                table: "EnrollmentRequests");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "EnrollmentRequests",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EnrollmentRequests_Students_StudentId",
                table: "EnrollmentRequests",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnrollmentRequests_Students_StudentId",
                table: "EnrollmentRequests");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "EnrollmentRequests",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_EnrollmentRequests_Students_StudentId",
                table: "EnrollmentRequests",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }
    }
}
