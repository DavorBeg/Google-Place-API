using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class AddedForeignKeyCloseId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Close_Date_DateId",
                table: "Close");

            migrationBuilder.DropIndex(
                name: "IX_Close_DateId",
                table: "Close");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c214c46-4c4f-49cc-b4de-52ffab065547");

            migrationBuilder.DropColumn(
                name: "DateId",
                table: "Close");

            migrationBuilder.AddColumn<Guid>(
                name: "CloseId",
                table: "Date",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "45cb2f35-1374-41d5-af61-d5b5b3840e1f", null, "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_Date_CloseId",
                table: "Date",
                column: "CloseId",
                unique: true,
                filter: "[CloseId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Date_Close_CloseId",
                table: "Date",
                column: "CloseId",
                principalTable: "Close",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Date_Close_CloseId",
                table: "Date");

            migrationBuilder.DropIndex(
                name: "IX_Date_CloseId",
                table: "Date");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45cb2f35-1374-41d5-af61-d5b5b3840e1f");

            migrationBuilder.DropColumn(
                name: "CloseId",
                table: "Date");

            migrationBuilder.AddColumn<Guid>(
                name: "DateId",
                table: "Close",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c214c46-4c4f-49cc-b4de-52ffab065547", null, "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_Close_DateId",
                table: "Close",
                column: "DateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Close_Date_DateId",
                table: "Close",
                column: "DateId",
                principalTable: "Date",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
