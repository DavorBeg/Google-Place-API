using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Date",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<long>(type: "bigint", nullable: false),
                    Month = table.Column<long>(type: "bigint", nullable: false),
                    Day = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Date", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DisplayName",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisplayName", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "References",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.Id);
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
                name: "Close",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Day = table.Column<long>(type: "bigint", nullable: false),
                    Hour = table.Column<long>(type: "bigint", nullable: false),
                    Minute = table.Column<long>(type: "bigint", nullable: false),
                    DateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Close", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Close_Date_DateId",
                        column: x => x.DateId,
                        principalTable: "Date",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccessibilityOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WheelchairAccessibleParking = table.Column<bool>(type: "bit", nullable: true),
                    WheelchairAccessibleEntrance = table.Column<bool>(type: "bit", nullable: false),
                    WheelchairAccessibleRestroom = table.Column<bool>(type: "bit", nullable: false),
                    WheelchairAccessibleSeating = table.Column<bool>(type: "bit", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessibilityOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressComponent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LongText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Types = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressComponent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressDescriptor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressDescriptor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Containment = table.Column<int>(type: "int", nullable: false),
                    AddressDescriptorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Area_AddressDescriptor_AddressDescriptorId",
                        column: x => x.AddressDescriptorId,
                        principalTable: "AddressDescriptor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Area_DisplayName_DisplayNameId",
                        column: x => x.DisplayNameId,
                        principalTable: "DisplayName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Landmark",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Types = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpatialRelationship = table.Column<int>(type: "int", nullable: true),
                    StraightLineDistanceMeters = table.Column<double>(type: "float", nullable: false),
                    TravelDistanceMeters = table.Column<double>(type: "float", nullable: true),
                    AddressDescriptorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landmark", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Landmark_AddressDescriptor_AddressDescriptorId",
                        column: x => x.AddressDescriptorId,
                        principalTable: "AddressDescriptor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Landmark_DisplayName_DisplayNameId",
                        column: x => x.DisplayNameId,
                        principalTable: "DisplayName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuthorAttribution",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorAttribution", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Circle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Radius = table.Column<double>(type: "float", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurrentOpeningHours",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OpenNow = table.Column<bool>(type: "bit", nullable: false),
                    WeekdayDescriptions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondaryHoursType = table.Column<int>(type: "int", nullable: true),
                    PlaceCurrentSecondaryOpeningHoursId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PlaceRegularSecondaryOpeningHoursId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentOpeningHours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Period",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OpenId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CloseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CurrentOpeningHoursId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Period", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Period_Close_CloseId",
                        column: x => x.CloseId,
                        principalTable: "Close",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Period_Close_OpenId",
                        column: x => x.OpenId,
                        principalTable: "Close",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Period_CurrentOpeningHours_CurrentOpeningHoursId",
                        column: x => x.CurrentOpeningHoursId,
                        principalTable: "CurrentOpeningHours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Types = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InternationalPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormattedAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    GoogleMapsUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebsiteUri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegularOpeningHoursId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UtcOffsetMinutes = table.Column<long>(type: "bigint", nullable: false),
                    AdrFormatAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessStatus = table.Column<int>(type: "int", nullable: false),
                    PriceLevel = table.Column<int>(type: "int", nullable: false),
                    UserRatingCount = table.Column<long>(type: "bigint", nullable: false),
                    IconMaskBaseUri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconBackgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PrimaryTypeDisplayNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Takeout = table.Column<bool>(type: "bit", nullable: true),
                    Delivery = table.Column<bool>(type: "bit", nullable: false),
                    DineIn = table.Column<bool>(type: "bit", nullable: false),
                    CurbsidePickup = table.Column<bool>(type: "bit", nullable: true),
                    Reservable = table.Column<bool>(type: "bit", nullable: false),
                    ServesBreakfast = table.Column<bool>(type: "bit", nullable: true),
                    ServesLunch = table.Column<bool>(type: "bit", nullable: false),
                    ServesDinner = table.Column<bool>(type: "bit", nullable: false),
                    ServesBeer = table.Column<bool>(type: "bit", nullable: false),
                    ServesWine = table.Column<bool>(type: "bit", nullable: false),
                    ServesBrunch = table.Column<bool>(type: "bit", nullable: true),
                    ServesVegetarianFood = table.Column<bool>(type: "bit", nullable: true),
                    CurrentOpeningHoursId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PrimaryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortFormattedAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditorialSummaryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OutdoorSeating = table.Column<bool>(type: "bit", nullable: false),
                    LiveMusic = table.Column<bool>(type: "bit", nullable: false),
                    MenuForChildren = table.Column<bool>(type: "bit", nullable: false),
                    ServesCocktails = table.Column<bool>(type: "bit", nullable: false),
                    ServesDessert = table.Column<bool>(type: "bit", nullable: false),
                    ServesCoffee = table.Column<bool>(type: "bit", nullable: false),
                    GoodForChildren = table.Column<bool>(type: "bit", nullable: true),
                    AllowsDogs = table.Column<bool>(type: "bit", nullable: true),
                    Restroom = table.Column<bool>(type: "bit", nullable: false),
                    GoodForGroups = table.Column<bool>(type: "bit", nullable: false),
                    GoodForWatchingSports = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.PlaceId);
                    table.ForeignKey(
                        name: "FK_Places_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Places_CurrentOpeningHours_CurrentOpeningHoursId",
                        column: x => x.CurrentOpeningHoursId,
                        principalTable: "CurrentOpeningHours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_CurrentOpeningHours_RegularOpeningHoursId",
                        column: x => x.RegularOpeningHoursId,
                        principalTable: "CurrentOpeningHours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_DisplayName_DisplayNameId",
                        column: x => x.DisplayNameId,
                        principalTable: "DisplayName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_DisplayName_EditorialSummaryId",
                        column: x => x.EditorialSummaryId,
                        principalTable: "DisplayName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Places_DisplayName_PrimaryTypeDisplayNameId",
                        column: x => x.PrimaryTypeDisplayNameId,
                        principalTable: "DisplayName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GenerativeSummary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OverviewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReferencesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerativeSummary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenerativeSummary_DisplayName_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "DisplayName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GenerativeSummary_DisplayName_OverviewId",
                        column: x => x.OverviewId,
                        principalTable: "DisplayName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GenerativeSummary_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "PlaceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GenerativeSummary_References_ReferencesId",
                        column: x => x.ReferencesId,
                        principalTable: "References",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "PlaceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParkingOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaidParkingLot = table.Column<bool>(type: "bit", nullable: true),
                    PaidStreetParking = table.Column<bool>(type: "bit", nullable: true),
                    ValetParking = table.Column<bool>(type: "bit", nullable: true),
                    FreeStreetParking = table.Column<bool>(type: "bit", nullable: true),
                    FreeGarageParking = table.Column<bool>(type: "bit", nullable: true),
                    PaidGarageParking = table.Column<bool>(type: "bit", nullable: true),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParkingOptions_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "PlaceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AcceptsCreditCards = table.Column<bool>(type: "bit", nullable: false),
                    AcceptsDebitCards = table.Column<bool>(type: "bit", nullable: false),
                    AcceptsCashOnly = table.Column<bool>(type: "bit", nullable: false),
                    AcceptsNfc = table.Column<bool>(type: "bit", nullable: true),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentOptions_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "PlaceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WidthPx = table.Column<long>(type: "bigint", nullable: false),
                    HeightPx = table.Column<long>(type: "bigint", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photo_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "PlaceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlusCode",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GlobalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompoundCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlusCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlusCode_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "PlaceId");
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelativePublishTimeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<long>(type: "bigint", nullable: false),
                    TextId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OriginalTextId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AuthorAttributionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PublishTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReferencesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_AuthorAttribution_AuthorAttributionId",
                        column: x => x.AuthorAttributionId,
                        principalTable: "AuthorAttribution",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Review_DisplayName_OriginalTextId",
                        column: x => x.OriginalTextId,
                        principalTable: "DisplayName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Review_DisplayName_TextId",
                        column: x => x.TextId,
                        principalTable: "DisplayName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Review_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "PlaceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Review_References_ReferencesId",
                        column: x => x.ReferencesId,
                        principalTable: "References",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Viewport",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LowId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HighId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viewport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Viewport_Location_HighId",
                        column: x => x.HighId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Viewport_Location_LowId",
                        column: x => x.LowId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Viewport_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "PlaceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2054337-64af-437d-99cc-ec53dc25d127", null, "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_AccessibilityOptions_PlaceId",
                table: "AccessibilityOptions",
                column: "PlaceId",
                unique: true,
                filter: "[PlaceId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AddressComponent_PlaceId",
                table: "AddressComponent",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressDescriptor_PlaceId",
                table: "AddressDescriptor",
                column: "PlaceId",
                unique: true,
                filter: "[PlaceId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Area_AddressDescriptorId",
                table: "Area",
                column: "AddressDescriptorId");

            migrationBuilder.CreateIndex(
                name: "IX_Area_DisplayNameId",
                table: "Area",
                column: "DisplayNameId",
                unique: true,
                filter: "[DisplayNameId] IS NOT NULL");

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
                name: "IX_AuthorAttribution_PhotoId",
                table: "AuthorAttribution",
                column: "PhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_Circle_CenterId",
                table: "Circle",
                column: "CenterId",
                unique: true,
                filter: "[CenterId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Close_DateId",
                table: "Close",
                column: "DateId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentOpeningHours_PlaceCurrentSecondaryOpeningHoursId",
                table: "CurrentOpeningHours",
                column: "PlaceCurrentSecondaryOpeningHoursId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentOpeningHours_PlaceRegularSecondaryOpeningHoursId",
                table: "CurrentOpeningHours",
                column: "PlaceRegularSecondaryOpeningHoursId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerativeSummary_DescriptionId",
                table: "GenerativeSummary",
                column: "DescriptionId",
                unique: true,
                filter: "[DescriptionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GenerativeSummary_OverviewId",
                table: "GenerativeSummary",
                column: "OverviewId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenerativeSummary_PlaceId",
                table: "GenerativeSummary",
                column: "PlaceId",
                unique: true,
                filter: "[PlaceId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GenerativeSummary_ReferencesId",
                table: "GenerativeSummary",
                column: "ReferencesId");

            migrationBuilder.CreateIndex(
                name: "IX_Landmark_AddressDescriptorId",
                table: "Landmark",
                column: "AddressDescriptorId");

            migrationBuilder.CreateIndex(
                name: "IX_Landmark_DisplayNameId",
                table: "Landmark",
                column: "DisplayNameId",
                unique: true,
                filter: "[DisplayNameId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Location_PlaceId",
                table: "Location",
                column: "PlaceId",
                unique: true,
                filter: "[PlaceId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingOptions_PlaceId",
                table: "ParkingOptions",
                column: "PlaceId",
                unique: true,
                filter: "[PlaceId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOptions_PlaceId",
                table: "PaymentOptions",
                column: "PlaceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Period_CloseId",
                table: "Period",
                column: "CloseId",
                unique: true,
                filter: "[CloseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Period_CurrentOpeningHoursId",
                table: "Period",
                column: "CurrentOpeningHoursId");

            migrationBuilder.CreateIndex(
                name: "IX_Period_OpenId",
                table: "Period",
                column: "OpenId",
                unique: true,
                filter: "[OpenId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_PlaceId",
                table: "Photo",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Places_CurrentOpeningHoursId",
                table: "Places",
                column: "CurrentOpeningHoursId",
                unique: true,
                filter: "[CurrentOpeningHoursId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Places_DisplayNameId",
                table: "Places",
                column: "DisplayNameId",
                unique: true,
                filter: "[DisplayNameId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Places_EditorialSummaryId",
                table: "Places",
                column: "EditorialSummaryId",
                unique: true,
                filter: "[EditorialSummaryId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Places_PrimaryTypeDisplayNameId",
                table: "Places",
                column: "PrimaryTypeDisplayNameId",
                unique: true,
                filter: "[PrimaryTypeDisplayNameId] IS NOT NULL");

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
                name: "IX_PlusCode_PlaceId",
                table: "PlusCode",
                column: "PlaceId",
                unique: true,
                filter: "[PlaceId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Review_AuthorAttributionId",
                table: "Review",
                column: "AuthorAttributionId",
                unique: true,
                filter: "[AuthorAttributionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Review_OriginalTextId",
                table: "Review",
                column: "OriginalTextId",
                unique: true,
                filter: "[OriginalTextId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Review_PlaceId",
                table: "Review",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_ReferencesId",
                table: "Review",
                column: "ReferencesId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_TextId",
                table: "Review",
                column: "TextId",
                unique: true,
                filter: "[TextId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Viewport_HighId",
                table: "Viewport",
                column: "HighId",
                unique: true,
                filter: "[HighId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Viewport_LowId",
                table: "Viewport",
                column: "LowId",
                unique: true,
                filter: "[LowId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Viewport_PlaceId",
                table: "Viewport",
                column: "PlaceId",
                unique: true,
                filter: "[PlaceId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AccessibilityOptions_Places_PlaceId",
                table: "AccessibilityOptions",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressComponent_Places_PlaceId",
                table: "AddressComponent",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressDescriptor_Places_PlaceId",
                table: "AddressDescriptor",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorAttribution_Photo_PhotoId",
                table: "AuthorAttribution",
                column: "PhotoId",
                principalTable: "Photo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Circle_Location_CenterId",
                table: "Circle",
                column: "CenterId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CurrentOpeningHours_Places_PlaceCurrentSecondaryOpeningHoursId",
                table: "CurrentOpeningHours",
                column: "PlaceCurrentSecondaryOpeningHoursId",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CurrentOpeningHours_Places_PlaceRegularSecondaryOpeningHoursId",
                table: "CurrentOpeningHours",
                column: "PlaceRegularSecondaryOpeningHoursId",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurrentOpeningHours_Places_PlaceCurrentSecondaryOpeningHoursId",
                table: "CurrentOpeningHours");

            migrationBuilder.DropForeignKey(
                name: "FK_CurrentOpeningHours_Places_PlaceRegularSecondaryOpeningHoursId",
                table: "CurrentOpeningHours");

            migrationBuilder.DropTable(
                name: "AccessibilityOptions");

            migrationBuilder.DropTable(
                name: "AddressComponent");

            migrationBuilder.DropTable(
                name: "Area");

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
                name: "Circle");

            migrationBuilder.DropTable(
                name: "GenerativeSummary");

            migrationBuilder.DropTable(
                name: "Landmark");

            migrationBuilder.DropTable(
                name: "ParkingOptions");

            migrationBuilder.DropTable(
                name: "PaymentOptions");

            migrationBuilder.DropTable(
                name: "Period");

            migrationBuilder.DropTable(
                name: "PlusCode");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Viewport");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AddressDescriptor");

            migrationBuilder.DropTable(
                name: "Close");

            migrationBuilder.DropTable(
                name: "AuthorAttribution");

            migrationBuilder.DropTable(
                name: "References");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Date");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Places");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CurrentOpeningHours");

            migrationBuilder.DropTable(
                name: "DisplayName");
        }
    }
}
