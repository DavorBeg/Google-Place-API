using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class AddedGoogleIdInsideFavoriteTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45cb2f35-1374-41d5-af61-d5b5b3840e1f");

            migrationBuilder.AddColumn<string>(
                name: "GooglePlaceId",
                table: "FavoritePlaces",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b0a38d1-71ad-4628-80c8-88beb6251929", null, "User", "USER" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b0a38d1-71ad-4628-80c8-88beb6251929");

            migrationBuilder.DropColumn(
                name: "GooglePlaceId",
                table: "FavoritePlaces");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "45cb2f35-1374-41d5-af61-d5b5b3840e1f", null, "User", "USER" });
        }
    }
}
