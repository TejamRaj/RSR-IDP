using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RSR.IDP.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Subject = table.Column<string>(maxLength: 200, nullable: false),
                    Username = table.Column<string>(maxLength: 200, nullable: true),
                    Password = table.Column<string>(maxLength: 200, nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Type = table.Column<string>(maxLength: 250, nullable: false),
                    Value = table.Column<string>(maxLength: 250, nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "ConcurrencyStamp", "Password", "Subject", "Username" },
                values: new object[] { new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), true, "4dcf3007-75bd-4d11-8805-d32eda2f7b9b", "password", "6cecd6ae-653a-42bd-bc7c-fd135c1aaddb", "RedSoilNerd" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "ConcurrencyStamp", "Password", "Subject", "Username" },
                values: new object[] { new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), true, "282273fb-73dd-49e5-a89a-17a5ecfa3110", "password", "85ec1977-8471-439f-956c-5b2d0672f31e", "RedSoilRock" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "ConcurrencyStamp", "Password", "Subject", "Username" },
                values: new object[] { new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"), true, "f8a56f63-70e6-4263-89ed-4902bcdf2810", "password", "b1be83d4-31a3-4e57-beb4-d9c4b5e8abda", "WorkplaceProvider" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("6aa75bd3-3b71-4c7e-af83-7937e41efc61"), "b4752f3f-b82c-4fe0-845b-7028ffb0c8db", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "RedSoilNerd" },
                    { new Guid("4f00ed8d-afee-43f0-9a41-259c5b3549ec"), "8112aeff-2168-43b3-9090-7a29036a1f92", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "RedSoil" },
                    { new Guid("ed656ddc-ab83-4bed-9b11-5a1ec47882c8"), "5c5477dc-da43-4ad8-8548-4a6a90857da1", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("98108ccd-588e-4abf-899c-f6fa9055d795"), "59cf54c6-66bf-45c5-a800-f279bd7f92d8", "subscriptionlevel", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("19595ce7-8f2e-4289-9a24-69575ef4cb6c"), "f4d85ec0-fef7-478a-9a04-59defabe449b", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "India" },
                    { new Guid("0a854a26-e047-4bde-ae61-9f8adc7b2a45"), "b7a80e02-0218-4d74-b1be-0ae58fd0a49a", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "RedSoilRock" },
                    { new Guid("f0995d51-8a45-4b01-b6ef-a3983db1c11d"), "76130435-e864-4938-9afd-c879b2d6ed81", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Orgnization" },
                    { new Guid("68bdb943-895f-4838-af67-0ca7778ca75f"), "6f18ef01-85a6-4228-8b88-849075e4f1ed", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("1966f789-bb41-4a2f-94d0-2376a7eb10d2"), "e88e1d70-0405-4d93-a0f3-c92732078f39", "subscriptionlevel", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "AffilatedOrganization" },
                    { new Guid("5e6132a9-3ecd-457f-8a3f-33f0a1df4318"), "aa596f74-6971-4f68-a437-078df2cae7c5", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "India" },
                    { new Guid("ab1f758f-6352-48b6-97c8-a1eef6fd0402"), "6bc6276c-aa7a-42c9-8254-9721ef51f15e", "given_name", new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"), "RedSoilOfficeWorkplace" },
                    { new Guid("8877a2bd-5ef5-49e3-a7ea-d3b8cb0fc440"), "a899b498-2279-4916-8db8-c6fd764561a3", "family_name", new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"), "test" },
                    { new Guid("a91917ab-53b2-48a5-9565-4daf783f50e8"), "81b12c7e-adee-49e0-abc1-33c9edc2c3d5", "address", new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"), "Big Street 3" },
                    { new Guid("d89f3f47-3f57-4df7-9d21-cc21edf55816"), "97f26dcc-a6ee-4220-8b04-c97fafbd1d32", "subscriptionlevel", new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"), "AffilatedWorkplaceProvider" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Subject",
                table: "Users",
                column: "Subject",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
