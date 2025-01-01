using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BT.Data.Migrations
{
    /// <inheritdoc />
    public partial class _2401011504 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DonationCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    UserType = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: false),
                    IsRead = table.Column<bool>(type: "boolean", nullable: false),
                    SentAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ContactEmail = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ContactPhone = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    MissionStatement = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    OrganizationId = table.Column<int>(type: "integer", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: false),
                    FeedbackDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrganizationId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ProjectId = table.Column<int>(type: "integer", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    DonationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Notes = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donations_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectUpdates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProjectId = table.Column<int>(type: "integer", nullable: false),
                    UpdateTitle = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    UpdateBody = table.Column<string>(type: "text", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectUpdates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectUpdates_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VolunteerTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProjectId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VolunteerTasks_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VolunteerTasks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonationItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DonationId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    ItemName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Notes = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonationItems_DonationCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "DonationCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonationItems_Donations_DonationId",
                        column: x => x.DonationId,
                        principalTable: "Donations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonationLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DonationId = table.Column<int>(type: "integer", nullable: true),
                    LogMessage = table.Column<string>(type: "text", nullable: false),
                    LogDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonationLogs_Donations_DonationId",
                        column: x => x.DonationId,
                        principalTable: "Donations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VolunteerApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    TaskId = table.Column<int>(type: "integer", nullable: false),
                    ApplicationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VolunteerApplications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VolunteerApplications_VolunteerTasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "VolunteerTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DonationCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Items such as canned goods, rice, etc.", "Food Supplies" },
                    { 2, "Sustainable materials for environmental projects", "Eco Materials" },
                    { 3, "Food, toys, and equipment for pets", "Animal Supplies" },
                    { 4, "Books, stationery, and teaching aids", "Education Materials" },
                    { 5, "Tools and materials for cleaning activities", "Cleaning Supplies" },
                    { 6, "First aid kits, medicines, and equipment", "Medical Supplies" },
                    { 7, "Items for renovation and construction", "Building Materials" },
                    { 8, "Equipment for skill training.", "Vocational Tools" },
                    { 9, "Soap, sanitizer, and personal care items.", "Hygiene Kits" },
                    { 10, "Blankets, jackets, and other winter essentials.", "Winter Supplies" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Address", "ContactEmail", "ContactPhone", "CreatedAt", "MissionStatement", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "101 Charity Lane", "info@helpinghands.org", "555-9876", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "To support local communities.", "Helping Hands", null },
                    { 2, "202 Eco Way", "contact@greenearth.org", "555-5432", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "Promoting sustainable living.", "Green Earth", null },
                    { 3, "303 Pet Street", "contact@animalrescue.org", "555-6543", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "Saving stray animals.", "Animal Rescue", null },
                    { 4, "404 Hunger Lane", "info@foodbank.org", "555-3210", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "Providing meals to the homeless.", "Food Bank", null },
                    { 5, "505 Green Road", "contact@ecowarriors.org", "555-4321", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "Fighting for a cleaner planet.", "Eco Warriors", null },
                    { 6, "606 Knowledge Blvd", "info@educationfirst.org", "555-8765", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "Promoting education for all.", "Education First", null },
                    { 7, "707 Wellness Way", "contact@healthforall.org", "555-7654", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "Providing free healthcare services.", "Health for All", null },
                    { 8, "808 Haven Drive", "info@safeshelter.org", "555-6542", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "Shelter for the homeless.", "Safe Shelter", null },
                    { 9, "909 Growth Street", "contact@youthempower.org", "555-4444", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "Empowering young minds.", "Youth Empowerment", null },
                    { 10, "1000 Bright Lane", "info@cleanfuture.org", "555-3333", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "Creating a cleaner tomorrow.", "Clean Future", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[,]
                {
                    { 1, 0, "BaşakŞehir/İstanbul", "43e6c8b7-c1b1-472a-8571-c38842d2c2a6", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "senacindioglu@gmail.com", true, false, null, "Sena Cindioğlu", "SENACINDIOGLU@GMAIL.COM", "SENACINDIOGLU@GMAIL.COM", null, "905539555123", false, null, false, "senacindioglu@gmail.com", 0 },
                    { 2, 0, "123 Elm Street", "040cbb41-c9fd-4cda-8e86-ceb533a31214", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "john.doe@example.com", true, false, null, "John Doe", "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", null, "555-1234", false, null, false, "john.doe@example.com", 1 },
                    { 3, 0, "456 Oak Avenue", "4aba19c4-62f5-4bc1-a002-633e78671ced", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "jane.smith@example.com", true, false, null, "Jane Smith", "JANE.SMITH@EXAMPLE.COM", "JANE.SMITH@EXAMPLE.COM", null, "555-5678", false, null, false, "jane.smith@example.com", 3 },
                    { 4, 0, "789 Pine Road", "0812dbe6-4c5b-4c05-8271-4cfdefa6df9d", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "contact@helporg.org", true, false, null, "Help Org", "CONTACT@HELPORG.ORG", "CONTACT@HELPORG.ORG", null, null, false, null, false, "contact@helporg.org", 2 },
                    { 5, 0, "321 Birch Road", "3ae8362b-0a14-4d20-b5e1-76bfd02ee79a", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "alice.cooper@example.com", true, false, null, "Alice Cooper", "ALICE.COOPER@EXAMPLE.COM", "ALICE.COOPER@EXAMPLE.COM", null, "555-7890", false, null, false, "alice.cooper@example.com", 1 },
                    { 6, 0, "654 Spruce Street", "e08aa345-5ca5-417c-ba38-2c9a196de571", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "bob.marley@example.com", true, false, null, "Bob Marley", "BOB.MARLEY@EXAMPLE.COM", "BOB.MARLEY@EXAMPLE.COM", null, "555-6789", false, null, false, "bob.marley@example.com", 3 },
                    { 7, 0, "987 Cedar Avenue", "b815559f-1ccd-4db8-952c-f33133618de2", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "charity.group@example.com", true, false, null, "Charity Group", "CHARITY.GROUP@EXAMPLE.COM", "CHARITY.GROUP@EXAMPLE.COM", null, null, false, null, false, "charity.group@example.com", 2 },
                    { 8, 0, "789 Maple Lane", "cbc84531-edf8-49fa-ac1f-84b54698d33e", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "diana.ross@example.com", true, false, null, "Diana Ross", "DIANA.ROSS@EXAMPLE.COM", "DIANA.ROSS@EXAMPLE.COM", null, "555-3456", false, null, false, "diana.ross@example.com", 1 },
                    { 9, 0, "135 Willow Drive", "0f888b96-b76b-4e3b-8847-8f6ba211f009", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "edward.nigma@example.com", true, false, null, "Edward Nigma", "EDWARD.NIGMA@EXAMPLE.COM", "EDWARD.NIGMA@EXAMPLE.COM", null, "555-4567", false, null, false, "edward.nigma@example.com", 3 },
                    { 10, 0, "Wayne Manor", "3887fe1f-47c0-4d08-aa63-bdfd1585e507", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "bruce.wayne@example.com", true, false, null, "Bruce Wayne", "BRUCE.WAYNE@EXAMPLE.COM", "BRUCE.WAYNE@EXAMPLE.COM", null, "555-7777", false, null, false, "bruce.wayne@example.com", 1 },
                    { 11, 0, "Metropolis", "d49c47ac-6482-4e9a-93cc-e7ae5fbd73b4", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "clark.kent@example.com", true, false, null, "Clark Kent", "CLARK.KENT@EXAMPLE.COM", "CLARK.KENT@EXAMPLE.COM", null, "555-8888", false, null, false, "clark.kent@example.com", 3 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Comments", "FeedbackDate", "OrganizationId", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1, "Great initiative for the community!", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 1, 5, 1 },
                    { 2, "Well-organized event but could use more volunteers.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 2, 4, 2 },
                    { 3, "Loved being part of the animal adoption campaign.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 3, 5, 4 },
                    { 4, "The education fair was very informative.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 4, 4, 5 },
                    { 5, "Parks look amazing after the cleanup drive.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 5, 5, 6 },
                    { 6, "Healthcare camp was very beneficial.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 6, 4, 7 },
                    { 7, "Shelters look much better now.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 7, 5, 8 },
                    { 8, "Skill training was very helpful but could use more resources.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 8, 4, 2 },
                    { 9, "Recycling workshop was insightful!", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 9, 5, 9 },
                    { 10, "Mental health workshop was excellent.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 10, 5, 10 }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "IsRead", "Message", "SentAt", "UserId" },
                values: new object[,]
                {
                    { 1, false, "Thank you for your donation!", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 1 },
                    { 2, false, "Your volunteer application is approved.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 2 },
                    { 3, false, "Your donation was successfully processed.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 4 },
                    { 4, false, "Your volunteer task has been updated.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 5 },
                    { 5, false, "Thank you for participating in the healthcare camp.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 6 },
                    { 6, false, "The shelter renovation project is completed.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 7 },
                    { 7, false, "Training session schedule is now available.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 8 },
                    { 8, false, "Your volunteer application status has been updated.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 2 },
                    { 9, false, "Your recycling workshop slot is confirmed.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 9 },
                    { 10, false, "Join us for the mental health workshop.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), 10 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "EndDate", "OrganizationId", "StartDate", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "A project to distribute food to the needy.", new DateTime(2025, 1, 14, 21, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2024, 12, 31, 21, 0, 0, 0, DateTimeKind.Utc), 0, "Food Drive" },
                    { 2, "Planting trees in urban areas.", new DateTime(2025, 2, 27, 21, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2025, 1, 31, 21, 0, 0, 0, DateTimeKind.Utc), 2, "Tree Plantation" },
                    { 3, "Finding homes for stray animals.", new DateTime(2025, 3, 14, 21, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2025, 2, 28, 21, 0, 0, 0, DateTimeKind.Utc), 0, "Animal Adoption" },
                    { 4, "Promoting education opportunities.", new DateTime(2025, 4, 14, 21, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2025, 3, 31, 21, 0, 0, 0, DateTimeKind.Utc), 2, "Education Fair" },
                    { 5, "Cleaning up local parks.", new DateTime(2025, 5, 14, 21, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2025, 4, 30, 21, 0, 0, 0, DateTimeKind.Utc), 0, "Clean Up Drive" },
                    { 6, "Providing free medical checkups.", new DateTime(2025, 6, 14, 21, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2025, 5, 31, 21, 0, 0, 0, DateTimeKind.Utc), 2, "Healthcare Camp" },
                    { 7, "Renovating shelters for the homeless.", new DateTime(2025, 7, 14, 21, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2025, 6, 30, 21, 0, 0, 0, DateTimeKind.Utc), 0, "Shelter Renovation" },
                    { 8, "Providing vocational training to unemployed individuals.", new DateTime(2025, 8, 14, 21, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2025, 7, 31, 21, 0, 0, 0, DateTimeKind.Utc), 2, "Skill Training" },
                    { 9, "Reducing plastic waste through recycling.", new DateTime(2025, 9, 29, 21, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2025, 8, 31, 21, 0, 0, 0, DateTimeKind.Utc), 2, "Plastic Recycling Initiative" },
                    { 10, "Promoting mental wellness in the community.", new DateTime(2025, 10, 19, 21, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2025, 9, 30, 21, 0, 0, 0, DateTimeKind.Utc), 0, "Mental Health Workshop" }
                });

            migrationBuilder.InsertData(
                table: "Donations",
                columns: new[] { "Id", "Amount", "DonationDate", "Notes", "ProjectId", "UserId" },
                values: new object[,]
                {
                    { 1, 100.00m, new DateTime(2025, 1, 1, 21, 0, 0, 0, DateTimeKind.Utc), "Donation for food supplies", 1, 1 },
                    { 2, 50.00m, new DateTime(2025, 1, 31, 21, 0, 0, 0, DateTimeKind.Utc), "For tree plantation materials", 1, 2 },
                    { 3, 200.00m, new DateTime(2025, 3, 1, 21, 0, 0, 0, DateTimeKind.Utc), "For animal adoption campaign", 4, 3 },
                    { 4, 150.00m, new DateTime(2025, 4, 4, 21, 0, 0, 0, DateTimeKind.Utc), "Support for education fair", 5, 4 },
                    { 5, 75.00m, new DateTime(2025, 5, 5, 21, 0, 0, 0, DateTimeKind.Utc), "Cleaning tools and supplies", 7, 5 },
                    { 6, 300.00m, new DateTime(2025, 6, 6, 21, 0, 0, 0, DateTimeKind.Utc), "Medical equipment for healthcare camp", 8, 6 },
                    { 7, 100.00m, new DateTime(2025, 7, 7, 21, 0, 0, 0, DateTimeKind.Utc), "Building materials for renovation", 4, 7 },
                    { 8, 50.00m, new DateTime(2025, 8, 8, 21, 0, 0, 0, DateTimeKind.Utc), "Training materials for skill training.", 5, 8 },
                    { 9, 250.00m, new DateTime(2025, 9, 14, 21, 0, 0, 0, DateTimeKind.Utc), "Support for recycling initiative", 9, 9 },
                    { 10, 180.00m, new DateTime(2025, 10, 11, 21, 0, 0, 0, DateTimeKind.Utc), "Support for mental health workshop.", 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "ProjectUpdates",
                columns: new[] { "Id", "ProjectId", "UpdateBody", "UpdateDate", "UpdateTitle" },
                values: new object[,]
                {
                    { 1, 1, "We successfully delivered 500 food packages.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "Food Packages Delivered" },
                    { 2, 2, "100 trees were planted in the city park.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "Trees Planted" },
                    { 3, 3, "20 pets found loving homes.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "Animal Adoption Success" },
                    { 4, 4, "Dates and locations for the fair are finalized.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "Education Fair Scheduled" },
                    { 5, 5, "Local parks are now spotless and welcoming.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "Cleanup Drive Completed" },
                    { 6, 6, "Over 200 individuals benefited from the camp.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "Healthcare Camp Report" },
                    { 7, 7, "Shelters are ready for use by the needy.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "Shelter Renovation Done" },
                    { 8, 8, "Training sessions started successfully.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "Skill Training Begun" },
                    { 9, 9, "50 participants learned about recycling.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "Plastic Recycling Workshop Held" },
                    { 10, 10, "Over 100 attendees benefited.", new DateTime(2024, 12, 21, 10, 12, 52, 340, DateTimeKind.Utc).AddTicks(9460), "Mental Health Workshop Success" }
                });

            migrationBuilder.InsertData(
                table: "VolunteerTasks",
                columns: new[] { "Id", "Date", "Description", "ProjectId", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 9, 21, 0, 0, 0, DateTimeKind.Utc), "Distribute food packages", 2, 2, 1 },
                    { 2, new DateTime(2025, 2, 9, 21, 0, 0, 0, DateTimeKind.Utc), "Plant trees in designated areas", 2, 2, 2 },
                    { 3, new DateTime(2025, 3, 10, 21, 0, 0, 0, DateTimeKind.Utc), "Assist with animal adoption event", 2, 2, 3 },
                    { 4, new DateTime(2025, 4, 11, 21, 0, 0, 0, DateTimeKind.Utc), "Set up booths for education fair", 5, 2, 4 },
                    { 5, new DateTime(2025, 5, 12, 21, 0, 0, 0, DateTimeKind.Utc), "Organize volunteers for park cleanup", 6, 2, 5 },
                    { 6, new DateTime(2025, 6, 13, 21, 0, 0, 0, DateTimeKind.Utc), "Coordinate medical staff for camp", 7, 2, 6 },
                    { 7, new DateTime(2025, 7, 14, 21, 0, 0, 0, DateTimeKind.Utc), "Assist in shelter renovation", 8, 2, 7 },
                    { 8, new DateTime(2025, 8, 15, 21, 0, 0, 0, DateTimeKind.Utc), "Prepare training materials", 2, 2, 8 },
                    { 9, new DateTime(2025, 9, 4, 21, 0, 0, 0, DateTimeKind.Utc), "Assist in recycling workshop", 9, 2, 9 },
                    { 10, new DateTime(2025, 10, 9, 21, 0, 0, 0, DateTimeKind.Utc), "Coordinate mental health workshop logistics", 10, 2, 10 }
                });

            migrationBuilder.InsertData(
                table: "DonationItems",
                columns: new[] { "Id", "CategoryId", "DonationId", "ItemName", "Notes", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, "Canned Beans", "For food distribution", 100 },
                    { 2, 2, 2, "Tree Saplings", "For urban plantation project", 50 },
                    { 3, 3, 3, "Dog Food", "For animal rescue efforts", 30 },
                    { 4, 4, 4, "Notebooks", "For education fair distribution", 200 },
                    { 5, 5, 5, "Trash Bags", "Used in park cleanup", 500 },
                    { 6, 6, 6, "First Aid Kits", "For healthcare camp", 20 },
                    { 7, 7, 7, "Cement Bags", "Used in shelter renovation", 40 },
                    { 8, 8, 8, "Toolkits", "For skill training.", 15 },
                    { 9, 9, 9, "Plastic Bottles", "Collected for recycling.", 100 },
                    { 10, 10, 10, "Stress Balls", "For mental health workshop.", 50 }
                });

            migrationBuilder.InsertData(
                table: "VolunteerApplications",
                columns: new[] { "Id", "ApplicationDate", "Status", "TaskId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 4, 21, 0, 0, 0, DateTimeKind.Utc), 1, 1, 2 },
                    { 2, new DateTime(2025, 1, 19, 21, 0, 0, 0, DateTimeKind.Utc), 0, 2, 2 },
                    { 3, new DateTime(2025, 2, 21, 21, 0, 0, 0, DateTimeKind.Utc), 1, 3, 5 },
                    { 4, new DateTime(2025, 3, 11, 21, 0, 0, 0, DateTimeKind.Utc), 1, 4, 6 },
                    { 5, new DateTime(2025, 4, 17, 21, 0, 0, 0, DateTimeKind.Utc), 0, 5, 7 },
                    { 6, new DateTime(2025, 5, 19, 21, 0, 0, 0, DateTimeKind.Utc), 1, 6, 8 },
                    { 7, new DateTime(2025, 6, 21, 21, 0, 0, 0, DateTimeKind.Utc), 0, 7, 2 },
                    { 8, new DateTime(2025, 7, 23, 21, 0, 0, 0, DateTimeKind.Utc), 1, 8, 4 },
                    { 9, new DateTime(2025, 9, 9, 21, 0, 0, 0, DateTimeKind.Utc), 1, 9, 9 },
                    { 10, new DateTime(2025, 10, 14, 21, 0, 0, 0, DateTimeKind.Utc), 1, 10, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DonationItems_CategoryId",
                table: "DonationItems",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationItems_DonationId",
                table: "DonationItems",
                column: "DonationId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationLogs_DonationId",
                table: "DonationLogs",
                column: "DonationId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_ProjectId",
                table: "Donations",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_UserId",
                table: "Donations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_OrganizationId",
                table: "Feedbacks",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedbacks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_UserId",
                table: "Organizations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_OrganizationId",
                table: "Projects",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUpdates_ProjectId",
                table: "ProjectUpdates",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerApplications_TaskId",
                table: "VolunteerApplications",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerApplications_UserId",
                table: "VolunteerApplications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerTasks_ProjectId",
                table: "VolunteerTasks",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerTasks_UserId",
                table: "VolunteerTasks",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DonationItems");

            migrationBuilder.DropTable(
                name: "DonationLogs");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "ProjectUpdates");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "VolunteerApplications");

            migrationBuilder.DropTable(
                name: "DonationCategories");

            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "VolunteerTasks");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
