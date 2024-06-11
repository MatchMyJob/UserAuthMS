using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", null, "company", "COMPANY" },
                    { "2048b194-4cda-4320-8b72-c169b4788fe9", null, "admin", "ADMIN" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", null, "jobuser", "JOBUSER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "02bdfba1-5d7d-46f8-89c7-5d02a5fc7655", 0, "7de645bc-228f-420e-b2f2-441e3be7e078", "rrhh@accusys.com.ar", true, false, null, "RRHH@ACCUSYS.COM.AR", "ACCUSYSTECHNOLOGY", "AQAAAAIAAYagAAAAEPuJ0Gd3LHHgmnHtUZiEs7KBGkiLCWSH+5IjeOVUM2uq1HV1CoWy+7bbcYZWXgkn6g==", null, false, "0ee3649e-5a58-478a-9eef-02a50c6dc60b", false, "AccusysTechnology" },
                    { "0497ee14-d660-49a1-916d-8d2391ba6cf2", 0, "ca9bc5ca-26bf-4972-afb0-0daf9a82780e", "marcosperez@outlook.com", true, false, null, "MARCOSPEREZ@OUTLOOK.COM", "MARCOS43", "AQAAAAIAAYagAAAAEAuaOkOQMZtfrjMHjl92MCaQZTQZYiIdwGXCV+Nl1zSsDPPE/q7nyRjh3SSoBWPMUw==", null, false, "a8bb170f-b458-43c6-a07f-723e503834c9", false, "Marcos43" },
                    { "0835e1cc-d304-4b61-9b58-135ab2d27b3f", 0, "ed3da1c2-090b-4abb-9b52-a6e0b8d3d05b", "gloriaramos@gmail.com", true, false, null, "GLORIARAMOS@GMAIL.COM", "GLORIA22", "AQAAAAIAAYagAAAAEEFQHF48yIp17gz0MentnIPWFKiJJGcY/SFBkYQ8YrEiEgZ3YxYrz2/qz+e7D9u69A==", null, false, "b1c7d258-6ef2-45ec-bf73-f49d4266350f", false, "Gloria22" },
                    { "09260ec0-0368-4da8-80d5-6e8b9c574920", 0, "5e7afe70-0656-4457-b305-875caa15969c", "rrhh@quickpassweb.com", true, false, null, "RRHH@QUICKPASSWEB.COM", "QUICKPASS", "AQAAAAIAAYagAAAAENc0kzUAfiCNEH4lxVIlzDa69Owt//FTJ/oW5r0wLmZXzLAs2La5JvB6jKbZQVwqIA==", null, false, "ba3b9e5a-b7ba-4816-9689-257c2c70a9ef", false, "QuickPass" },
                    { "0b450794-1b65-4d42-8df7-05b57b970454", 0, "07ba7dd4-98d4-46e0-9aa7-e08cf7ed054b", "jose99@gmail.com", true, false, null, "JOSE99@GMAIL.COM", "JOSE99", "AQAAAAIAAYagAAAAECitehtO2ynLXTyuzsdUVwBKARq9TZEdIYB4XNsLMUWr8EF+VmLJDymdNbkOLwJ/VA==", null, false, "9fbbbe8f-a5cb-44b3-8c9a-78dbad493e83", false, "Jose99" },
                    { "0d4ad714-56a4-4bfc-b4b4-d776cfd51fd8", 0, "c1308059-4b96-4133-b38e-23e7ab9c6ec1", "rrhhtca@telecom.com.ar", true, false, null, "RRHHTCA@TELECOM.COM.AR", "TELECOMARGENTINA", "AQAAAAIAAYagAAAAEJgBpjXFQSHUl94cWnKDnKGwrZMEUPsfpDcOwZhUsBR5bODGRiJJe6XAn+MTDaIJhA==", null, false, "3837cecf-f672-4d5d-8824-05d6c2075922", false, "TelecomArgentina" },
                    { "0e5a9aab-eb68-4ca9-8b80-ea7bef076946", 0, "3dfeba26-38cb-4954-a02c-17ed997d9328", "laura11@yahoo.com", true, false, null, "LAURA11@YAHOO.COM", "LAURA11", "AQAAAAIAAYagAAAAEP+LDyYkGkWui3FxIAi0kmdxDDKNMKjvhoDziLdjKZKOBhebZaYgZ1yCpJGQJ7fJDg==", null, false, "eb1b6839-b996-4e77-812c-453e7ea892e7", false, "Laura11" },
                    { "1199aa46-b03b-4cc4-921e-62b08fd5247f", 0, "4ff60d66-199f-4e2c-a2c1-f91082182b04", "rosagonzalez@outlook.com", true, false, null, "ROSAGONZALEZ@OUTLOOK.COM", "ROSA78", "AQAAAAIAAYagAAAAEBSEH3ibae9MbdPdEMA/fOWiQgBKpwnbZQ1XQ0BMJL/Rr6XYkXJhbanlRg9b4OF+Ug==", null, false, "9e5a2027-dad7-4066-9f8f-6bed9f2a6104", false, "Rosa78" },
                    { "153ff2f4-ccb7-43b1-b163-8f995adb1d13", 0, "725551e3-439d-47de-b7ef-3b170c0bcb4c", "diego77@yahoo.com", true, false, null, "DIEGO77@YAHOO.COM", "DIEGO77", "AQAAAAIAAYagAAAAEIXWDLZQceoRx9dUu0Xbz1lAX5C1HznUw7i7D8oXBq4CGStXTlIfbTdi4/DW9OvySg==", null, false, "fe976deb-9dc9-4645-b2d5-b2251189d300", false, "Diego77" },
                    { "17923d13-ffa5-4e87-9cab-3b313d44b3ea", 0, "181d3ef4-1da6-49c6-af1f-3e9bc66965a8", "ignacio@outlook.com", true, false, null, "IGNACIO@OUTLOOK.COM", "IGNACIO99", "AQAAAAIAAYagAAAAEAoOO2yc6l5dBsGnByVVpaaSeFwJu7GVIQuIVtEDzlZSxojHYF9T2LU/dQtvKYhQXw==", null, false, "79e4d34e-83c4-4830-a7f2-31d8c2cadfcc", false, "Ignacio99" },
                    { "19d1cc4c-18e4-42fc-9cbd-56253b20165e", 0, "d7040660-4c53-4e4b-9907-70f5b857cd7e", "claudiaramirez@outlook.com", true, false, null, "CLAUDIARAMIREZ@OUTLOOK.COM", "CLAUDIA67", "AQAAAAIAAYagAAAAEPqKpexvCx0DeblkuUoRjt6WJJdFp6H/BLLHbStVoD8YlojK5avi3biiobz/Y1G7aQ==", null, false, "c4bc951f-38dc-48d8-bab1-8e407196ad44", false, "Claudia67" },
                    { "1b29f96a-23e1-4824-9e66-775d807af9ae", 0, "9abe6b57-0862-43fb-8f33-3c6f22f9d4ec", "carmenflores@hotmail.com", true, false, null, "CARMENFLORES@HOTMAIL.COM", "CARMEN56", "AQAAAAIAAYagAAAAEOfvPCkFjkvv29PtWZtCy9dif1dRvIOsxEuSBj0KMO9CPQrSdpRlKHmnlAt7y6NFXw==", null, false, "35603235-6f9f-4db2-b499-e286c44e0dee", false, "Carmen56" },
                    { "1cdb46ef-e0a5-427c-8409-9a58cde54ce9", 0, "d07a3657-5de7-430f-897b-7d444a122eda", "luis22@hotmail.com", true, false, null, "LUIS22@HOTMAIL.COM", "LUIS22", "AQAAAAIAAYagAAAAEA9dpDJgO24KVpu0MboVgYZktASlXNsHGtMCTfQRoMZ4d9uKWZeWX9S6LlE387wzmw==", null, false, "d15ee28c-31d3-4af0-abd0-744232d56e3c", false, "Luis22" },
                    { "20b9c66b-7518-4cbc-aa39-f8bf41f0a423", 0, "5541249d-5934-4837-8a8c-56893161f9f6", "fernando33@gmail.com", true, false, null, "FERNANDO33@GMAIL.COM", "FERNANDO33", "AQAAAAIAAYagAAAAEMI8iCJnOneuezNfVflwImacgVDTa4BAtHNKLSqYoKI3Xpl/foOkDSVBrdlTHBAyOg==", null, false, "5bffe83b-e9eb-43e6-8a84-375908657131", false, "Fernando33" },
                    { "2301041e-8c28-4711-b70d-9daed300ae21", 0, "2896f4a3-525e-4040-a684-24b94f5c7858", "victorgarcia@outlook.com", true, false, null, "VICTORGARCIA@OUTLOOK.COM", "VICTOR88", "AQAAAAIAAYagAAAAEHUxYauJSBPuR68hh9mzqITwn43YtobqfS3C5sZgdeztZQwlIIN6FuIDJIHQLCfBGw==", null, false, "cd345dec-1a97-427a-a6a2-b92ba9cc2060", false, "Victor88" },
                    { "2641ba50-9bdf-4107-80e8-a723e7feb06e", 0, "3eb1cf5b-ea09-4627-965e-37d571016904", "miriamlopez@outlook.com", true, false, null, "MIRIAMLOPEZ@OUTLOOK.COM", "MIRIAM12", "AQAAAAIAAYagAAAAEIrn80ukI7sAxj2HZ8yM8D598ethsm9rGjvNhMTn73YI5XrijgQYQDklFwiTfVWg6w==", null, false, "4528539b-a626-4f87-ac16-e22f38426d7f", false, "Miriam12" },
                    { "2a913313-dc4c-4f93-a1be-3fc5568e00b1", 0, "16e128cf-0be7-46e8-87eb-1cbcc42a8e8a", "rrhh@axoft.com", true, false, null, "RRHH@AXOFT.COM", "AXOFT", "AQAAAAIAAYagAAAAEP1wwUeKWkFoYUDcr7k2fNXSd99BDVNRgKDmdOk6otqOmI5cV9GhPUU2F6waYUurQA==", null, false, "8beac74e-db47-4bbb-84b6-e313bef83654", false, "Axoft" },
                    { "2d624f65-a74a-4011-a187-862f58df7885", 0, "4cf86ee9-efdc-4ca3-b440-e86840fac261", "patriciaflores@outlook.com", true, false, null, "PATRICIAFLORES@OUTLOOK.COM", "PATRICIA99", "AQAAAAIAAYagAAAAEA+uRlxSk8NTAYX4jJkdRA+UxlpiTIzwoe5zuXdGgRQQhel8c8pGFkNRyrGV2fVhxw==", null, false, "26379216-fdc0-4f0e-b02c-160691ae3642", false, "Patricia99" },
                    { "2f5c9c2f-de8c-4396-90af-534f4e163439", 0, "800e3b27-2777-4171-b108-fab0bb7660fe", "pedrogomez@hotmail.com", true, false, null, "PEDROGOMEZ@HOTMAIL.COM", "PEDRO78", "AQAAAAIAAYagAAAAEAP2uMu8Ds8wHrlcR+Rvc1X7lJorH/sKNe07IOFDbodIipa9ngzCZmikuHcjP29fng==", null, false, "734a1c57-3030-43ca-b6db-4edeb23ff745", false, "Pedro78" },
                    { "31105ee2-5a05-4bcf-bff7-f07be401442e", 0, "17e20fd2-7426-4aba-ba9c-736895c400de", "maria33@gmail.com", true, false, null, "MARIA33@GMAIL.COM", "MARIA33", "AQAAAAIAAYagAAAAEGF+zeCW0+1qnHNivGwE05j/TqkVssYLP0KU8JJLUwjCco8Wtz+2/ePTsgYtW2Ko4Q==", null, false, "35115695-4380-4a02-bbed-2128df711a48", false, "Maria33" },
                    { "31550335-200e-442a-9cca-f1d0f62c0819", 0, "e71579ed-7ba1-439b-8d43-657bf7eaf9ea", "andrearamirez@outlook.com", true, false, null, "ANDREARAMIREZ@OUTLOOK.COM", "ANDREA43", "AQAAAAIAAYagAAAAEB6lXLmd73llOIfx+uYq+/pOvpjc6jO1aq7+Y6uEjNO1SR3wQQtCOS3jv38JS7CnOQ==", null, false, "2038fd4e-5f28-43f7-bd4b-709fcad4a37e", false, "Andrea43" },
                    { "347c951c-16c5-4043-bedc-a847c40fcb7f", 0, "c7d33c6b-ae57-42e9-b0fd-3a096ea54c50", "alejandro@hotmail.com", true, false, null, "ALEJANDRO@HOTMAIL.COM", "ALEJANDRO22", "AQAAAAIAAYagAAAAEGBKAIPURS19OQzNoK2XGMm5cO26p/yH19dYr/1GRqnqLgug4kFHd6k609W2aq2bfw==", null, false, "1975aab8-60dd-4432-87df-301018d159d5", false, "Alejandro22" },
                    { "35a26eb2-c01c-4df3-b98d-40561190ae36", 0, "aabeadd0-66c9-4044-95e3-89546dc01e7d", "carmenlopez@gmail.com", true, false, null, "CARMENLOPEZ@GMAIL.COM", "CARMEN78", "AQAAAAIAAYagAAAAEFacumA2MtN8lCx2vKMzYAlfPGVEY1OkQN019vu6oCclJfdBtAyc1T1GhEU1PfVQWw==", null, false, "5c20c390-5e83-4d87-be10-6f779e5fe868", false, "Carmen78" },
                    { "37991d47-ddc6-400b-a3fe-b17b998a76b2", 0, "b50bf4a3-d409-4048-a2dc-faf070cd8544", "lorenadiaz@outlook.com", true, false, null, "LORENADIAZ@OUTLOOK.COM", "LORENA56", "AQAAAAIAAYagAAAAEIGT+uR/KzwxAy4aPZVAx46Rf6om/2khpUIG4/3S08TL7SiPUsEGImZV3rc45DNOtA==", null, false, "27fed9e9-9ca1-4461-96d6-86c0a18b94f9", false, "Lorena56" },
                    { "379982fe-d22e-429f-bc14-26fffc569958", 0, "0c92cfb0-d6ef-4787-937f-7acc28d32fd1", "rrhh@santander.com.ar", true, false, null, "RRHH@SANTANDER.COM.AR", "SANTANDERARGENTINA", "AQAAAAIAAYagAAAAEK3+iIz6i+917XAN2qmQiP8O43JxD5KqDFnf9+Y/mlGfmClhZAmC2Rh5EVkppyS22g==", null, false, "21db8558-5791-4519-a845-53c436f0c1f3", false, "SantanderArgentina" },
                    { "38c07b15-1adc-47fb-adca-5a93ab1ec6c3", 0, "9c29246b-060d-4879-b1cc-7c08c41aa519", "victormorales@hotmail.com", true, false, null, "VICTORMORALES@HOTMAIL.COM", "VICTOR87", "AQAAAAIAAYagAAAAEDx3INz3jQEQF8hC5JXJHSB3F3RbbIbMG/wk1BC8+DMqszj6fRo99GhHyr9/WpY5Bw==", null, false, "8b772100-90d6-4654-901a-d99a53cc86c5", false, "Victor87" },
                    { "3a76ac51-89f5-4b7f-a2fb-cca12abc04e9", 0, "62d04395-3430-4a9c-aa66-d1e1584ef7f4", "isabel66@gmail.com", true, false, null, "ISABEL66@GMAIL.COM", "ISABEL66", "AQAAAAIAAYagAAAAEBokXsTd493u3eLPTLoqw8e2x9S0md5ZHa4Iocl6TtAPgP9XMLKzQYY0FiV49kYjNQ==", null, false, "1fdc9853-36ba-4c47-acd2-f0a9d6257160", false, "Isabel66" },
                    { "3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b", 0, "27625644-2090-4433-a619-a08d4e11d2f6", "josemanuel@hotmail.com", true, false, null, "JOSEMANUEL@HOTMAIL.COM", "JOSEMANUEL78", "AQAAAAIAAYagAAAAEOxRAuGmjEqO0tlpijg8Z6Eit64rQjCnXzOfKKH8utH33dvSqoJFXhGXCTEIZM3yKw==", null, false, "5a3720bf-292a-485c-be8c-cbaf37f3a8da", false, "JoseManuel78" },
                    { "3c36090f-464c-4c80-ac2b-e32ca07c44a4", 0, "05ad2da0-e4db-4d8a-834c-b85cbb7a9198", "francisco@hotmail.com", true, false, null, "FRANCISCO@HOTMAIL.COM", "FRANCISCO99", "AQAAAAIAAYagAAAAEJb+WflZ9XmjU5fUG8c7R2yprEQIEkQAAFIvYO9gLib/vVZZ9nRZXTqQhvKMKioxtg==", null, false, "7c471f93-5c0c-47e9-a223-51348e4951b6", false, "Francisco99" },
                    { "3c36090f-464c-4c80-ac2b-e32ca07c44a9", 0, "11abfb0c-37f6-457d-9fa7-486c39f22089", "miguelsanchez@gmail.com", true, false, null, "MIGUELSANCHEZ@GMAIL.COM", "MIGUEL67", "AQAAAAIAAYagAAAAEM2iNG0NmhzClCa9mKJzywkeEHrwXGfJnnfXUVFNFdCUrmCO9ZgApwJWBsBLETqHnA==", null, false, "c430c4c0-4501-4f91-ab15-ca58d6a11da2", false, "Miguel67" },
                    { "3c875016-9cfb-4529-824d-1517c5a93583", 0, "9c923f7c-c673-427e-bda3-d4b0483c8985", "ivanbrestt@gmail.com", true, false, null, "IVANBRESTT@GMAIL.COM", "IVY97", "AQAAAAIAAYagAAAAECUuABewF9upFKNBo07jBOQaWFUeSeG0nPGLypo1qAI44LOhD8DS3kFm6pswzSgpSw==", null, false, "6816f8ea-9add-46a2-a2c3-ed6f5771ab87", false, "Ivy97" },
                    { "3e0f155c-6f59-4214-a4e4-2d992447488f", 0, "dba7eec5-a9bb-40cd-b5d9-4bbbd3366c59", "luciaramos@hotmail.com", true, false, null, "LUCIARAMOS@HOTMAIL.COM", "LUCIA56", "AQAAAAIAAYagAAAAEAQVT7JgCIV5sbocEJfyWzPhl+ZAGa/8I9y/wWeUmjpMRP4VtJA0Cv4gNnDbcnfe5A==", null, false, "1f570507-9f5d-4dd1-bb7e-8b4d02419b13", false, "Lucia56" },
                    { "3f059c7a-b764-49b9-bf1d-e5e2359e0cf6", 0, "4311a9da-514c-41b8-a70d-09a5f3f42778", "carmen11@yahoo.com", true, false, null, "CARMEN11@YAHOO.COM", "CARMEN11", "AQAAAAIAAYagAAAAEGlHjarHJDpy4t5pLpCA8PuwTcUj0I7D3uos9ATvDdbQuTol20s+US/ThzK/HmU+ag==", null, false, "802c5dde-0b21-466c-93d8-f00dc07548a1", false, "Carmen11" },
                    { "43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f", 0, "38db3f67-4aa6-4bcf-aba9-4ca08c344e45", "davidmartin@gmail.com", true, false, null, "DAVIDMARTIN@GMAIL.COM", "DAVID89", "AQAAAAIAAYagAAAAECHNxt8a1Ckd1En0H2w6BApRynOrsZ2urN7gk/z8ygWXeSyg+BABzBy8ZijgF2Nj/A==", null, false, "1dbda3c2-149b-4b22-8a64-061bbfa39c05", false, "David89" },
                    { "4a6b6c16-1593-4425-935c-d2ddc3c8eef5", 0, "a2001082-1c7d-41d0-9801-54751cb5de5f", "adrianaperez@hotmail.com", true, false, null, "ADRIANAPEREZ@HOTMAIL.COM", "ADRIANA65", "AQAAAAIAAYagAAAAEBGabsjKezPaOokTR90fYNRrGRLwx0jF2yCCgu5kXTLsIzqCHJVe0WkjlssJy2ETMw==", null, false, "20fcbe33-6272-4ff8-a7e0-72e35c56d6f0", false, "Adriana65" },
                    { "4ce9ea91-e281-47df-9fc7-79f0c9a95ddd", 0, "30992839-162e-45cf-a405-5427167f16c1", "beatriz@hotmail.com", true, false, null, "BEATRIZ@HOTMAIL.COM", "BEATRIZ12", "AQAAAAIAAYagAAAAEKjrMgwQy/cwQ6rqOwmslBA0fiX0qjZ2VBqyl8FvgE8C09+ljUr6UjYhVpTIGHJC6w==", null, false, "9826c8b2-d8be-4a15-a918-719a0d53627b", false, "Beatriz12" },
                    { "4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f", 0, "45b0fbb3-f0b3-4159-ae4f-94a9d488e927", "diegolopez@hotmail.com", true, false, null, "DIEGOLOPEZ@HOTMAIL.COM", "DIEGO12", "AQAAAAIAAYagAAAAEGACuKy2O7IheBZ1qho1d2d11PNoHmmlyTY8dof3fJYe9WahlmZ2rYTXlH3e9C66aw==", null, false, "a78973d0-9ccd-4d57-b743-c65fd81dae73", false, "Diego12" },
                    { "52432a25-6a28-480e-ab5c-17fd71be2ffb", 0, "896f151b-1304-4fb4-a660-7da872a6babb", "julianagonzalez@yahoo.com", true, false, null, "JULIANAGONZALEZ@YAHOO.COM", "JULIANA78", "AQAAAAIAAYagAAAAEMCN9GrC/8V6PgcStd1A/chaDLd5oJfdJ7q1s38r2LWK8CT9N4JDeRmjFKZvDdUMlA==", null, false, "27902975-d85b-437e-9063-0ab97e0e7902", false, "Juliana78" },
                    { "525d6c44-e75c-466a-9510-fb4c0d8f28d1", 0, "40025751-a38f-4972-99fa-5a772e973068", "anamaria@hotmail.com", true, false, null, "ANAMARIA@HOTMAIL.COM", "ANAMARIA67", "AQAAAAIAAYagAAAAEMEaqky2hQfHqAUhognuEHhR7zYyCy1lNK1T9CmuKcZ7JYxsznhEWyTURMrrPYGuPQ==", null, false, "83dd1009-6df8-45c0-880c-6d891d997d8a", false, "AnaMaria67" },
                    { "53a20833-f2ef-4cb7-a049-326d0cb255ad", 0, "37142d73-4520-4648-be2a-94967cf65605", "martarivera@gmail.com", true, false, null, "MARTARIVERA@GMAIL.COM", "MARTA34", "AQAAAAIAAYagAAAAEAAhAkOtw45q3QicswCEmlawgmmS5NPOvLyTzud0rjfmAgjaM9rry36ce7LAEo2A7Q==", null, false, "6cc0c469-aac6-4693-b5e1-a3a3d07e05b7", false, "Marta34" },
                    { "55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8", 0, "e1ba37bc-bb7c-4271-b5cf-54c5182cdc08", "juancarlos@gmail.com", true, false, null, "JUANCARLOS@GMAIL.COM", "JUANCARLOS", "AQAAAAIAAYagAAAAEEo+mvWpQNBXNomBaE89X9zdJ+tRl6RYP/e0C4AlENCTwA08kBjUuwJntpZKbmu9AA==", null, false, "3e356801-3281-49b0-a5ed-fc107456ae5e", false, "JuanCarlos" },
                    { "57168621-b0dd-4fe4-a20e-489171d70a5d", 0, "73f80236-765b-4d4e-8a22-c586e95b27a4", "rrhh@ey.com", true, false, null, "RRHH@EY.COM", "EY", "AQAAAAIAAYagAAAAEJcnqWbBp5LzILbiiYwK4xndNn10jchfEgwlefXEFSVUQ1k9sOggcwAfshriGfyLDA==", null, false, "7a187311-9901-4b1a-a5f8-004a2d3d3ec7", false, "EY" },
                    { "597719b7-3036-4f95-92f8-5163b3e18931", 0, "c52e8c47-cee5-41ca-ab34-5745e526e031", "joseluis@gmail.com", true, false, null, "JOSELUIS@GMAIL.COM", "JOSELUIS45", "AQAAAAIAAYagAAAAELroAQjPa3Ofarc/+qXRBv0gCWmbQN1F0rlvUG/9sNiqgK8KoZd5U+VJrbLyr3YBVQ==", null, false, "a9786e08-090f-4533-a115-8f3791f32dbb", false, "JoseLuis45" },
                    { "5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2", 0, "a76f3e10-ffa8-4452-ae54-5a3b62c8b5e5", "albertogarcia@outlook.com", true, false, null, "ALBERTOGARCIA@OUTLOOK.COM", "ALBERTO12", "AQAAAAIAAYagAAAAEEpdBb0Wa7M6jFusiYCHSevmz8vVY+htdxuaUOMIHtZE2ETdKRtDqeCZzHEDe8rJhA==", null, false, "85b50ee8-305f-4e0d-9f5b-3a22ef8a267a", false, "Alberto12" },
                    { "5b68ad8c-f42e-40d7-87de-3622d34dcf84", 0, "52bd2ff4-8d4d-4230-a4d7-861de5a22e46", "mariagarcia@gmail.com", true, false, null, "MARIAGARCIA@GMAIL.COM", "MARIA25", "AQAAAAIAAYagAAAAEPGU+3YfY26Tc8fqtK4d2TtyRHwNT/sAhy2zd9pO3tfdwhOGrjCIR+dmGgzgSx6DWg==", null, false, "25e80a1f-4305-4fa6-ba92-90364b405199", false, "Maria25" },
                    { "60786725-191b-4172-acd8-ef669024173b", 0, "1d5b48b4-726d-4d9d-9491-b545ecbdf282", "jorge@hotmail.com", true, false, null, "JORGE@HOTMAIL.COM", "JORGE77", "AQAAAAIAAYagAAAAEGRDbrB/f8Np850uw7V4db2EzXKPpqmLq6gyIYyZjmFZAfgA8zhaJaFzxC8+nU5BrQ==", null, false, "e8d157ac-2d27-4aad-b883-f200ba731c6c", false, "Jorge77" },
                    { "6ca18a54-6c7b-46af-b298-fa756919a4f1", 0, "7fb2b600-c399-4ade-aacb-f4d52053548a", "sofiagonzalez@hotmail.com", true, false, null, "SOFIAGONZALEZ@HOTMAIL.COM", "SOFIA34", "AQAAAAIAAYagAAAAEDCCl2uKANifZBx//gYXqKtM7DoC9AKUFFpK0zqmshKk+wdLFYLD0WJy55m7fj2npA==", null, false, "348cfa5b-f29d-46e4-af6d-f2b6f0f02333", false, "Sofia34" },
                    { "6d46504c-1a72-4036-98e3-3434676e05bb", 0, "fe2a06c7-83e9-4b84-8137-7fdafd892218", "juanantonio@hotmail.com", true, false, null, "JUANANTONIO@HOTMAIL.COM", "JUANANTONIO89", "AQAAAAIAAYagAAAAECxBQnAxp7SPNjgVOx5c7CenYWIMXp9vqb+U0kAPQWC8B6TG1GLUEL0HbV2dwoc4/w==", null, false, "62cf73b9-8634-4fc6-9f38-331d33c4bb73", false, "JuanAntonio89" },
                    { "70e6cdc7-85df-452f-84ea-5e985024734c", 0, "c4e7731b-04bf-42f9-b5db-a9531e60847d", "raulperez@outlook.com", true, false, null, "RAULPEREZ@OUTLOOK.COM", "RAUL89", "AQAAAAIAAYagAAAAEG+eCRa3WSg/j6z34F/Rmymj0tOYOp0IbJjZBV+olsNFaXed+zdLBqQwHTnmKAzLtw==", null, false, "70724f53-cbc6-42ec-a9d8-7bdc24aab297", false, "Raul89" },
                    { "7c5891f9-9fac-4dbf-9afd-2c9e01759e20", 0, "8d513b9e-75d2-4d9e-a2d5-43ca52395827", "alejandra66@gmail.com", true, false, null, "ALEJANDRA66@GMAIL.COM", "ALEJANDRA66", "AQAAAAIAAYagAAAAENV2jQbMqC+JBsUdPAUfpCq1LS3aJn6warsiK0l6QF/Ehd1/DANmJQtt5Vz8fjcxDw==", null, false, "f0497560-caa7-47b4-9359-bc9f9f56ec09", false, "Alejandra66" },
                    { "7e246319-564e-4920-bd8c-6029be2a7729", 0, "505e7d1d-4cd7-4676-baaf-cf607eb8925b", "elenadiaz@gmail.com", true, false, null, "ELENADIAZ@GMAIL.COM", "ELENA31", "AQAAAAIAAYagAAAAEKxZZ0ZTDHOySshrLpzy5AjwKAFa3NyQizY6fTWcxMt0VZQGUUhKoz0vHW1IAdlwxw==", null, false, "1d15c3c9-30e0-4e98-91cb-872472ea4b7a", false, "Elena31" },
                    { "80120fd9-ade7-4cd0-9dda-7b733e02d7cd", 0, "7b71bc91-03ef-45ce-b7e0-5ad3fccf3535", "carlos22@hotmail.com", true, false, null, "CARLOS22@HOTMAIL.COM", "CARLOS22", "AQAAAAIAAYagAAAAECChU25xVNtDSbogWvgSXfb1VXfbX4GK8jWUW5gVrGPtjZZOIZEBzwMGlWfc6SWTog==", null, false, "a45a21c2-8e53-4921-9156-8bc369380886", false, "Carlos22" },
                    { "81319e22-745a-45c6-9402-6d1389fd0f44", 0, "703ae5e8-9414-41f0-936b-6e22f21afe8b", "nataliaramirez@outlook.com", true, false, null, "NATALIARAMIREZ@OUTLOOK.COM", "NATALIA56", "AQAAAAIAAYagAAAAEAK4jMY072eiyIPW4TqJ6v/gcJ/aX0ra5ehDFYk+rIfWAjQtyfsx/vaWf8rbNbRheA==", null, false, "88d733d1-28a0-4a5d-bf03-d6beca9078f5", false, "Natalia56" },
                    { "83ae68c3-f621-4f03-bda7-73d77aec8ce3", 0, "c4ee5778-e019-4e81-a422-ff5c96d67843", "valeriagonzalez@outlook.com", true, false, null, "VALERIAGONZALEZ@OUTLOOK.COM", "VALERIA67", "AQAAAAIAAYagAAAAEIrqOoWs2YVTR/1WNgqll/8zsl8+uL2+iLi1cqCP7m2+hjW5boL82BafLatAGRyg2Q==", null, false, "d1d457d3-19a4-4e17-9c83-940fb5328c0e", false, "Valeria67" },
                    { "866d732a-ab7e-42b8-aa7d-3bfb6e1477da", 0, "8e56aff2-f063-4e59-91c4-78f2c7fc9afe", "monica44@yahoo.com", true, false, null, "MONICA44@YAHOO.COM", "MONICA44", "AQAAAAIAAYagAAAAEG961HeCCiTFdY1OCHevpsZSCYXfdxJxOkDBOobOCgYovfNV1altyxa7GtpMKz2Mww==", null, false, "6e564ceb-f92c-476d-bbcf-8ed8b864974f", false, "Monica44" },
                    { "874fb32f-0ddd-4b5f-ac31-f2f11b66e098", 0, "9dd05fe3-4221-4078-995d-24515bc468fa", "info@paypal.com", true, false, null, "INFO@PAYPAL.COM", "PAYPAL", "AQAAAAIAAYagAAAAEINS4NnZKkXG0RADvWhDQ8ERHkAlnIAE5rVf8zgV1xXnaAnCW/AYQkyup0zIet3VJg==", null, false, "bd0dd3e9-94d2-43d3-977e-ed2aa77f4ca4", false, "PayPal" },
                    { "87dbaf90-f343-423e-9f14-e124fd145730", 0, "498773c7-413d-497a-9231-566ba9b86ad6", "ana88@hotmail.com", true, false, null, "ANA88@HOTMAIL.COM", "ANA88", "AQAAAAIAAYagAAAAEFrS2RJT8LFHXhSZ024ANzZSLUNOXtzUTkXJvI9HnXTQSgzE+E+BZ4zoWp06mL1xqw==", null, false, "c460cde5-e17c-48b0-8117-3815cc585e72", false, "Ana88" },
                    { "8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473", 0, "f66ff1bd-0676-4a93-b804-0ad47b48e198", "anagomez@gmail.com", true, false, null, "ANAGOMEZ@GMAIL.COM", "ANAGOMEZ", "AQAAAAIAAYagAAAAEFKYyLUaSREd3QH/TRIe6IwLY8iozQxH9dn9YldOL2D//hmuP2Yonsdi0m4PbnoGmA==", null, false, "dabd93b9-1c22-47e3-ab8d-908cf5f04cf4", false, "AnaGomez" },
                    { "925b2ab6-5a03-40a7-891e-7bb594086e61", 0, "a7bcaca8-c04a-4fb8-a18e-5497ccbdce59", "entaconsulting@gmail.com", true, false, null, "ENTACONSULTING@GMAIL.COM", "ENTACONSULTING", "AQAAAAIAAYagAAAAEFoa5r/lqjDFjDnkj3XDKVaawjhI6Z2X1K1L2XbOGR8F1TVqdegRC6/MrcQgzgaqAg==", null, false, "113ecff5-0e03-40e4-ace1-f40b3367c56e", false, "EntaConsulting" },
                    { "92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2", 0, "7ee65483-3139-4ba8-8fe9-9760e4d9e39a", "monicagarcia@hotmail.com", true, false, null, "MONICAGARCIA@HOTMAIL.COM", "MONICA43", "AQAAAAIAAYagAAAAEOidIuR/W6tNmA05R7GIX6SdCVpLo5IRt9IYB4ahQtP0BhiHyNI0Efk8Nt2jJSmdAw==", null, false, "bf96e8ed-5cb4-4f9d-a8a4-dbc229055ccb", false, "Monica43" },
                    { "939a97f5-10b8-4d6c-ab74-ce77187d36df", 0, "0f2d3fa2-c685-48cb-9913-54d8b4723267", "alejandrahernandez@outlook.com", true, false, null, "ALEJANDRAHERNANDEZ@OUTLOOK.COM", "ALEJANDRA45", "AQAAAAIAAYagAAAAECXVtxpz+S8d+nHGL8cNqvaU40QS4t5oZeNdgdkSxhRo6xGJ0iYuz+/snF9/JTd9ZA==", null, false, "1dc28ccf-6c71-46ef-99dd-09d0a26dcea1", false, "Alejandra45" },
                    { "944cbcf3-7479-4eed-97f1-80fd4c50eda6", 0, "100953f4-626f-45c8-9df0-d3cb80b5fca1", "antonioalvarez@gmail.com", true, false, null, "ANTONIOALVAREZ@GMAIL.COM", "ANTONIO65", "AQAAAAIAAYagAAAAEAs4jZLp51JdUV5mYOuibZ/fHKCzeBmSCfHW9NkCVdE5z/AYFXstkOefITDh0l7htQ==", null, false, "317f411b-8db1-4054-945c-59b47a5e4414", false, "Antonio65" },
                    { "97767fcd-f146-4e88-87dd-f1f1806dec49", 0, "51fe0994-2629-4364-86b5-66511c180913", "carloshernandez@outlook.com", true, false, null, "CARLOSHERNANDEZ@OUTLOOK.COM", "CARLOS77", "AQAAAAIAAYagAAAAECNOeqwIGgWBnPDOYja0XUyW33OOSRMscVnvjVLbOJHKFZPWRIBfbodhyFOBvXzYMw==", null, false, "83080eb1-06e7-4097-b7b1-8aa68f9fb6c5", false, "Carlos77" },
                    { "9d8b9e84-33a7-4c28-a6c0-5941a68f1968", 0, "4e0daf0e-7271-4322-879f-37be545ac1db", "rrhh@adnrh.com.ar", true, false, null, "RRHH@ADNRH.COM.AR", "ADNRECURSOSHUMANOS", "AQAAAAIAAYagAAAAEOwFCiLb0YNP1NpCpkHfarIJ7rST7oXwTugD2KXc0/5WdOEvGDJ7ahrxONHq4Qbvrw==", null, false, "41422e68-9a90-4d3c-b7f8-d851cab2b95e", false, "AdnRecursosHumanos" },
                    { "9f7c46a4-9ea5-4bc6-bd47-90ba52c54734", 0, "dc5a1b83-20b8-4008-8676-5eb6de27c70a", "rrhh@galicia.com.ar", true, false, null, "RRHH@GALICIA.COM.AR", "GALICIABANK", "AQAAAAIAAYagAAAAEEb+5nGQRkNQHb9+6Rd5n47vV9FdkFksoAnw/Ag6xrR4Ysz7PQMmYUjOJPBs2kZnkA==", null, false, "ec7d6572-b1f9-4256-8d21-d170a67089a2", false, "GaliciaBank" },
                    { "a0deb200-955f-4b6c-b550-9ca1712392a8", 0, "c5314132-6d20-4081-929a-3ddd0e85c962", "carlosrodriguez@gmail.com", true, false, null, "CARLOSRODRIGUEZ@GMAIL.COM", "CARLOS23", "AQAAAAIAAYagAAAAECDIUD2M8uTU78r1fxK/Owlo2D5lGI9e0Amfvyh7moxzg5Jv5dVAT+AgwEWBQSX6Pw==", null, false, "2f54eafe-691d-4d1c-b7c8-8325e83b09b2", false, "Carlos23" },
                    { "a3fb7e92-6b31-4630-835c-3ea7d11e4306", 0, "0ed16171-e291-4b2f-b185-7e7bb22a1f56", "data108@hotmail.com", true, false, null, "DATA108@HOTMAIL.COM", "DATA108", "AQAAAAIAAYagAAAAEBzCNWstBLH/z6qtNGOdPhkJi6OV7m+zYKL3hV7D30DjjbAxnV55FLQkUxC06CaM6g==", null, false, "93f01f83-2a83-447c-b671-de4f3c74e993", false, "Data108" },
                    { "a4db8ecb-2f10-436e-8011-cf701620ea60", 0, "5eec4a83-8156-42d6-b1f4-d16279f07b78", "rrhh@sis.com", true, false, null, "RRHH@SIS.COM", "SIDESYSITSOLUTIONS", "AQAAAAIAAYagAAAAECMRQdogO4uu8Y3lkvb9TefcoFVkMYHTg/Y65k0HaZZ00A+S5ssloo+CgldplTR7Wg==", null, false, "fdeee2c7-2f0e-4ab5-9d17-42fcf770b6c1", false, "SidesysItSolutions" },
                    { "a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7", 0, "42f2c153-2ddb-47a3-ac2c-868d8b747372", "pablo99@gmail.com", true, false, null, "PABLO99@GMAIL.COM", "PABLO99", "AQAAAAIAAYagAAAAEK3HS6a8WvGPJ9SroZl1h8k29wy9ZlkdTcIewR61gdfZkNUpBcoBIeO9DBM6MGzw+Q==", null, false, "295683c2-4c08-438e-8e99-234bcfe63792", false, "Pablo99" },
                    { "a9805c2f-71d4-4c13-92fb-ac069cb7d633", 0, "dcc1b998-8f20-43d4-a2c1-ede23999a2b1", "camilasanchez@outlook.com", true, false, null, "CAMILASANCHEZ@OUTLOOK.COM", "CAMILA34", "AQAAAAIAAYagAAAAEEV+q7KQVV4vC/32f+V2DzCgfGW1Hw2fJAOHWnGBzDFUO6yOyJaieFKVbZOKUdvpJg==", null, false, "f2958f22-2be4-4681-baf8-0a0cb3c6f5a7", false, "Camila34" },
                    { "ac270f24-3f1f-43a6-b291-1f0ce4489bfd", 0, "2c396f52-4792-4ac0-a019-ea4c33d79fcd", "rrhh@ingematica.net", true, false, null, "RRHH@INGEMATICA.NET", "INGEMATICASA", "AQAAAAIAAYagAAAAEA2SddtsmMHJ1ITzdE8aIzEtSHIClPTxAn1DqT8WSGYWT2CUintMCYydz/2bhxvcrg==", null, false, "ae2ade12-163d-4524-9faf-f30e69481db6", false, "IngematicaSA" },
                    { "b0c0659c-a57a-4acb-a906-5e3bf9ab2675", 0, "82b738c6-98fe-406a-a62f-2d9b6fbcab1e", "saraperez@gmail.com", true, false, null, "SARAPEREZ@GMAIL.COM", "SARA56", "AQAAAAIAAYagAAAAEC5km8137GPOY9/S56N1w1Hw5HlpaEav6yhvRxmT0rd7B4QCsRT2KlN7IcK87is/Vw==", null, false, "ba644770-0c5e-4cf8-ba82-eb05ab8384f9", false, "Sara56" },
                    { "b2269673-9d47-471a-a958-24160608ae82", 0, "a6fcae37-c12c-4a53-8a8e-a8b5a456ec8b", "isabelhernandez@hotmail.com", true, false, null, "ISABELHERNANDEZ@HOTMAIL.COM", "ISABEL45", "AQAAAAIAAYagAAAAEB+Fpb6AADcURV/kBLef/N1txM7ZTo5V5H94NxTwni8EpSc7Gm9Rs1xggvBWt2A9Jg==", null, false, "24c2f61b-bbce-4bcd-aeea-84b14e232214", false, "Isabel45" },
                    { "b735e23e-c928-41fc-b399-aa4a28807210", 0, "7d7e2a9f-e279-4798-97a4-a2677df3d32a", "rrhh@Adviters.com", true, false, null, "RRHH@ADVITERS.COM", "ADVITERS", "AQAAAAIAAYagAAAAEOB9tEBynBhGZVPihFpL/A8P6bi4FuwXv0fwAab8mEDSNZRN1VTECA3Vc7MjomCBfw==", null, false, "ddfc4e25-073a-47a3-ac18-471ca6b824a2", false, "Adviters" },
                    { "b7d7964a-3f03-4930-a23d-59d90711f002", 0, "18cef08a-244f-42cd-b6c8-59fc99758387", "elena88@hotmail.com", true, false, null, "ELENA88@HOTMAIL.COM", "ELENA88", "AQAAAAIAAYagAAAAECWsFMde5BShQfcZgrbaXH5X/FlWoNFJmy2IHNckRj+0gUBh7xG4s1Q4ptCFfkVZNQ==", null, false, "bb16ba01-e97f-492b-b90a-ca934d7ef467", false, "Elena88" },
                    { "b9b2181b-d620-4db0-9561-9c1ba02480bb", 0, "23f2ef39-1859-49f2-8df1-a8f11518224d", "luisfernandez@gmail.com", true, false, null, "LUISFERNANDEZ@GMAIL.COM", "LUIS10", "AQAAAAIAAYagAAAAEG8yZbK9E0Spob+WM/z0oNTfkzZklQnj+hkZI6+Jyt1B+NjTbG+uoL/qWySyu7vJKg==", null, false, "8c12ba7a-7835-4d17-9caa-67d67cb86d30", false, "Luis10" },
                    { "ba694638-8e1c-4398-a3db-50b879ea1414", 0, "85bf53e6-c93e-43b4-bce5-635aa47d2e08", "robertohidalgo@gmail.com", true, false, null, "ROBERTOHIDALGO@GMAIL.COM", "ROBERTO44", "AQAAAAIAAYagAAAAECivd2vZGCktoi2+ykwueY/WYVEfaIDDYHt8k9Phh2e9Td1bvjzkeykjATB9NmXu3A==", null, false, "c3ef34aa-d5fd-4ae7-8a84-607ccb767f1a", false, "Roberto44" },
                    { "ba7faac0-0e0c-4fb8-a329-5483da03032c", 0, "dffa09d1-fe44-420a-9989-5889dd2bed2e", "fernandogomez@outlook.com", true, false, null, "FERNANDOGOMEZ@OUTLOOK.COM", "FERNANDO78", "AQAAAAIAAYagAAAAEE0GcKQ/W/srGRS8hFDvohJYmbzf+W9JJf+HmA2plHF+ocz1D0Lhc6/IMh5vnwrcQg==", null, false, "d15250cb-6345-4263-8ffb-6731ba347d98", false, "Fernando78" },
                    { "bb491436-8b44-4049-8f28-60b5689b6fd7", 0, "dc3752c8-f8cb-40af-becd-eaa735d55003", "rafaelmartinez@hotmail.com", true, false, null, "RAFAELMARTINEZ@HOTMAIL.COM", "RAFAEL23", "AQAAAAIAAYagAAAAEN70wZ2M9V/FkTnTd3tF87NtrgORpEhJ2v1Aatd8C4vczMYkO+qSVw8YF3JpGoHBAw==", null, false, "2b28abaf-5cc7-4ec1-be7d-0ea1af12b552", false, "Rafael23" },
                    { "be76d6cb-0532-4dd5-8e4e-f944faf0106b", 0, "d494dbfc-fa64-455a-898f-dbd4f467d6ce", "rrhh@sistemasactivos.com", true, false, null, "RRHH@SISTEMASACTIVOS.COM", "SISTEMASACTIVOSSRL", "AQAAAAIAAYagAAAAEPv14LeYOHYMWg/6jrceZtUhLsFel3I24hQFgnbKmrefQ1ROLwc59rHQR57MA16kvA==", null, false, "c8361826-d1f2-4792-a6e1-644ed5ea19d0", false, "SistemasActivosSRL" },
                    { "c2199980-e00d-45dd-bdb6-8497cfeac41d", 0, "f2cf8958-0e58-4372-a6f0-a900df8cb49d", "ricardomorales@outlook.com", true, false, null, "RICARDOMORALES@OUTLOOK.COM", "RICARDO44", "AQAAAAIAAYagAAAAEI+TutfEYSSOYvRN0/efij8817zqqX2Dpeo558tIukxuQguPr+H3EzfcR0i+QNZ67g==", null, false, "ea2354f6-f05d-410c-9cde-b05a3235ab3c", false, "Ricardo44" },
                    { "c2c1137a-2957-489a-b6bc-a520a28c3206", 0, "9157cbfa-e8d5-46fe-ad79-8b0a8a186381", "paulaperez@hotmail.com", true, false, null, "PAULAPEREZ@HOTMAIL.COM", "PAULA31", "AQAAAAIAAYagAAAAEJWZENnPiK4n0aJP+47LGFLbZKqnzFnPVnIvYygPsqzmCJuamXyx5jMQV7xArnViVg==", null, false, "0bf60209-7786-46ce-bfcf-2308d8e46230", false, "Paula31" },
                    { "c54c442f-e6a2-40b7-a022-3a58bccb2b3b", 0, "72b559a1-6c61-4776-aa44-bb2b57cb6b1f", "gustavomartinez@outlook.com", true, false, null, "GUSTAVOMARTINEZ@OUTLOOK.COM", "GUSTAVO23", "AQAAAAIAAYagAAAAEJ4bKy2cLL1f60/d7WCaRQYXmUTPqeoMmS78lDg8wR+t7xovtLL3qCqqAGSLMD6+Rg==", null, false, "a6948c8c-1018-482c-98bf-f7723bf9f179", false, "Gustavo23" },
                    { "c5f0f42f-255f-400d-b657-bed222ec9903", 0, "05c5e4d8-d2cc-4819-ac76-360d763f93a3", "luismiguel@hotmail.com", true, false, null, "LUISMIGUEL@HOTMAIL.COM", "LUISMIGUEL", "AQAAAAIAAYagAAAAENH+omHDoZfpTNdDe7YBZpCGRbtZeSU0SrLQ2dTewURdfj8Hr1gCPzwZa3Ss7IygUA==", null, false, "fad556cf-454c-488c-b7df-f4c1520a0718", false, "LuisMiguel" },
                    { "c9ea88e7-aba3-4aa3-8dd7-0977a84004c9", 0, "3b421cdf-f29b-4d7e-ae78-c0bbb56f30d0", "teresadiaz@hotmail.com", true, false, null, "TERESADIAZ@HOTMAIL.COM", "TERESA44", "AQAAAAIAAYagAAAAEI+hPTijwydk00/SNjH7QVWmdj6LX6mnDXCIhu98O9L88I+7nQ7FHqb9htUFUW7rMQ==", null, false, "82db8160-6277-4a40-a4db-39696cfd6a49", false, "Teresa44" },
                    { "ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978", 0, "9899bf2b-afff-48fc-92c9-85f50a5d0c4a", "laurahernandez@gmail.com", true, false, null, "LAURAHERNANDEZ@GMAIL.COM", "LAURA12", "AQAAAAIAAYagAAAAEC8MGVKrmDa7qXHG6y8H+AqGFxIVlRdb5+9SF8/leP+wGIpUT5uyT3jBdBOZii53Ug==", null, false, "a1b9c14f-07b8-4624-b187-e8f00ad7277b", false, "Laura12" },
                    { "cca9654e-d839-4e21-a23d-01fbb75e0a26", 0, "604a2c16-2c33-49b0-9b58-ee085d437b83", "patriciaflores@gmail.com", true, false, null, "PATRICIAFLORES@GMAIL.COM", "PATRICIA98", "AQAAAAIAAYagAAAAEGlkPAdwdFImqwBOKt+tXZYslNfH3oGxXhUhVv3KPdt8H2QjOiPkHmeS93F3uJ7CVg==", null, false, "af03ab48-87ca-4fd8-b0a0-16a30470ff96", false, "Patricia98" },
                    { "ccedb55a-6010-4ec9-913b-caa122d34ba7", 0, "2de64f3a-6c82-4415-bbdd-3cdc02340649", "robertomorales@hotmail.com", true, false, null, "ROBERTO MORALES@HOTMAIL.COM", "ROBERTO67", "AQAAAAIAAYagAAAAEOzzRDh0ejKGAZr82ZGdZPa6xq2A+qXHOjFXQRYnihdnJeFEsNyY8iYx3GTOUJRLXA==", null, false, "ba995e5b-07ca-48fb-964b-9e4e75c51ae5", false, "Roberto67" },
                    { "cd88e529-eedb-42c5-a88d-384f5976a754", 0, "989a8198-9999-432c-8c5a-24efeda4d274", "pablomartinez@gmail.com", true, false, null, "PABLOMARTINEZ@GMAIL.COM", "PABLO43", "AQAAAAIAAYagAAAAENJg4BtL9fVXZacm8IaC1I0QpCty26p3VkBNiDx/zzXDBWaRbjrswrrNL/2yIQxj4Q==", null, false, "7cbbea99-a647-4d3a-bb59-76ae79408e97", false, "Pablo43" },
                    { "d496f336-c5ab-4648-841c-38853c4aa4f7", 0, "7ddddaa6-7ffe-4e6f-ade9-8d8e62134445", "paoladiaz@outlook.com", true, false, null, "PAOLADIAZ@OUTLOOK.COM", "PAOLA31", "AQAAAAIAAYagAAAAEBb14EkrGzrcRq23OiSDyZQ2TycVHiLnFd4I9GK4XQRfoKHWVYIcNApKqGKnh4qSTQ==", null, false, "e8e6d135-4395-4104-acfa-6fcd94b9f046", false, "Paola31" },
                    { "d4caf327-f110-4ab6-9305-c064a2071dc5", 0, "f2ead041-f944-4b0e-a239-f3fe7307075b", "personal@personal.com.ar", true, false, null, "PERSONAL@PERSONAL.COM.AR", "PERSONALARGENTINA", "AQAAAAIAAYagAAAAEFaOHbnIa5K3I15nEMaDH02vzRr6z02Fcp3v1MhyEhU+7fLdvl2r4jbhgZwQSvJG3A==", null, false, "3de6c828-7293-478a-a33f-1f26ccc2ceef", false, "PersonalArgentina" },
                    { "d51252c3-6e21-4ffc-aab3-f4bda791a574", 0, "c935cc97-8e43-4506-9099-7928672ed978", "meli@mercadolibre.com", true, false, null, "MELI@MERCADOLIBRE.COM", "MERCADOLIBRE", "AQAAAAIAAYagAAAAEB7+A9ic0Hg55W4ThaXZeHZz+7XQ15CT/Vm7JI/J1vOO9+YVThlb0rPp/UMLA/B3nA==", null, false, "2f95eef4-ffd1-417b-81b1-c5eed34e2aee", false, "MercadoLibre" },
                    { "dd39eee3-6b17-4b39-95e0-075ad1b704bd", 0, "0033f3c5-390d-4397-8ecd-3044ee25e78e", "pedro77@yahoo.com", true, false, null, "PEDRO77@YAHOO.COM", "PEDRO77", "AQAAAAIAAYagAAAAEPaugpiUp+uVXuZVs8fsx6IxJ+wWldsFiAy+2GrfsAWYfTEUDtAWR62Y44sYgSoD+g==", null, false, "8c0149a4-afe3-40a7-a090-9be379998eea", false, "Pedro77" },
                    { "ddc7879b-e104-4047-bd15-d0fade9bbeee", 0, "005ebee5-a88a-4ef9-90cf-9e167645412d", "rrhh@grupogestion.com", true, false, null, "RRHH@GRUPOGESTION.COM", "GRUPOGESTION", "AQAAAAIAAYagAAAAEB9K423E6fLItpf5v1q9qPqKKDRwJAuPfhmbBOV/vKpnHstXDSM+w+eh2kv9N32awA==", null, false, "806f9e5a-d658-4bb7-81d1-4cc2c89103b9", false, "GrupoGestion" },
                    { "e60df533-79d7-42f2-a36d-99362dbc6f85", 0, "0f1a4bdd-5431-4260-a8c1-7ba18dc35ce3", "leonelesquivel@gmail.com", true, false, null, "LEONELESQUIVEL@GMAIL.COM", "LEONEL47", "AQAAAAIAAYagAAAAELV72eOnuYFvHB989iXZiNhdVjtVgknfD5gqcNyoI8Tg80vMPsW+/umtu3FDWWT1pQ==", null, false, "3e563cbc-6528-45dc-b5ac-f63b28f93a59", false, "Leonel47" },
                    { "ecdb5eda-1cee-4e68-b100-160203158d57", 0, "b71357ff-65f1-446f-82ff-052310ce1119", "accenture@accenture.com", true, false, null, "ACCENTURE@ACCENTURE.COM", "ACCENTURE", "AQAAAAIAAYagAAAAEMRH9aEH0QaGm1GIW0pE/c2HeuucRsma7Raz8hAl2aRMUirGcbtc1j5sFSoQJgk5AQ==", null, false, "e2c7c73d-f6bf-4ee1-88ae-8f4988243bd3", false, "Accenture" },
                    { "ecf7b85e-8c3c-47ee-a80d-b0b360512c16", 0, "eaadb779-8f54-4d39-9400-d53abb4f1b21", "david55@hotmail.com", true, false, null, "DAVID55@HOTMAIL.COM", "DAVID55", "AQAAAAIAAYagAAAAEJqB4Ndx8XHx8DdYMGq1O+BiM+rm8mqzbaT6PKPUfLaRcSgpZK73Nzx55MJzC/8BGw==", null, false, "8880ef3c-ab6b-41a0-a7be-acfa51ddc328", false, "David55" },
                    { "f102e342-a664-4b43-bcdb-b1c6945bf241", 0, "92641571-58c6-420e-9753-8d8a82e5bdb1", "robertolopez@yahoo.com", true, false, null, "ROBERTOLOPEZ@YAHOO.COM", "ROBERTO45", "AQAAAAIAAYagAAAAEFiOinWexpagrKKKWNgaRQdYua7Ic8+F/xoDmnzKuVtBpjJTIiwIVO7ZbEf5PTiQCg==", null, false, "3d386a01-471b-40be-bc78-581cdc329d25", false, "Roberto45" },
                    { "f3952051-fbde-4d44-a9b7-c3cb54027090", 0, "fe4e8cb0-42ca-41e1-bba5-fb984ce6238a", "andresromero@gmail.com", true, false, null, "ANDRESROMERO@GMAIL.COM", "ANDRES55", "AQAAAAIAAYagAAAAEGRAbnByHDY2VdjiE4blDHNlxIiS2bmjXVcAn73bwRZANTDGTDpbZXmvCPVk7E25uA==", null, false, "e85e708f-bb23-410f-b78f-afb043d697f8", false, "Andres55" },
                    { "f42be566-1cc3-4863-9cf1-315828169000", 0, "75ac9802-9a3f-4694-9753-bbb11bb21ef4", "recursosh@softtek.com", true, false, null, "RECURSOSH@SOFTTEK.COM", "SOFTTEK", "AQAAAAIAAYagAAAAEAOCa9zWs5T5iLxCT2xghQdbEPZqsMixTms78RERG6vrmoV5vqbbGFWXjf3HA8F9Ig==", null, false, "ca1434d2-1e91-40a0-a9c3-59f24b427a95", false, "Softtek" },
                    { "f4c4ffe2-e95d-4c05-a958-d32b26fecfc2", 0, "a41e8e21-d752-4e38-91b6-b5f8cc6dc159", "info@ettfaster.com.ar", true, false, null, "INFO@ETTFASTER.COM.AR", "FASTERARGENTINA", "AQAAAAIAAYagAAAAEGnsOZLAIIw59p6lkK+rh3oiz3Jjy4u/GxgIUgLoQOIfAeemXjWQhVUMRcKhCH9jBw==", null, false, "2ee0a573-4ebe-4c1c-b161-d7ee4d28e1c5", false, "FasterArgentina" },
                    { "ffd79ac4-d69f-4b74-b7c2-67e92905239a", 0, "34338542-e7a7-4b52-9664-1a5653232642", "felipelopez@outlook.com", true, false, null, "FELIPELOPEZ@OUTLOOK.COM", "FELIPE22", "AQAAAAIAAYagAAAAEMiXwUXrgkwqQ9pBcNkWIqLYTMbuFTZicvm1zEqX9xDD/K3vTKZEQ3khiUAatwL3yA==", null, false, "5c148d75-2e5f-4587-9fa9-359e978324cc", false, "Felipe22" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "02bdfba1-5d7d-46f8-89c7-5d02a5fc7655" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "0497ee14-d660-49a1-916d-8d2391ba6cf2" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "0835e1cc-d304-4b61-9b58-135ab2d27b3f" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "09260ec0-0368-4da8-80d5-6e8b9c574920" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "0b450794-1b65-4d42-8df7-05b57b970454" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "0d4ad714-56a4-4bfc-b4b4-d776cfd51fd8" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "0e5a9aab-eb68-4ca9-8b80-ea7bef076946" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "1199aa46-b03b-4cc4-921e-62b08fd5247f" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "153ff2f4-ccb7-43b1-b163-8f995adb1d13" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "17923d13-ffa5-4e87-9cab-3b313d44b3ea" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "19d1cc4c-18e4-42fc-9cbd-56253b20165e" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "1b29f96a-23e1-4824-9e66-775d807af9ae" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "1cdb46ef-e0a5-427c-8409-9a58cde54ce9" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "20b9c66b-7518-4cbc-aa39-f8bf41f0a423" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "2301041e-8c28-4711-b70d-9daed300ae21" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "2641ba50-9bdf-4107-80e8-a723e7feb06e" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "2a913313-dc4c-4f93-a1be-3fc5568e00b1" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "2d624f65-a74a-4011-a187-862f58df7885" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "2f5c9c2f-de8c-4396-90af-534f4e163439" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "31105ee2-5a05-4bcf-bff7-f07be401442e" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "31550335-200e-442a-9cca-f1d0f62c0819" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "347c951c-16c5-4043-bedc-a847c40fcb7f" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "35a26eb2-c01c-4df3-b98d-40561190ae36" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "37991d47-ddc6-400b-a3fe-b17b998a76b2" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "379982fe-d22e-429f-bc14-26fffc569958" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "38c07b15-1adc-47fb-adca-5a93ab1ec6c3" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "3a76ac51-89f5-4b7f-a2fb-cca12abc04e9" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "3c36090f-464c-4c80-ac2b-e32ca07c44a4" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "3c36090f-464c-4c80-ac2b-e32ca07c44a9" },
                    { "2048b194-4cda-4320-8b72-c169b4788fe9", "3c875016-9cfb-4529-824d-1517c5a93583" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "3e0f155c-6f59-4214-a4e4-2d992447488f" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "3f059c7a-b764-49b9-bf1d-e5e2359e0cf6" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "4a6b6c16-1593-4425-935c-d2ddc3c8eef5" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "4ce9ea91-e281-47df-9fc7-79f0c9a95ddd" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "52432a25-6a28-480e-ab5c-17fd71be2ffb" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "525d6c44-e75c-466a-9510-fb4c0d8f28d1" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "53a20833-f2ef-4cb7-a049-326d0cb255ad" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "57168621-b0dd-4fe4-a20e-489171d70a5d" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "597719b7-3036-4f95-92f8-5163b3e18931" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "5b68ad8c-f42e-40d7-87de-3622d34dcf84" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "60786725-191b-4172-acd8-ef669024173b" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "6ca18a54-6c7b-46af-b298-fa756919a4f1" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "6d46504c-1a72-4036-98e3-3434676e05bb" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "70e6cdc7-85df-452f-84ea-5e985024734c" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "7c5891f9-9fac-4dbf-9afd-2c9e01759e20" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "7e246319-564e-4920-bd8c-6029be2a7729" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "80120fd9-ade7-4cd0-9dda-7b733e02d7cd" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "81319e22-745a-45c6-9402-6d1389fd0f44" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "83ae68c3-f621-4f03-bda7-73d77aec8ce3" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "866d732a-ab7e-42b8-aa7d-3bfb6e1477da" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "874fb32f-0ddd-4b5f-ac31-f2f11b66e098" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "87dbaf90-f343-423e-9f14-e124fd145730" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "925b2ab6-5a03-40a7-891e-7bb594086e61" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "939a97f5-10b8-4d6c-ab74-ce77187d36df" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "944cbcf3-7479-4eed-97f1-80fd4c50eda6" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "97767fcd-f146-4e88-87dd-f1f1806dec49" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "9d8b9e84-33a7-4c28-a6c0-5941a68f1968" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "9f7c46a4-9ea5-4bc6-bd47-90ba52c54734" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "a0deb200-955f-4b6c-b550-9ca1712392a8" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "a3fb7e92-6b31-4630-835c-3ea7d11e4306" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "a4db8ecb-2f10-436e-8011-cf701620ea60" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "a9805c2f-71d4-4c13-92fb-ac069cb7d633" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "ac270f24-3f1f-43a6-b291-1f0ce4489bfd" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "b0c0659c-a57a-4acb-a906-5e3bf9ab2675" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "b2269673-9d47-471a-a958-24160608ae82" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "b735e23e-c928-41fc-b399-aa4a28807210" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "b7d7964a-3f03-4930-a23d-59d90711f002" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "b9b2181b-d620-4db0-9561-9c1ba02480bb" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "ba694638-8e1c-4398-a3db-50b879ea1414" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "ba7faac0-0e0c-4fb8-a329-5483da03032c" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "bb491436-8b44-4049-8f28-60b5689b6fd7" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "be76d6cb-0532-4dd5-8e4e-f944faf0106b" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "c2199980-e00d-45dd-bdb6-8497cfeac41d" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "c2c1137a-2957-489a-b6bc-a520a28c3206" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "c54c442f-e6a2-40b7-a022-3a58bccb2b3b" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "c5f0f42f-255f-400d-b657-bed222ec9903" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "c9ea88e7-aba3-4aa3-8dd7-0977a84004c9" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "cca9654e-d839-4e21-a23d-01fbb75e0a26" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "ccedb55a-6010-4ec9-913b-caa122d34ba7" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "cd88e529-eedb-42c5-a88d-384f5976a754" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "d496f336-c5ab-4648-841c-38853c4aa4f7" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "d4caf327-f110-4ab6-9305-c064a2071dc5" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "d51252c3-6e21-4ffc-aab3-f4bda791a574" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "dd39eee3-6b17-4b39-95e0-075ad1b704bd" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "ddc7879b-e104-4047-bd15-d0fade9bbeee" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "e60df533-79d7-42f2-a36d-99362dbc6f85" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "ecdb5eda-1cee-4e68-b100-160203158d57" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "ecf7b85e-8c3c-47ee-a80d-b0b360512c16" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "f102e342-a664-4b43-bcdb-b1c6945bf241" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "f3952051-fbde-4d44-a9b7-c3cb54027090" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "f42be566-1cc3-4863-9cf1-315828169000" },
                    { "05cd6e7f-9fdc-44a4-9fdc-60317f1872d9", "f4c4ffe2-e95d-4c05-a958-d32b26fecfc2" },
                    { "2abce592-b6aa-42c0-b20a-b0f97ce9e2eb", "ffd79ac4-d69f-4b74-b7c2-67e92905239a" }
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
