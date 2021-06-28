using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RSR.IDP.Migrations
{
    public partial class addeEmailfiledinUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("16cd0004-d15e-46f0-be68-72603ba6e277"), "2ddacd82-b5cf-4777-8210-5cbb3d6e4d6c" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("1baf30f9-056c-4bd3-99ca-73e57ead3bc1"), "62ac970c-6f4b-4c28-aff8-102424ea4a0e" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("2f9b96bb-d58f-4037-b9e4-b2501c445a1a"), "54a44e40-4009-41a1-afcf-d47824bdd036" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("55901e87-1a12-49b3-8e2d-55174684ce97"), "e39d7293-7f23-4195-9907-7cd8692b6a13" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("6667d0e6-bccf-4cfa-b554-5c18687ad711"), "3f30738a-ac89-4716-b0c9-05cbfb2eeff3" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("88a551d8-4b18-4099-9576-f31adff6c6de"), "5ae7a2d8-9708-49ee-8a98-6b68d8db713b" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("a9abe13b-e9ec-4050-b5cb-b4743480ab7f"), "75a08e0a-4cdb-4446-838d-81a617f2216c" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("ab91ae3d-c813-404d-81d2-6b641a16020d"), "d1fb9e1f-afbd-4bcb-afc8-44a105bc27be" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("c10f97d1-3edf-41ca-9797-84b68330ccde"), "ca257d6e-2472-439f-8f7c-b4e23d4a5acb" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("c9b336c3-e2dd-450a-ac14-3f418e836bfb"), "c9440092-f918-493e-9073-ff70d4fdecde" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("c9b731d0-a3ef-4cd3-b833-1687f824c47f"), "1ce7b068-2d35-4619-82db-918d64256a8c" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("cf01520a-274b-49bb-9878-d7df11eeb6c6"), "c9ba55d3-9bdf-4a81-8675-c588004af467" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("d53ae268-fea9-419d-9ec5-cb21b4b4fa2a"), "0afd0755-ed14-452d-815c-8809235995a6" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("dd09c7ff-1b65-4c4c-8dc2-29f76e700f0e"), "50560d2d-a40e-4aa1-8fd3-77399ad69535" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("e3859de0-44f7-49b4-b163-2e524f27ea03"), "a17a1d99-651d-4d72-9c65-8d2052148af1" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("f1abd751-a6a0-48b7-a60a-e4857f7d6e88"), "cf8c4367-12a6-4346-9e2d-040d3a5660fe" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("ffd28644-0041-4d57-9c18-040474d2c499"), "c7f4af81-5fbb-4419-a502-4dc54863901f" });

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "Users",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("7c77fd6e-68e9-48dd-9c65-84fb2b926bd2"), "7baa633b-5bec-4755-8624-f684a44b5fa3", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "RedSoilRock" },
                    { new Guid("f49b17af-c4bc-4d66-9df7-d217ebd59619"), "b9e6f19a-8c46-4662-ae8d-0c4ebe92f9db", "address", new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"), "Big Street 3" },
                    { new Guid("84a39d5d-832c-4556-8cf4-9b2dfb65e644"), "257fd586-b934-4ec1-96ce-7d9b3203e119", "family_name", new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"), "test" },
                    { new Guid("59735c38-ed93-44a3-824d-fbfed3803af7"), "0f6e7152-8222-4dd3-a8a9-f2ae244a1c66", "given_name", new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"), "RedSoilOfficeWorkplace" },
                    { new Guid("7d5669dd-769f-4146-b4b9-bdcec1bf20fe"), "51173848-b8a6-4d73-811e-fe59a9edd32b", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Orgnization" },
                    { new Guid("bc1762a5-e0bb-4a33-a776-cf48a31e4a42"), "3967d218-67a1-4260-987d-1daa042880db", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "India" },
                    { new Guid("27038ced-1c55-4aae-b4e2-0cf0b7f10f2b"), "a073e9bd-6f77-4e79-8318-4caa57fffae4", "subscriptionlevel", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "AffilatedOrganization" },
                    { new Guid("e7074fc5-1b40-4da9-afbe-5b7315a813ba"), "df8fcd2a-e0ed-4f47-ad1a-f0c3e28ffa7e", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("5d68dc4c-1aa9-4f85-911e-3a7a1c8fef5a"), "3da7d2b5-5bb0-4c2d-8408-2246144febb0", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Orgnization" },
                    { new Guid("11d88392-4566-438e-ac4b-aba677848314"), "1b624541-b5a6-42c0-8890-8369b359e764", "role", new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"), "WorkplaceProvider" },
                    { new Guid("ac120b5a-8b22-4d07-9d51-8cf43345d047"), "5bf92a64-941a-48e1-968b-d5efcc2306fd", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Individual" },
                    { new Guid("20ce0fab-4373-484d-bc6d-4e49b1cd3461"), "5b8bd617-ae06-4a4f-8903-7d4c3edaa944", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "India" },
                    { new Guid("17b34db7-9cb8-441e-8cfc-6161896c1a5a"), "ab4e93bf-d198-45dc-a181-1131efe89208", "subscriptionlevel", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("0d1ab26d-04c2-47f5-9e46-5a4c008914f0"), "ec0b8cb2-6a98-46e2-804d-88d05ec929e5", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("7db1208c-12e0-4a49-9d35-01d7b04e4f35"), "064c63de-ae44-436a-8aea-e45025f25b5e", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "RedSoil" },
                    { new Guid("f061d1ff-2394-4c22-96fa-8a03010bd5e8"), "1dfa3b2c-29c2-4289-b006-146058a44916", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "RedSoilNerd" },
                    { new Guid("9078c6ff-4bef-4561-b0f3-b8931b9148e3"), "44f93878-6f5d-4cc5-903f-ce1470b7fc47", "subscriptionlevel", new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"), "AffilatedWorkplaceProvider" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "1d33c947-3f95-4cd3-aa91-b9595fdcb719");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "4730ec30-ea91-4bf3-a75e-089876a303ca");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"),
                column: "ConcurrencyStamp",
                value: "b8d59863-5f10-445c-990b-a42bd37c427d");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("0d1ab26d-04c2-47f5-9e46-5a4c008914f0"), "ec0b8cb2-6a98-46e2-804d-88d05ec929e5" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("11d88392-4566-438e-ac4b-aba677848314"), "1b624541-b5a6-42c0-8890-8369b359e764" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("17b34db7-9cb8-441e-8cfc-6161896c1a5a"), "ab4e93bf-d198-45dc-a181-1131efe89208" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("20ce0fab-4373-484d-bc6d-4e49b1cd3461"), "5b8bd617-ae06-4a4f-8903-7d4c3edaa944" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("27038ced-1c55-4aae-b4e2-0cf0b7f10f2b"), "a073e9bd-6f77-4e79-8318-4caa57fffae4" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("59735c38-ed93-44a3-824d-fbfed3803af7"), "0f6e7152-8222-4dd3-a8a9-f2ae244a1c66" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("5d68dc4c-1aa9-4f85-911e-3a7a1c8fef5a"), "3da7d2b5-5bb0-4c2d-8408-2246144febb0" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("7c77fd6e-68e9-48dd-9c65-84fb2b926bd2"), "7baa633b-5bec-4755-8624-f684a44b5fa3" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("7d5669dd-769f-4146-b4b9-bdcec1bf20fe"), "51173848-b8a6-4d73-811e-fe59a9edd32b" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("7db1208c-12e0-4a49-9d35-01d7b04e4f35"), "064c63de-ae44-436a-8aea-e45025f25b5e" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("84a39d5d-832c-4556-8cf4-9b2dfb65e644"), "257fd586-b934-4ec1-96ce-7d9b3203e119" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("9078c6ff-4bef-4561-b0f3-b8931b9148e3"), "44f93878-6f5d-4cc5-903f-ce1470b7fc47" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("ac120b5a-8b22-4d07-9d51-8cf43345d047"), "5bf92a64-941a-48e1-968b-d5efcc2306fd" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("bc1762a5-e0bb-4a33-a776-cf48a31e4a42"), "3967d218-67a1-4260-987d-1daa042880db" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("e7074fc5-1b40-4da9-afbe-5b7315a813ba"), "df8fcd2a-e0ed-4f47-ad1a-f0c3e28ffa7e" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("f061d1ff-2394-4c22-96fa-8a03010bd5e8"), "1dfa3b2c-29c2-4289-b006-146058a44916" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("f49b17af-c4bc-4d66-9df7-d217ebd59619"), "b9e6f19a-8c46-4662-ae8d-0c4ebe92f9db" });

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCodeExpirationDate",
                table: "Users");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("e3859de0-44f7-49b4-b163-2e524f27ea03"), "a17a1d99-651d-4d72-9c65-8d2052148af1", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "RedSoilRock" },
                    { new Guid("cf01520a-274b-49bb-9878-d7df11eeb6c6"), "c9ba55d3-9bdf-4a81-8675-c588004af467", "address", new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"), "Big Street 3" },
                    { new Guid("1baf30f9-056c-4bd3-99ca-73e57ead3bc1"), "62ac970c-6f4b-4c28-aff8-102424ea4a0e", "family_name", new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"), "test" },
                    { new Guid("d53ae268-fea9-419d-9ec5-cb21b4b4fa2a"), "0afd0755-ed14-452d-815c-8809235995a6", "given_name", new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"), "RedSoilOfficeWorkplace" },
                    { new Guid("2f9b96bb-d58f-4037-b9e4-b2501c445a1a"), "54a44e40-4009-41a1-afcf-d47824bdd036", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Orgnization" },
                    { new Guid("88a551d8-4b18-4099-9576-f31adff6c6de"), "5ae7a2d8-9708-49ee-8a98-6b68d8db713b", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "India" },
                    { new Guid("55901e87-1a12-49b3-8e2d-55174684ce97"), "e39d7293-7f23-4195-9907-7cd8692b6a13", "subscriptionlevel", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "AffilatedOrganization" },
                    { new Guid("a9abe13b-e9ec-4050-b5cb-b4743480ab7f"), "75a08e0a-4cdb-4446-838d-81a617f2216c", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("6667d0e6-bccf-4cfa-b554-5c18687ad711"), "3f30738a-ac89-4716-b0c9-05cbfb2eeff3", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Orgnization" },
                    { new Guid("c10f97d1-3edf-41ca-9797-84b68330ccde"), "ca257d6e-2472-439f-8f7c-b4e23d4a5acb", "role", new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"), "WorkplaceProvider" },
                    { new Guid("c9b731d0-a3ef-4cd3-b833-1687f824c47f"), "1ce7b068-2d35-4619-82db-918d64256a8c", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Individual" },
                    { new Guid("ab91ae3d-c813-404d-81d2-6b641a16020d"), "d1fb9e1f-afbd-4bcb-afc8-44a105bc27be", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "India" },
                    { new Guid("ffd28644-0041-4d57-9c18-040474d2c499"), "c7f4af81-5fbb-4419-a502-4dc54863901f", "subscriptionlevel", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("c9b336c3-e2dd-450a-ac14-3f418e836bfb"), "c9440092-f918-493e-9073-ff70d4fdecde", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("f1abd751-a6a0-48b7-a60a-e4857f7d6e88"), "cf8c4367-12a6-4346-9e2d-040d3a5660fe", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "RedSoil" },
                    { new Guid("16cd0004-d15e-46f0-be68-72603ba6e277"), "2ddacd82-b5cf-4777-8210-5cbb3d6e4d6c", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "RedSoilNerd" },
                    { new Guid("dd09c7ff-1b65-4c4c-8dc2-29f76e700f0e"), "50560d2d-a40e-4aa1-8fd3-77399ad69535", "subscriptionlevel", new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"), "AffilatedWorkplaceProvider" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "38f2eae5-5525-49f1-9530-250f56cc051f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "25a611fb-5b5a-4ee5-8f52-5743a01f80d4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"),
                column: "ConcurrencyStamp",
                value: "2e8e4727-4383-4545-9d95-a8b7c4c5bce2");
        }
    }
}
