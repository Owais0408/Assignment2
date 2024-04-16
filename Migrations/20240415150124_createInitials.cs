using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GBCTravel.Migrations
{
    /// <inheritdoc />
    public partial class createInitials : Migration
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
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookingtype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    BookingDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DailyRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Airline = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartureTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricePerNight = table.Column<float>(type: "real", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.Id);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingDate", "bookingtype", "price" },
                values: new object[] { 1, new DateOnly(2024, 4, 15), "Car", 20.0 });

            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "Id", "Brand", "Color", "DailyRate", "IsAvailable", "Model" },
                values: new object[,]
                {
                    { 1, "Toyota", "Blue", 50m, true, "Corolla" },
                    { 2, "Honda", "Black", 60m, true, "Civic" },
                    { 3, "Ford", "White", 55m, false, "Focus" },
                    { 4, "Chevrolet", "Silver", 45m, true, "Malibu" },
                    { 5, "Nissan", "Red", 48m, true, "Altima" },
                    { 6, "BMW", "Gray", 70m, true, "3 Series" },
                    { 7, "Mercedes-Benz", "Black", 80m, false, "C-Class" },
                    { 8, "Audi", "White", 75m, true, "A4" },
                    { 9, "Volkswagen", "Blue", 52m, true, "Jetta" },
                    { 10, "Hyundai", "Silver", 47m, true, "Elantra" },
                    { 11, "Kia", "White", 53m, true, "Forte" },
                    { 12, "Subaru", "Blue", 55m, false, "Legacy" },
                    { 13, "Mazda", "Red", 49m, true, "Mazda3" },
                    { 14, "Lexus", "Black", 85m, true, "IS" },
                    { 15, "Infiniti", "Gray", 78m, true, "Q60" },
                    { 16, "Tesla", "White", 90m, true, "Model 3" },
                    { 17, "Porsche", "Red", 150m, true, "911" },
                    { 18, "Jaguar", "Blue", 120m, true, "XE" },
                    { 19, "Land Rover", "Green", 110m, true, "Discovery" },
                    { 20, "Volvo", "Silver", 65m, true, "S60" },
                    { 21, "Jeep", "Yellow", 80m, true, "Wrangler" },
                    { 22, "Toyota", "Black", 55m, false, "Rav4" },
                    { 23, "Ford", "White", 58m, true, "Edge" },
                    { 24, "Honda", "Silver", 63m, true, "HR-V" },
                    { 25, "Chevrolet", "Black", 70m, true, "Trax" },
                    { 26, "Subaru", "Green", 80m, true, "Crosstrek" },
                    { 27, "Mazda", "Blue", 68m, true, "CX-3" },
                    { 28, "Toyota", "Red", 72m, true, "Tacoma" },
                    { 29, "Ford", "Gray", 66m, true, "Expedition" },
                    { 30, "Hyundai", "Silver", 58m, true, "Tucson" }
                });

            migrationBuilder.InsertData(
                table: "Flight",
                columns: new[] { "Id", "Airline", "ArrivalTime", "DepartureTime", "Destination", "Origin", "Price" },
                values: new object[,]
                {
                    { 1, "Emirates", new DateTime(2024, 4, 16, 1, 1, 23, 652, DateTimeKind.Local).AddTicks(7084), new DateTime(2024, 4, 15, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7079), "JFK", "DXB", 800.00m },
                    { 2, "British Airways", new DateTime(2024, 4, 16, 22, 1, 23, 652, DateTimeKind.Local).AddTicks(7097), new DateTime(2024, 4, 16, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7092), "SFO", "LHR", 900.00m },
                    { 3, "American Airlines", new DateTime(2024, 4, 17, 14, 1, 23, 652, DateTimeKind.Local).AddTicks(7107), new DateTime(2024, 4, 17, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7103), "ORD", "JFK", 300.00m },
                    { 4, "Qantas", new DateTime(2024, 4, 19, 0, 1, 23, 652, DateTimeKind.Local).AddTicks(7117), new DateTime(2024, 4, 18, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7113), "LAX", "SYD", 1000.00m },
                    { 5, "Air Canada", new DateTime(2024, 4, 19, 18, 1, 23, 652, DateTimeKind.Local).AddTicks(7126), new DateTime(2024, 4, 19, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7122), "LHR", "YYZ", 700.00m },
                    { 6, "Lufthansa", new DateTime(2024, 4, 20, 20, 1, 23, 652, DateTimeKind.Local).AddTicks(7135), new DateTime(2024, 4, 20, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7132), "JFK", "FRA", 850.00m },
                    { 7, "Singapore Airlines", new DateTime(2024, 4, 21, 15, 1, 23, 652, DateTimeKind.Local).AddTicks(7145), new DateTime(2024, 4, 21, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7141), "HKG", "SIN", 400.00m },
                    { 8, "Cathay Pacific", new DateTime(2024, 4, 22, 23, 1, 23, 652, DateTimeKind.Local).AddTicks(7154), new DateTime(2024, 4, 22, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7151), "LAX", "HKG", 950.00m },
                    { 9, "United Airlines", new DateTime(2024, 4, 23, 16, 1, 23, 652, DateTimeKind.Local).AddTicks(7164), new DateTime(2024, 4, 23, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7160), "SFO", "ORD", 600.00m },
                    { 10, "Delta Air Lines", new DateTime(2024, 4, 24, 13, 1, 23, 652, DateTimeKind.Local).AddTicks(7173), new DateTime(2024, 4, 24, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7170), "LGA", "ATL", 250.00m },
                    { 11, "Southwest Airlines", new DateTime(2024, 4, 25, 12, 1, 23, 652, DateTimeKind.Local).AddTicks(7183), new DateTime(2024, 4, 25, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7179), "HOU", "DAL", 150.00m },
                    { 12, "Air France", new DateTime(2024, 4, 26, 22, 1, 23, 652, DateTimeKind.Local).AddTicks(7193), new DateTime(2024, 4, 26, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7189), "LAX", "CDG", 900.00m },
                    { 13, "KLM Royal Dutch Airlines", new DateTime(2024, 4, 27, 19, 1, 23, 652, DateTimeKind.Local).AddTicks(7202), new DateTime(2024, 4, 27, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7198), "JFK", "AMS", 800.00m },
                    { 14, "Qatar Airways", new DateTime(2024, 4, 28, 18, 1, 23, 652, DateTimeKind.Local).AddTicks(7212), new DateTime(2024, 4, 28, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7208), "LHR", "DOH", 700.00m },
                    { 15, "Virgin Atlantic", new DateTime(2024, 4, 29, 19, 1, 23, 652, DateTimeKind.Local).AddTicks(7221), new DateTime(2024, 4, 29, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7217), "JFK", "LHR", 850.00m },
                    { 16, "Turkish Airlines", new DateTime(2024, 5, 1, 0, 1, 23, 652, DateTimeKind.Local).AddTicks(7231), new DateTime(2024, 4, 30, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7227), "SFO", "IST", 950.00m },
                    { 17, "Swiss International Air Lines", new DateTime(2024, 5, 1, 21, 1, 23, 652, DateTimeKind.Local).AddTicks(7240), new DateTime(2024, 5, 1, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7236), "ORD", "ZRH", 750.00m },
                    { 18, "Etihad Airways", new DateTime(2024, 5, 3, 2, 1, 23, 652, DateTimeKind.Local).AddTicks(7249), new DateTime(2024, 5, 2, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7246), "LAX", "AUH", 1100.00m },
                    { 19, "Finnair", new DateTime(2024, 5, 3, 20, 1, 23, 652, DateTimeKind.Local).AddTicks(7259), new DateTime(2024, 5, 3, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7255), "JFK", "HEL", 800.00m },
                    { 20, "Aeroflot", new DateTime(2024, 5, 4, 23, 1, 23, 652, DateTimeKind.Local).AddTicks(7268), new DateTime(2024, 5, 4, 11, 1, 23, 652, DateTimeKind.Local).AddTicks(7265), "LAX", "SVO", 1000.00m }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "ImageUrl", "Location", "Name", "PricePerNight", "RoomNumber", "status" },
                values: new object[,]
                {
                    { 1, "https://tse4.mm.bing.net/th?id=OIP.hE1EAKib61djIy0oT6p1pwHaEo&pid=Api&P=0&h=180", "Thailand", "Royal Orchid Palace", 1800f, 0, true },
                    { 2, "https://tse2.mm.bing.net/th?id=OIP.nY9p3m9fkYlaNAGErx02EQHaEx&pid=Api&P=0&h=180", "Maldives", "Paradise Resort", 2500f, 0, true },
                    { 3, "https://tse2.mm.bing.net/th?id=OIP.4rlEynHtw33lqN3HwWHe0QAAAA&pid=Api&P=0&h=180", "Bali", "Sunset View Hotel", 2000f, 0, true },
                    { 4, "https://tse4.mm.bing.net/th?id=OIP.GWsjuIpVJdRUZPMQsMcFcQHaE8&pid=Api&P=0&h=180", "Dubai", "Grand Mirage", 3000f, 0, true },
                    { 5, "https://tse4.mm.bing.net/th?id=OIP.HkxrmC__Yr2oPED3RPHJkwHaEN&pid=Api&P=0&h=180", "Hawaii", "Oceanfront Suites", 2800f, 0, true },
                    { 6, "https://tse4.mm.bing.net/th?id=OIP.AQFl8i6B-Y9iBWIIaSk9uAHaE7&pid=Api&P=0&h=180", "Switzerland", "Mountain Vista Inn", 2200f, 0, true },
                    { 7, "https://tse2.mm.bing.net/th?id=OIP.9JFne8p7tuUYC5qk2EUhcgHaEK&pid=Api&P=0&h=180", "Australia", "Coral Sands Resort", 1900f, 0, true },
                    { 8, "https://tse4.mm.bing.net/th?id=OIP.AiVqKkzPME1Noqt1GhdmSwHaE8&pid=Api&P=0&h=180", "Canada", "Riverfront Retreat", 2100f, 0, true },
                    { 9, "https://tse2.mm.bing.net/th?id=OIP.Ryamq96jtDOKId2Zit8kOAHaE7&pid=Api&P=0&h=180", "Norway", "Cozy Cabin Lodge", 2300f, 0, true },
                    { 10, "https://tse1.mm.bing.net/th?id=OIP.C8vkMkOyrfmnMcDY6SZTbgHaEP&pid=Api&P=0&h=180", "Greece", "Sapphire Shores Hotel", 2600f, 0, true },
                    { 11, "https://tse4.mm.bing.net/th?id=OIP.nizjMP3ZtJd3SKjsopQnZgHaEo&pid=Api&P=0&h=180", "Fiji", "Silver Lagoon Resort", 2700f, 0, true },
                    { 12, "https://tse2.mm.bing.net/th?id=OIP.jmrYqoE15FukY39kaMSPRAHaE8&pid=Api&P=0&h=180", "Jamaica", "Emerald Bay Hotel", 2400f, 0, true },
                    { 13, "https://tse3.mm.bing.net/th?id=OIP.takzeirYv2xe0_zF4cT9HwHaD7&pid=Api&P=0&h=180", "Bahamas", "Golden Sands Inn", 3200f, 0, true },
                    { 14, "https://tse2.mm.bing.net/th?id=OIP.JCegYJ7Bsc6G6x6V7Ua52wHaE6&pid=Api&P=0&h=180", "Monaco", "Platinum Heights", 2900f, 0, true },
                    { 15, "https://tse4.mm.bing.net/th?id=OIP.siWf5qBoGWFQH_gNmvjaOAAAAA&pid=Api&P=0&h=180", "Barbados", "Diamond Crest Resort", 3100f, 0, true }
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Flight");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
