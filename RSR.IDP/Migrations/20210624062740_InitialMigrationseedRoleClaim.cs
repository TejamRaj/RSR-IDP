using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RSR.IDP.Migrations
{
    public partial class InitialMigrationseedRoleClaim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("0a854a26-e047-4bde-ae61-9f8adc7b2a45"), "b7a80e02-0218-4d74-b1be-0ae58fd0a49a" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("19595ce7-8f2e-4289-9a24-69575ef4cb6c"), "f4d85ec0-fef7-478a-9a04-59defabe449b" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("1966f789-bb41-4a2f-94d0-2376a7eb10d2"), "e88e1d70-0405-4d93-a0f3-c92732078f39" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("4f00ed8d-afee-43f0-9a41-259c5b3549ec"), "8112aeff-2168-43b3-9090-7a29036a1f92" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("5e6132a9-3ecd-457f-8a3f-33f0a1df4318"), "aa596f74-6971-4f68-a437-078df2cae7c5" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("68bdb943-895f-4838-af67-0ca7778ca75f"), "6f18ef01-85a6-4228-8b88-849075e4f1ed" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("6aa75bd3-3b71-4c7e-af83-7937e41efc61"), "b4752f3f-b82c-4fe0-845b-7028ffb0c8db" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("8877a2bd-5ef5-49e3-a7ea-d3b8cb0fc440"), "a899b498-2279-4916-8db8-c6fd764561a3" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("98108ccd-588e-4abf-899c-f6fa9055d795"), "59cf54c6-66bf-45c5-a800-f279bd7f92d8" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("a91917ab-53b2-48a5-9565-4daf783f50e8"), "81b12c7e-adee-49e0-abc1-33c9edc2c3d5" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("ab1f758f-6352-48b6-97c8-a1eef6fd0402"), "6bc6276c-aa7a-42c9-8254-9721ef51f15e" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("d89f3f47-3f57-4df7-9d21-cc21edf55816"), "97f26dcc-a6ee-4220-8b04-c97fafbd1d32" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("ed656ddc-ab83-4bed-9b11-5a1ec47882c8"), "5c5477dc-da43-4ad8-8548-4a6a90857da1" });

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("f0995d51-8a45-4b01-b6ef-a3983db1c11d"), "76130435-e864-4938-9afd-c879b2d6ed81" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("0a854a26-e047-4bde-ae61-9f8adc7b2a45"), "b7a80e02-0218-4d74-b1be-0ae58fd0a49a", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "RedSoilRock" },
                    { new Guid("8877a2bd-5ef5-49e3-a7ea-d3b8cb0fc440"), "a899b498-2279-4916-8db8-c6fd764561a3", "family_name", new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"), "test" },
                    { new Guid("ab1f758f-6352-48b6-97c8-a1eef6fd0402"), "6bc6276c-aa7a-42c9-8254-9721ef51f15e", "given_name", new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"), "RedSoilOfficeWorkplace" },
                    { new Guid("5e6132a9-3ecd-457f-8a3f-33f0a1df4318"), "aa596f74-6971-4f68-a437-078df2cae7c5", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "India" },
                    { new Guid("1966f789-bb41-4a2f-94d0-2376a7eb10d2"), "e88e1d70-0405-4d93-a0f3-c92732078f39", "subscriptionlevel", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "AffilatedOrganization" },
                    { new Guid("68bdb943-895f-4838-af67-0ca7778ca75f"), "6f18ef01-85a6-4228-8b88-849075e4f1ed", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("f0995d51-8a45-4b01-b6ef-a3983db1c11d"), "76130435-e864-4938-9afd-c879b2d6ed81", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Orgnization" },
                    { new Guid("a91917ab-53b2-48a5-9565-4daf783f50e8"), "81b12c7e-adee-49e0-abc1-33c9edc2c3d5", "address", new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"), "Big Street 3" },
                    { new Guid("d89f3f47-3f57-4df7-9d21-cc21edf55816"), "97f26dcc-a6ee-4220-8b04-c97fafbd1d32", "subscriptionlevel", new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"), "AffilatedWorkplaceProvider" },
                    { new Guid("98108ccd-588e-4abf-899c-f6fa9055d795"), "59cf54c6-66bf-45c5-a800-f279bd7f92d8", "subscriptionlevel", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("ed656ddc-ab83-4bed-9b11-5a1ec47882c8"), "5c5477dc-da43-4ad8-8548-4a6a90857da1", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("4f00ed8d-afee-43f0-9a41-259c5b3549ec"), "8112aeff-2168-43b3-9090-7a29036a1f92", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "RedSoil" },
                    { new Guid("6aa75bd3-3b71-4c7e-af83-7937e41efc61"), "b4752f3f-b82c-4fe0-845b-7028ffb0c8db", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "RedSoilNerd" },
                    { new Guid("19595ce7-8f2e-4289-9a24-69575ef4cb6c"), "f4d85ec0-fef7-478a-9a04-59defabe449b", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "India" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "4dcf3007-75bd-4d11-8805-d32eda2f7b9b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "282273fb-73dd-49e5-a89a-17a5ecfa3110");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7d1b5e8-ae26-41f7-90f8-4726bd722412"),
                column: "ConcurrencyStamp",
                value: "f8a56f63-70e6-4263-89ed-4902bcdf2810");
        }
    }
}
