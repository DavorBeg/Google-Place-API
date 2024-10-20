using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccessibilityOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WheelchairAccessibleEntrance = table.Column<bool>(type: "bit", nullable: true),
                    WheelchairAccessibleParking = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessibilityOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressDescriptor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descriptor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressDescriptor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AreaSummary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaSummary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserAPIKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EVChargeOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FastCharge = table.Column<bool>(type: "bit", nullable: true),
                    RegularCharge = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EVChargeOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Diesel = table.Column<bool>(type: "bit", nullable: true),
                    Petrol = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenerativeSummary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneratedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerativeSummary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LatLng",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LatLng", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocalizedText",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalizedText", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParkingOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StreetParking = table.Column<bool>(type: "bit", nullable: true),
                    GarageParking = table.Column<bool>(type: "bit", nullable: true),
                    ValetParking = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreditCard = table.Column<bool>(type: "bit", nullable: true),
                    DebitCard = table.Column<bool>(type: "bit", nullable: true),
                    MobilePayment = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlusCode",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GlobalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompoundCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlusCode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Viewport",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SouthwestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NortheastId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viewport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Viewport_LatLng_Id",
                        column: x => x.Id,
                        principalTable: "LatLng",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Viewport_LatLng_SouthwestId",
                        column: x => x.SouthwestId,
                        principalTable: "LatLng",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AddressComponent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LongName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Types = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressComponent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attribution",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attribution", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpeningHours",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WeekdayText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpenNow = table.Column<bool>(type: "bit", nullable: true),
                    CurrentSecondaryOpeningHoursId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RegularSecondaryOpeningHoursId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpeningHours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Types = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryTypeDisplayNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NationalPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InternationalPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormattedAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortFormattedAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: true),
                    GoogleMapsUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebsiteUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegularOpeningHoursId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdrFormatAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessStatus = table.Column<int>(type: "int", nullable: true),
                    PriceLevel = table.Column<int>(type: "int", nullable: true),
                    IconMaskBaseUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconBackgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentOpeningHoursId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EditorialSummaryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressDescriptorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UtcOffsetMinutes = table.Column<int>(type: "int", nullable: false),
                    UserRatingCount = table.Column<int>(type: "int", nullable: false),
                    Takeout = table.Column<bool>(type: "bit", nullable: true),
                    Delivery = table.Column<bool>(type: "bit", nullable: true),
                    DineIn = table.Column<bool>(type: "bit", nullable: true),
                    CurbsidePickup = table.Column<bool>(type: "bit", nullable: true),
                    Reservable = table.Column<bool>(type: "bit", nullable: true),
                    ServesBreakfast = table.Column<bool>(type: "bit", nullable: true),
                    ServesLunch = table.Column<bool>(type: "bit", nullable: true),
                    ServesDinner = table.Column<bool>(type: "bit", nullable: true),
                    ServesBeer = table.Column<bool>(type: "bit", nullable: true),
                    ServesWine = table.Column<bool>(type: "bit", nullable: true),
                    ServesBrunch = table.Column<bool>(type: "bit", nullable: true),
                    ServesVegetarianFood = table.Column<bool>(type: "bit", nullable: true),
                    OutdoorSeating = table.Column<bool>(type: "bit", nullable: true),
                    LiveMusic = table.Column<bool>(type: "bit", nullable: true),
                    MenuForChildren = table.Column<bool>(type: "bit", nullable: true),
                    ServesCocktails = table.Column<bool>(type: "bit", nullable: true),
                    ServesDessert = table.Column<bool>(type: "bit", nullable: true),
                    ServesCoffee = table.Column<bool>(type: "bit", nullable: true),
                    GoodForChildren = table.Column<bool>(type: "bit", nullable: true),
                    AllowsDogs = table.Column<bool>(type: "bit", nullable: true),
                    Restroom = table.Column<bool>(type: "bit", nullable: true),
                    GoodForGroups = table.Column<bool>(type: "bit", nullable: true),
                    GoodForWatchingSports = table.Column<bool>(type: "bit", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Places_AccessibilityOptions_Id",
                        column: x => x.Id,
                        principalTable: "AccessibilityOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Places_AddressDescriptor_AddressDescriptorId",
                        column: x => x.AddressDescriptorId,
                        principalTable: "AddressDescriptor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Places_AreaSummary_Id",
                        column: x => x.Id,
                        principalTable: "AreaSummary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Places_EVChargeOptions_Id",
                        column: x => x.Id,
                        principalTable: "EVChargeOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_FuelOptions_Id",
                        column: x => x.Id,
                        principalTable: "FuelOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_GenerativeSummary_Id",
                        column: x => x.Id,
                        principalTable: "GenerativeSummary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_LatLng_Id",
                        column: x => x.Id,
                        principalTable: "LatLng",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_LocalizedText_EditorialSummaryId",
                        column: x => x.EditorialSummaryId,
                        principalTable: "LocalizedText",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_LocalizedText_Id",
                        column: x => x.Id,
                        principalTable: "LocalizedText",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_LocalizedText_PrimaryTypeDisplayNameId",
                        column: x => x.PrimaryTypeDisplayNameId,
                        principalTable: "LocalizedText",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_OpeningHours_CurrentOpeningHoursId",
                        column: x => x.CurrentOpeningHoursId,
                        principalTable: "OpeningHours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_OpeningHours_RegularOpeningHoursId",
                        column: x => x.RegularOpeningHoursId,
                        principalTable: "OpeningHours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_ParkingOptions_Id",
                        column: x => x.Id,
                        principalTable: "ParkingOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_PaymentOptions_Id",
                        column: x => x.Id,
                        principalTable: "PaymentOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_PlusCode_Id",
                        column: x => x.Id,
                        principalTable: "PlusCode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_Viewport_Id",
                        column: x => x.Id,
                        principalTable: "Viewport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    HtmlAttributions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photo_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubDestination",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubDestination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubDestination_LatLng_Id",
                        column: x => x.Id,
                        principalTable: "LatLng",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubDestination_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04d687e1-cb75-4dde-a65b-018ae955914c", null, "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_AddressComponent_PlaceId",
                table: "AddressComponent",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Attribution_PlaceId",
                table: "Attribution",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_OpeningHours_CurrentSecondaryOpeningHoursId",
                table: "OpeningHours",
                column: "CurrentSecondaryOpeningHoursId");

            migrationBuilder.CreateIndex(
                name: "IX_OpeningHours_RegularSecondaryOpeningHoursId",
                table: "OpeningHours",
                column: "RegularSecondaryOpeningHoursId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_PlaceId",
                table: "Photo",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Places_AddressDescriptorId",
                table: "Places",
                column: "AddressDescriptorId");

            migrationBuilder.CreateIndex(
                name: "IX_Places_CurrentOpeningHoursId",
                table: "Places",
                column: "CurrentOpeningHoursId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Places_EditorialSummaryId",
                table: "Places",
                column: "EditorialSummaryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Places_PrimaryTypeDisplayNameId",
                table: "Places",
                column: "PrimaryTypeDisplayNameId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Places_RegularOpeningHoursId",
                table: "Places",
                column: "RegularOpeningHoursId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Places_UserId",
                table: "Places",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_PlaceId",
                table: "Review",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_SubDestination_PlaceId",
                table: "SubDestination",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Viewport_SouthwestId",
                table: "Viewport",
                column: "SouthwestId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressComponent_Places_PlaceId",
                table: "AddressComponent",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Attribution_Places_PlaceId",
                table: "Attribution",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpeningHours_Places_CurrentSecondaryOpeningHoursId",
                table: "OpeningHours",
                column: "CurrentSecondaryOpeningHoursId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpeningHours_Places_RegularSecondaryOpeningHoursId",
                table: "OpeningHours",
                column: "RegularSecondaryOpeningHoursId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OpeningHours_Places_CurrentSecondaryOpeningHoursId",
                table: "OpeningHours");

            migrationBuilder.DropForeignKey(
                name: "FK_OpeningHours_Places_RegularSecondaryOpeningHoursId",
                table: "OpeningHours");

            migrationBuilder.DropTable(
                name: "AddressComponent");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Attribution");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "SubDestination");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Places");

            migrationBuilder.DropTable(
                name: "AccessibilityOptions");

            migrationBuilder.DropTable(
                name: "AddressDescriptor");

            migrationBuilder.DropTable(
                name: "AreaSummary");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "EVChargeOptions");

            migrationBuilder.DropTable(
                name: "FuelOptions");

            migrationBuilder.DropTable(
                name: "GenerativeSummary");

            migrationBuilder.DropTable(
                name: "LocalizedText");

            migrationBuilder.DropTable(
                name: "OpeningHours");

            migrationBuilder.DropTable(
                name: "ParkingOptions");

            migrationBuilder.DropTable(
                name: "PaymentOptions");

            migrationBuilder.DropTable(
                name: "PlusCode");

            migrationBuilder.DropTable(
                name: "Viewport");

            migrationBuilder.DropTable(
                name: "LatLng");
        }
    }
}
