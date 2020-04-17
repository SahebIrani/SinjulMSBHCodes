using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LinqPadDemo.Migrations
{
    public partial class NullableId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JackSlater_SinjulMSBH_SinjulMSBHId",
                table: "JackSlater");

            migrationBuilder.AlterColumn<long>(
                name: "SinjulMSBHId",
                table: "JackSlater",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 786, DateTimeKind.Unspecified).AddTicks(3780), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(1000), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 3L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(1416), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 4L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(1746), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(1979), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 6L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(2276), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(2559), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(2797), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(3079), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(3310), new TimeSpan(0, 0, 0, 0, 0)), true, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(3589), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(3817), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(4169), new TimeSpan(0, 0, 0, 0, 0)), true, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(4409), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(4691), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 16L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(4916), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(5200), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(5424), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(5709), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(5978), new TimeSpan(0, 0, 0, 0, 0)), true, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(6214), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(6570), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(6820), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(7203), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(7455), new TimeSpan(0, 0, 0, 0, 0)), false, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(7738), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(7965), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(8295), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(8530), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(8812), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(9038), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(9318), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(9542), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 788, DateTimeKind.Unspecified).AddTicks(9829), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(101), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(331), new TimeSpan(0, 0, 0, 0, 0)), true, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(605), new TimeSpan(0, 0, 0, 0, 0)), false, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(833), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(1108), new TimeSpan(0, 0, 0, 0, 0)), false, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 40L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(1335), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(1608), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(1833), new TimeSpan(0, 0, 0, 0, 0)), true, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(2137), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(2393), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(2683), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(2909), new TimeSpan(0, 0, 0, 0, 0)), true, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(3191), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(3414), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(3753), new TimeSpan(0, 0, 0, 0, 0)), true, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(3974), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(4258), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(4528), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(4751), new TimeSpan(0, 0, 0, 0, 0)), true, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(5020), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(5242), new TimeSpan(0, 0, 0, 0, 0)), false, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(5514), new TimeSpan(0, 0, 0, 0, 0)), false, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(5735), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(6038), new TimeSpan(0, 0, 0, 0, 0)), false, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(6268), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(6586), new TimeSpan(0, 0, 0, 0, 0)), true, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(7323), new TimeSpan(0, 0, 0, 0, 0)), true, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(7904), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(8313), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(8643), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(8869), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(9160), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(9439), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(9667), new TimeSpan(0, 0, 0, 0, 0)), true, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 789, DateTimeKind.Unspecified).AddTicks(9946), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(174), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(453), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(682), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(1088), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(1327), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(1618), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(1842), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(2125), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(2347), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(2631), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(2901), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(3130), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(3406), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(3633), new TimeSpan(0, 0, 0, 0, 0)), false, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(3911), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(4137), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(4413), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(4641), new TimeSpan(0, 0, 0, 0, 0)), false, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(5007), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(5243), new TimeSpan(0, 0, 0, 0, 0)), true, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(5526), new TimeSpan(0, 0, 0, 0, 0)), false, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(5752), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(6038), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(6258), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(6598), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(6871), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(7107), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 97L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(7427), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(7670), new TimeSpan(0, 0, 0, 0, 0)), false, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(7949), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(8175), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(8463), new TimeSpan(0, 0, 0, 0, 0)), false, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(8694), new TimeSpan(0, 0, 0, 0, 0)), false, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(8999), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(9236), new TimeSpan(0, 0, 0, 0, 0)), true, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(9518), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 790, DateTimeKind.Unspecified).AddTicks(9744), new TimeSpan(0, 0, 0, 0, 0)), false, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(27), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(251), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(532), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 110L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(753), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(1035), new TimeSpan(0, 0, 0, 0, 0)), false, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(1310), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(1542), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(1820), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(2048), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(2321), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(2547), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(2850), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(3087), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(3368), new TimeSpan(0, 0, 0, 0, 0)), true, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(3594), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(3932), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 123L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(4161), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(4450), new TimeSpan(0, 0, 0, 0, 0)), false, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(4673), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(4958), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(5178), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(5463), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(5738), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(5969), new TimeSpan(0, 0, 0, 0, 0)), false, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(6251), new TimeSpan(0, 0, 0, 0, 0)), true, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(6504), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(7136), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(7443), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(7761), new TimeSpan(0, 0, 0, 0, 0)), true, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(8039), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(8273), new TimeSpan(0, 0, 0, 0, 0)), true, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(8549), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(8778), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(9058), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(9287), new TimeSpan(0, 0, 0, 0, 0)), false, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(9560), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 791, DateTimeKind.Unspecified).AddTicks(9788), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(64), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(292), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(652), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(883), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(1212), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(1440), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(1723), new TimeSpan(0, 0, 0, 0, 0)), true, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(1946), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(2230), new TimeSpan(0, 0, 0, 0, 0)), false, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(2503), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(2732), new TimeSpan(0, 0, 0, 0, 0)), true, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(3003), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(3233), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 157L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(3506), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(3731), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(4004), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(4230), new TimeSpan(0, 0, 0, 0, 0)), false, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(4507), new TimeSpan(0, 0, 0, 0, 0)), true, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(4732), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(5042), new TimeSpan(0, 0, 0, 0, 0)), false, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(5267), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(5559), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(5779), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(6063), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(6336), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(6614), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(6983), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 171L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(7515), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(7746), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(8020), new TimeSpan(0, 0, 0, 0, 0)), true, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(8245), new TimeSpan(0, 0, 0, 0, 0)), true, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(8524), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(8749), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(9066), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(9292), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(9574), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 792, DateTimeKind.Unspecified).AddTicks(9797), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(82), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(303), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(583), new TimeSpan(0, 0, 0, 0, 0)), false, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(853), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(1084), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(1356), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(1585), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(1857), new TimeSpan(0, 0, 0, 0, 0)), true, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(2081), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(2356), new TimeSpan(0, 0, 0, 0, 0)), false, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(2583), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(2890), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(3121), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(3471), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(3700), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(3991), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(4211), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(4491), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(4758), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(4991), new TimeSpan(0, 0, 0, 0, 0)), false, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(5260), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(5489), new TimeSpan(0, 0, 0, 0, 0)), false, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(5764), new TimeSpan(0, 0, 0, 0, 0)), true, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(5990), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(6266), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(6525), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(7036), new TimeSpan(0, 0, 0, 0, 0)), true, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(7383), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(7695), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(7925), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(8209), new TimeSpan(0, 0, 0, 0, 0)), true, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(8434), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(8719), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(8939), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(9222), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(9492), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(9722), new TimeSpan(0, 0, 0, 0, 0)), false, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 793, DateTimeKind.Unspecified).AddTicks(9995), new TimeSpan(0, 0, 0, 0, 0)), true, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 220L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(222), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(495), new TimeSpan(0, 0, 0, 0, 0)), false, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(723), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(1079), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(1321), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(1606), new TimeSpan(0, 0, 0, 0, 0)), false, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(1830), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(2112), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(2334), new TimeSpan(0, 0, 0, 0, 0)), true, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(2613), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(2832), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(3112), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(3329), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(3613), new TimeSpan(0, 0, 0, 0, 0)), true, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(3885), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(4111), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(4382), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 237L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(4608), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(4916), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(5153), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(5430), new TimeSpan(0, 0, 0, 0, 0)), false, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 241L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(5656), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(5932), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(6158), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(6434), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(6703), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 246L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(6992), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(7211), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(7587), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(7863), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(8094), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(8367), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(8595), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(8894), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(9128), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(9404), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 256L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(9631), new TimeSpan(0, 0, 0, 0, 0)), true, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 257L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 794, DateTimeKind.Unspecified).AddTicks(9906), new TimeSpan(0, 0, 0, 0, 0)), false, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 258L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(193), new TimeSpan(0, 0, 0, 0, 0)), true, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 259L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(419), new TimeSpan(0, 0, 0, 0, 0)), false, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 260L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(697), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 261L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(919), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 262L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(1201), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 263L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(1422), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 264L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(1702), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 265L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(1998), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 266L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(2230), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 267L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(2531), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 268L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(2767), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 269L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(3101), new TimeSpan(0, 0, 0, 0, 0)), true, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 270L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(3342), new TimeSpan(0, 0, 0, 0, 0)), true, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 271L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(3617), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 272L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(3842), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 273L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(4116), new TimeSpan(0, 0, 0, 0, 0)), true, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 274L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(4340), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 275L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(4624), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 276L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(4848), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 277L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(5128), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 278L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(5351), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 279L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(5625), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 280L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(5844), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 281L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(6120), new TimeSpan(0, 0, 0, 0, 0)), false, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 282L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(6414), new TimeSpan(0, 0, 0, 0, 0)), false, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 283L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(6799), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 284L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(7218), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 285L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(7459), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 286L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(7733), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 287L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(7959), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 288L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(8233), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 289L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(8458), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 290L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(8737), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 291L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(8959), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 292L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(9235), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 293L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(9456), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 294L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 795, DateTimeKind.Unspecified).AddTicks(9787), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 295L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(14), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 296L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(323), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 297L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(643), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 298L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(889), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 299L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(1184), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(1418), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(1692), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(1919), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(2193), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 304L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(2419), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 305L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(2695), new TimeSpan(0, 0, 0, 0, 0)), false, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 306L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(2923), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 307L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(3200), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 308L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(3424), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 309L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(3702), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 310L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(3925), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 311L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(4205), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 312L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(4425), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 313L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(4736), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 314L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(5014), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 315L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(5246), new TimeSpan(0, 0, 0, 0, 0)), false, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 316L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(5518), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 317L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(5747), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 318L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(6078), new TimeSpan(0, 0, 0, 0, 0)), false, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 319L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(6316), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 320L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(6636), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 321L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(6871), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 322L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(7148), new TimeSpan(0, 0, 0, 0, 0)), true, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 323L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(7372), new TimeSpan(0, 0, 0, 0, 0)), true, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 324L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(7654), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 325L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(7878), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 326L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(8160), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 327L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(8383), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 328L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(8703), new TimeSpan(0, 0, 0, 0, 0)), false, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 329L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(8924), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 330L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(9214), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 331L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(9537), new TimeSpan(0, 0, 0, 0, 0)), false, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 332L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 796, DateTimeKind.Unspecified).AddTicks(9781), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 333L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(58), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 334L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(284), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 335L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(556), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 336L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(783), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 337L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(1055), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 338L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(1282), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 339L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(1563), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 340L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(1786), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 341L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(2011), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 342L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(2344), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 343L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(2568), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 344L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(2869), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 345L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(3087), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 346L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(3368), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 347L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(3640), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 348L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(3866), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 349L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(4142), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 350L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(4369), new TimeSpan(0, 0, 0, 0, 0)), true, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 351L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(4645), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 352L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(4873), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 353L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(5146), new TimeSpan(0, 0, 0, 0, 0)), false, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 354L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(5374), new TimeSpan(0, 0, 0, 0, 0)), true, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 355L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(5701), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 356L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(5933), new TimeSpan(0, 0, 0, 0, 0)), true, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 357L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(6253), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 358L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(6510), new TimeSpan(0, 0, 0, 0, 0)), false, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 359L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(7090), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 360L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(7370), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 361L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(7685), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 362L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(7961), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 363L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(8191), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 364L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(8465), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 365L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(8695), new TimeSpan(0, 0, 0, 0, 0)), false, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 366L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(8971), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 367L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(9225), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 368L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(9503), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 369L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 797, DateTimeKind.Unspecified).AddTicks(9728), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 370L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(5), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 371L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(231), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 372L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(561), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 373L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(788), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 374L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(1071), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 375L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(1293), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 376L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(1573), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 377L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(1793), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 378L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(2073), new TimeSpan(0, 0, 0, 0, 0)), false, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 379L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(2434), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 380L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(2687), new TimeSpan(0, 0, 0, 0, 0)), true, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 381L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(2963), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 382L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(3192), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 383L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(3466), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 384L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 385L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(3965), new TimeSpan(0, 0, 0, 0, 0)), false, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 386L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(4192), new TimeSpan(0, 0, 0, 0, 0)), false, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 387L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(4520), new TimeSpan(0, 0, 0, 0, 0)), false, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 388L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(4755), new TimeSpan(0, 0, 0, 0, 0)), true, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 389L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(5037), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 390L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(5260), new TimeSpan(0, 0, 0, 0, 0)), true, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 391L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(5544), new TimeSpan(0, 0, 0, 0, 0)), false, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 392L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(5767), new TimeSpan(0, 0, 0, 0, 0)), true, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 393L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(6049), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 394L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(6319), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 395L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(6588), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 396L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(6872), new TimeSpan(0, 0, 0, 0, 0)), false, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 397L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(7101), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 398L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(7375), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 399L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(7602), new TimeSpan(0, 0, 0, 0, 0)), true, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 400L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(7879), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 401L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 402L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(8405), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 403L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(8637), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 404L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(8963), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 405L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(9192), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 406L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(9478), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 407L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(9702), new TimeSpan(0, 0, 0, 0, 0)), false, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 408L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 798, DateTimeKind.Unspecified).AddTicks(9985), new TimeSpan(0, 0, 0, 0, 0)), false, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 409L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(208), new TimeSpan(0, 0, 0, 0, 0)), true, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 410L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(490), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 411L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(760), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 412L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(990), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 413L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(1264), new TimeSpan(0, 0, 0, 0, 0)), false, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 414L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(1490), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 415L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(1762), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 416L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(1987), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 417L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(2292), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 418L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(2529), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 419L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(2809), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 420L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(3036), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 421L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(3316), new TimeSpan(0, 0, 0, 0, 0)), true, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 422L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(3540), new TimeSpan(0, 0, 0, 0, 0)), true, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 423L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(3821), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 424L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(4039), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 425L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(4320), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 426L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(4539), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 427L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(4823), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 428L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(5137), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 429L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(5378), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 430L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(5654), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 431L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(5880), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 432L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(6179), new TimeSpan(0, 0, 0, 0, 0)), true, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 433L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(6409), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 434L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(6724), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 435L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(6953), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 436L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(7229), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 437L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(7453), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 438L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(7731), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 439L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(7954), new TimeSpan(0, 0, 0, 0, 0)), false, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 440L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 799, DateTimeKind.Unspecified).AddTicks(8232), new TimeSpan(0, 0, 0, 0, 0)), false, 22L });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 1L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 774, DateTimeKind.Unspecified).AddTicks(373), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 774, DateTimeKind.Unspecified).AddTicks(8656), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 3L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 774, DateTimeKind.Unspecified).AddTicks(9150), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 774, DateTimeKind.Unspecified).AddTicks(9440), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 774, DateTimeKind.Unspecified).AddTicks(9656), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 6L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 774, DateTimeKind.Unspecified).AddTicks(9913), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 7L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(124), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(317), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 9L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(649), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 10L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(847), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 11L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(1108), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 12L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(1351), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 13L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(1619), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(1817), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(2069), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(2268), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(2629), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(2853), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 19L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(3103), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 20L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(3318), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(3509), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 22L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(3762), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 23L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(3953), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 24L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(4203), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(4408), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(4691), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 27L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(4922), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 28L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(5211), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(5416), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(5661), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 31L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(5864), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(6058), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(6457), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(6780), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(7065), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 36L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(7261), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(7513), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 38L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(7960), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(8159), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 41L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(8409), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(8609), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(8882), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(9091), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 45L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(9282), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(9609), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 775, DateTimeKind.Unspecified).AddTicks(9803), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(60), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(255), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(503), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(699), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 52L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(947), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 53L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(1144), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(1392), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 55L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(1593), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(1784), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(2038), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(2228), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(2480), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(2672), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 61L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(2947), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 62L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(3151), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(3396), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 64L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(3597), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(3846), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 66L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(4048), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(4298), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(4498), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 69L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(4741), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(4940), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(5127), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 72L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(5380), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 73L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(5571), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(5882), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(6080), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(6448), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 77L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(6692), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(6985), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 79L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(7196), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(7444), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 81L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(7648), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(7837), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 83L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(8095), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 84L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(8287), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(8544), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 86L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(8736), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 87L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(8986), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(9434), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(9632), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 776, DateTimeKind.Unspecified).AddTicks(9879), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 92L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(79), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 93L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(268), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(520), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(711), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 96L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(993), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(1188), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 98L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(1438), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(1635), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(1881), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(2079), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 102L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(2402), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(2616), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(2865), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(3067), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(3259), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 107L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(3516), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 108L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(3709), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 109L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(3961), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 110L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(4159), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 111L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(4407), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 112L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(4604), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 113L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(4890), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 114L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(5180), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(5389), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 116L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(5635), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(5838), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(6031), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 119L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(6410), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(6719), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(6998), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(7196), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 123L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(7445), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(7641), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(7888), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(8087), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(8331), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 128L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(8532), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 129L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(8723), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(8980), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 131L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(9254), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(9462), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(9706), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 777, DateTimeKind.Unspecified).AddTicks(9910), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 135L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(100), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 136L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(356), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(548), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 138L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(861), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(1065), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 140L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(1317), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 141L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(1514), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(1760), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(1961), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(2202), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 145L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(2399), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(2589), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(2842), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(3034), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(3320), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 150L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(3515), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(3764), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 152L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(3961), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(4207), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 154L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(4402), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 155L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(4644), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 156L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(4844), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 157L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(5034), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(5288), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(5480), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(5734), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 161L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(5926), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(6171), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(6499), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(6791), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(6991), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 166L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(7333), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 167L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(7556), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 168L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(7748), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(8011), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(8203), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 171L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(8458), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(8652), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 173L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(8899), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 174L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(9099), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(9343), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(9542), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 177L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(9788), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 778, DateTimeKind.Unspecified).AddTicks(9987), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(227), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 180L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(428), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(618), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(873), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(1069), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 184L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(1349), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 185L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(1548), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 186L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(1797), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(1994), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 188L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(2239), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(2437), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 190L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(2679), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(2881), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(3070), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(3327), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(3521), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 195L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(3823), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(4024), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(4273), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 198L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(4471), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 199L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(4716), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(4914), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(5184), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 202L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(5392), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(5585), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 204L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(5844), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(6034), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 206L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(6386), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 207L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(7426), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(7862), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(8089), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(8349), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 211L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(8553), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(8805), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 213L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(9010), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(9201), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(9460), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(9652), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 217L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 779, DateTimeKind.Unspecified).AddTicks(9909), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 218L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(103), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 219L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(403), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 220L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(610), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 221L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(861), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 222L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(1062), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(1386), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 224L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(1609), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(1854), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 226L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(2062), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(2254), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 228L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(2510), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 229L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(2706), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(2957), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 231L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(3155), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 232L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(3403), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(3600), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 234L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(3846), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(4048), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(4317), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(4531), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(4724), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 239L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(4982), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 240L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(5177), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 241L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(5428), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 242L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(5626), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(5874), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 244L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(6075), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 245L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(6322), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 246L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(6571), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(7142), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(7424), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 249L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(7621), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(7882), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 251L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(8074), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 252L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(8410), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 253L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(8610), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 254L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(8895), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 255L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(9102), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 256L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(9353), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 257L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(9551), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 258L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 780, DateTimeKind.Unspecified).AddTicks(9804), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 259L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(52), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 260L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(254), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 261L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(445), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 262L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(697), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 263L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(887), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 264L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(1138), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 265L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(1332), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 266L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(1579), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 267L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(1776), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 268L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(2022), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 269L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(2221), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 270L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(2488), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 271L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(2693), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 272L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(2883), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 273L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(3136), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 274L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(3325), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 275L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(3581), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 276L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(3775), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 277L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(4022), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 278L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(4218), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 279L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(4504), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 280L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(4713), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 281L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(4963), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 282L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(5165), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 283L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(5354), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 284L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(5605), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 285L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(5797), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 286L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(6050), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 287L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(6240), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 288L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(6557), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 289L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(6773), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 290L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(7026), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 291L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(7225), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 292L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(7473), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 293L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(7671), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 294L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(7911), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 295L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(8113), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 296L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(8303), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 297L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(8551), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 298L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(8744), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 299L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(8991), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 300L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(9186), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 301L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(9429), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 302L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(9625), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 303L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 781, DateTimeKind.Unspecified).AddTicks(9871), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 304L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(70), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 305L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(333), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 306L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(543), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 307L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(733), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 308L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(1033), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 309L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(1227), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 310L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(1476), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 311L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(1672), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 312L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(1922), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 313L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(2119), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 314L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(2364), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 315L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(2561), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 316L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(2803), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 317L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(3004), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 318L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(3196), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 319L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(3449), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 320L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(3641), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 321L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(3897), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 322L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(4093), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 323L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(4365), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 324L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(4572), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 325L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(4819), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 326L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(5016), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 327L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(5259), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 328L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(5459), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 329L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(5650), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 330L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(5902), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 331L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(6096), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 332L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(6348), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 333L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(6580), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 334L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(6835), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 335L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(7033), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 336L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(7353), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 337L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(7564), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 338L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(7811), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 339L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(8012), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 340L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(8277), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 341L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(8490), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 342L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(8682), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 343L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(8935), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 344L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(9128), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 345L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(9376), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 346L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(9572), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 347L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 782, DateTimeKind.Unspecified).AddTicks(9817), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 348L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(15), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 349L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(258), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 350L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(457), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 351L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(697), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 352L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(898), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 353L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(1089), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 354L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(1340), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 355L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(1531), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 356L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(1779), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 357L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(1977), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 358L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(2249), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 359L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(2451), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 360L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(2696), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 361L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(2895), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 362L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(3136), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 363L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(3334), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 364L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(3525), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 365L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(3825), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 366L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(4019), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 367L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(4273), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 368L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(4468), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 369L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(4715), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 370L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(4910), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 371L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(5154), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 372L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(5349), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 373L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(5593), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 374L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(5790), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 375L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(5981), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 376L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(6276), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 377L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(6469), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 378L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(7019), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 379L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(7301), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 380L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(7583), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 381L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(7789), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 382L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(8036), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 383L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(8239), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 384L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(8490), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 385L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(8692), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 386L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(8885), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 387L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(9143), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 388L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(9338), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 389L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(9592), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 390L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 783, DateTimeKind.Unspecified).AddTicks(9788), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 391L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(39), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 392L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(240), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 393L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(578), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 394L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(800), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 395L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(1051), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 396L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(1257), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 397L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(1499), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 398L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(1703), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 399L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(1896), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 400L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(2151), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 401L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(2347), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 402L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(2599), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 403L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(2797), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 404L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(3052), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 405L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(3251), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 406L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(3558), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 407L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(3765), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 408L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(4013), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 409L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(4218), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 410L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(4410), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 411L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(4668), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 412L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(4862), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 413L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(5120), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 414L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(5318), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 415L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(5640), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 416L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(5852), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 417L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(6104), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 418L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(6306), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 419L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(6597), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 420L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(6809), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 421L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(7002), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 422L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(7259), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 423L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(7454), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 424L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(7740), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 425L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(7937), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 426L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(8185), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 427L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(8386), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 428L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(8636), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 429L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(8835), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 430L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(9083), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 431L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(9283), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 432L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(9474), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 433L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(9727), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 434L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 784, DateTimeKind.Unspecified).AddTicks(9920), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 435L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 785, DateTimeKind.Unspecified).AddTicks(175), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 436L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 785, DateTimeKind.Unspecified).AddTicks(369), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 437L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 785, DateTimeKind.Unspecified).AddTicks(619), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 438L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 785, DateTimeKind.Unspecified).AddTicks(817), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 439L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 785, DateTimeKind.Unspecified).AddTicks(1063), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 440L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 11, 17, 58, 785, DateTimeKind.Unspecified).AddTicks(1263), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.AddForeignKey(
                name: "FK_JackSlater_SinjulMSBH_SinjulMSBHId",
                table: "JackSlater",
                column: "SinjulMSBHId",
                principalTable: "SinjulMSBH",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JackSlater_SinjulMSBH_SinjulMSBHId",
                table: "JackSlater");

            migrationBuilder.AlterColumn<long>(
                name: "SinjulMSBHId",
                table: "JackSlater",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 660, DateTimeKind.Unspecified).AddTicks(6120), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(2666), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 3L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(2985), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 4L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(3294), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(3531), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 6L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(3826), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(4054), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(4349), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(4571), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(4887), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(5434), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(5805), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(6121), new TimeSpan(0, 0, 0, 0, 0)), false, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(6366), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(6648), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 16L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(6879), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(7269), new TimeSpan(0, 0, 0, 0, 0)), true, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(7517), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(7803), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(8026), new TimeSpan(0, 0, 0, 0, 0)), false, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(8317), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(8540), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(8829), new TimeSpan(0, 0, 0, 0, 0)), false, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(9110), new TimeSpan(0, 0, 0, 0, 0)), true, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(9338), new TimeSpan(0, 0, 0, 0, 0)), true, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(9616), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 661, DateTimeKind.Unspecified).AddTicks(9844), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(124), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(352), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(632), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(859), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(1163), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(1386), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(1671), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(1943), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(2178), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(2497), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(2744), new TimeSpan(0, 0, 0, 0, 0)), true, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(3024), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 40L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(3252), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(3576), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(3812), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(4097), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(4323), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(4603), new TimeSpan(0, 0, 0, 0, 0)), false, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(4827), new TimeSpan(0, 0, 0, 0, 0)), false, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(5135), new TimeSpan(0, 0, 0, 0, 0)), false, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(5359), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(5642), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(5921), new TimeSpan(0, 0, 0, 0, 0)), false, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(6154), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(6436), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(6668), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(6942), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(7171), new TimeSpan(0, 0, 0, 0, 0)), true, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(7444), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(7668), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(7948), new TimeSpan(0, 0, 0, 0, 0)), true, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(8168), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(8452), new TimeSpan(0, 0, 0, 0, 0)), false, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(8673), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(8982), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(9256), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(9485), new TimeSpan(0, 0, 0, 0, 0)), true, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 662, DateTimeKind.Unspecified).AddTicks(9800), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(40), new TimeSpan(0, 0, 0, 0, 0)), true, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(321), new TimeSpan(0, 0, 0, 0, 0)), true, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(547), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(824), new TimeSpan(0, 0, 0, 0, 0)), true, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(1045), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(1328), new TimeSpan(0, 0, 0, 0, 0)), true, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(1549), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(1832), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(2106), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(2335), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(2681), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(2917), new TimeSpan(0, 0, 0, 0, 0)), true, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(3199), new TimeSpan(0, 0, 0, 0, 0)), false, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(3427), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(3705), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(3932), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(4212), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(4437), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(4720), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(4942), new TimeSpan(0, 0, 0, 0, 0)), false, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(5227), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(5497), new TimeSpan(0, 0, 0, 0, 0)), true, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(5732), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(6092), new TimeSpan(0, 0, 0, 0, 0)), false, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), true, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(6643), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(6881), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(7160), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(7389), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(7671), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(7897), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 97L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(8178), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(8401), new TimeSpan(0, 0, 0, 0, 0)), true, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(8684), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(8905), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(9191), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(9467), new TimeSpan(0, 0, 0, 0, 0)), true, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 663, DateTimeKind.Unspecified).AddTicks(9976), new TimeSpan(0, 0, 0, 0, 0)), false, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(205), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(552), new TimeSpan(0, 0, 0, 0, 0)), true, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(791), new TimeSpan(0, 0, 0, 0, 0)), false, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(1299), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 110L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(1584), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(1809), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(2090), new TimeSpan(0, 0, 0, 0, 0)), true, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(2310), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(2687), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(2966), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(3204), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(3480), new TimeSpan(0, 0, 0, 0, 0)), false, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(3709), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(4000), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(4231), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(4533), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(4766), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 123L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(5161), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(5437), new TimeSpan(0, 0, 0, 0, 0)), true, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(5734), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(5960), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(6243), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(6468), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(6751), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(7035), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(7262), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(7540), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(7764), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(8045), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(8269), new TimeSpan(0, 0, 0, 0, 0)), false, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(8580), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(8903), new TimeSpan(0, 0, 0, 0, 0)), false, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(9151), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(9434), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(9666), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 664, DateTimeKind.Unspecified).AddTicks(9942), new TimeSpan(0, 0, 0, 0, 0)), true, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(171), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(449), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(674), new TimeSpan(0, 0, 0, 0, 0)), false, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(955), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(1179), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(1460), new TimeSpan(0, 0, 0, 0, 0)), true, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(1682), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(1965), new TimeSpan(0, 0, 0, 0, 0)), true, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(2261), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(2499), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(3086), new TimeSpan(0, 0, 0, 0, 0)), true, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(3434), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(3748), new TimeSpan(0, 0, 0, 0, 0)), false, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(3986), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(4267), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 157L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(4498), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(4782), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(5012), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(5296), new TimeSpan(0, 0, 0, 0, 0)), true, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(5520), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(5914), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(6139), new TimeSpan(0, 0, 0, 0, 0)), true, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(6437), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(6746), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(6985), new TimeSpan(0, 0, 0, 0, 0)), true, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(7264), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(7496), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(7777), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(8005), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 171L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(8281), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(8508), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(8790), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(9016), new TimeSpan(0, 0, 0, 0, 0)), false, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(9301), new TimeSpan(0, 0, 0, 0, 0)), false, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(9523), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 665, DateTimeKind.Unspecified).AddTicks(9804), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(77), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(311), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(607), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(838), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(1116), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(1345), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(1619), new TimeSpan(0, 0, 0, 0, 0)), true, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(1844), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(2175), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(2407), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(2737), new TimeSpan(0, 0, 0, 0, 0)), false, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(2966), new TimeSpan(0, 0, 0, 0, 0)), false, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(3256), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(3478), new TimeSpan(0, 0, 0, 0, 0)), true, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(3760), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(4037), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(4269), new TimeSpan(0, 0, 0, 0, 0)), false, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(4568), new TimeSpan(0, 0, 0, 0, 0)), false, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(4800), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(5076), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(5301), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(5575), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(5801), new TimeSpan(0, 0, 0, 0, 0)), false, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(6081), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(6304), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(6587), new TimeSpan(0, 0, 0, 0, 0)), true, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(6807), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(7089), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(7363), new TimeSpan(0, 0, 0, 0, 0)), false, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(7595), new TimeSpan(0, 0, 0, 0, 0)), false, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(7943), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(8183), new TimeSpan(0, 0, 0, 0, 0)), false, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(8464), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(8692), new TimeSpan(0, 0, 0, 0, 0)), true, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(8972), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(9199), new TimeSpan(0, 0, 0, 0, 0)), false, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(9479), new TimeSpan(0, 0, 0, 0, 0)), true, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(9700), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 666, DateTimeKind.Unspecified).AddTicks(9980), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(203), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(490), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(712), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 220L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(1001), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(1331), new TimeSpan(0, 0, 0, 0, 0)), true, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(1574), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(1879), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(2114), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(2393), new TimeSpan(0, 0, 0, 0, 0)), true, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(2659), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(2946), new TimeSpan(0, 0, 0, 0, 0)), true, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(3173), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(3456), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(3678), new TimeSpan(0, 0, 0, 0, 0)), false, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(3962), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(4183), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(4470), new TimeSpan(0, 0, 0, 0, 0)), false, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(4743), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(4975), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(5250), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 237L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(5478), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(5783), new TimeSpan(0, 0, 0, 0, 0)), true, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(6012), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(6289), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 241L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(6515), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(6796), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(7023), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(7300), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(7524), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 246L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(7856), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(8076), new TimeSpan(0, 0, 0, 0, 0)), true, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(8362), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(8638), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(8869), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(9145), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(9373), new TimeSpan(0, 0, 0, 0, 0)), false, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(9670), new TimeSpan(0, 0, 0, 0, 0)), true, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 667, DateTimeKind.Unspecified).AddTicks(9899), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(175), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 256L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(400), new TimeSpan(0, 0, 0, 0, 0)), false, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 257L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(682), new TimeSpan(0, 0, 0, 0, 0)), true, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 258L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(969), new TimeSpan(0, 0, 0, 0, 0)), false, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 259L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(1197), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 260L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(1483), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 261L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(1751), new TimeSpan(0, 0, 0, 0, 0)), true, 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 262L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(1989), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 263L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(2267), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 264L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(2497), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 265L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(2820), new TimeSpan(0, 0, 0, 0, 0)), true, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 266L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(3051), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 267L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(3359), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 268L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(3590), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 269L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(3921), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 270L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(4151), new TimeSpan(0, 0, 0, 0, 0)), false, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 271L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(4433), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 272L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(4657), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 273L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(4936), new TimeSpan(0, 0, 0, 0, 0)), false, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 274L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(5156), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 275L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(5435), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 276L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(5710), new TimeSpan(0, 0, 0, 0, 0)), true, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 277L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(5941), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 278L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(6214), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 279L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(6442), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 280L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(6718), new TimeSpan(0, 0, 0, 0, 0)), true, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 281L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(6944), new TimeSpan(0, 0, 0, 0, 0)), true, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 282L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(7244), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 283L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(7476), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 284L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(7755), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 285L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(7978), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 286L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(8260), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 287L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(8482), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 288L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(8765), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 289L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(9035), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 290L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(9270), new TimeSpan(0, 0, 0, 0, 0)), true, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 291L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(9543), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 292L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 668, DateTimeKind.Unspecified).AddTicks(9770), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 293L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(114), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 294L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(351), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 295L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(638), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 296L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(873), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 297L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(1184), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 298L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(1414), new TimeSpan(0, 0, 0, 0, 0)), false, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 299L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(1694), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 300L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(1918), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 301L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(2198), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 302L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(2420), new TimeSpan(0, 0, 0, 0, 0)), 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 303L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(2746), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 304L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(3028), new TimeSpan(0, 0, 0, 0, 0)), true, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 305L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(3266), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 306L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(3539), new TimeSpan(0, 0, 0, 0, 0)), false, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 307L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(3767), new TimeSpan(0, 0, 0, 0, 0)), false, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 308L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(4043), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 309L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(4271), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 310L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(4547), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 311L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(4773), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 312L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(5075), new TimeSpan(0, 0, 0, 0, 0)), false, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 313L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(5301), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 314L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(5583), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 315L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(5805), new TimeSpan(0, 0, 0, 0, 0)), true, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 316L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(6090), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 317L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(6392), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 318L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(6642), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 319L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(6921), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 320L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(7152), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 321L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(7431), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 322L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(7658), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 323L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(7936), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 324L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(8162), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 325L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(8437), new TimeSpan(0, 0, 0, 0, 0)), true, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 326L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(8660), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 327L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(8971), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 328L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)), true, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 329L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(9479), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 330L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(9701), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 331L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 669, DateTimeKind.Unspecified).AddTicks(9986), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 332L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(260), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 333L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(492), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 334L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(764), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 335L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(993), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 336L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(1270), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 337L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(1495), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 338L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(1771), new TimeSpan(0, 0, 0, 0, 0)), false, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 339L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(1997), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 340L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(2280), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 341L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(2502), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 342L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(3093), new TimeSpan(0, 0, 0, 0, 0)), false, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 343L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(3334), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 344L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(3633), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 345L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(3906), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 346L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(4145), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 347L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(4423), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 348L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(4653), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 349L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(4963), new TimeSpan(0, 0, 0, 0, 0)), true, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 350L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(5195), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 351L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(5472), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 352L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(5700), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 353L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(5978), new TimeSpan(0, 0, 0, 0, 0)), true, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 354L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(6205), new TimeSpan(0, 0, 0, 0, 0)), false, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 355L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(6486), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 356L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(6710), new TimeSpan(0, 0, 0, 0, 0)), false, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 357L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(7030), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 358L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(7253), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 359L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(7538), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 360L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(7812), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 361L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(8045), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 362L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(8319), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 363L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(8548), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 364L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(8827), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 365L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(9053), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 366L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(9379), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 367L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(9616), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 368L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 670, DateTimeKind.Unspecified).AddTicks(9901), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 369L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(127), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 370L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(411), new TimeSpan(0, 0, 0, 0, 0)), true, 13L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 371L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(635), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 372L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(946), new TimeSpan(0, 0, 0, 0, 0)), true, 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 373L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(1221), new TimeSpan(0, 0, 0, 0, 0)), false, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 374L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(1455), new TimeSpan(0, 0, 0, 0, 0)), false, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 375L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(1729), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 376L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(1957), new TimeSpan(0, 0, 0, 0, 0)), 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 377L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(2249), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 378L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(2475), new TimeSpan(0, 0, 0, 0, 0)), true, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 379L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(2797), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 380L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(3026), new TimeSpan(0, 0, 0, 0, 0)), false, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 381L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(3300), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 382L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(3528), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 383L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(3807), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 384L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(4028), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 385L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(4312), new TimeSpan(0, 0, 0, 0, 0)), true, 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 386L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(4535), new TimeSpan(0, 0, 0, 0, 0)), true, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 387L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(4852), new TimeSpan(0, 0, 0, 0, 0)), true, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 388L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(5125), new TimeSpan(0, 0, 0, 0, 0)), false, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 389L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(5355), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 390L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(5672), new TimeSpan(0, 0, 0, 0, 0)), false, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 391L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(5910), new TimeSpan(0, 0, 0, 0, 0)), true, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 392L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(6190), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 393L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(6418), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 394L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(6691), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 395L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(6919), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 396L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(7197), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 397L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(7421), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 398L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(7705), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 399L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(7928), new TimeSpan(0, 0, 0, 0, 0)), false, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 400L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(8210), new TimeSpan(0, 0, 0, 0, 0)), 33L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 401L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(8500), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 402L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(8738), new TimeSpan(0, 0, 0, 0, 0)), 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 403L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(9011), new TimeSpan(0, 0, 0, 0, 0)), true, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 404L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(9238), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 405L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(9516), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 406L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 671, DateTimeKind.Unspecified).AddTicks(9743), new TimeSpan(0, 0, 0, 0, 0)), true, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 407L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(25), new TimeSpan(0, 0, 0, 0, 0)), true, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 408L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(252), new TimeSpan(0, 0, 0, 0, 0)), true, 17L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 409L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(528), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 410L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(751), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 411L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(1028), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 412L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(1247), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 413L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(1532), new TimeSpan(0, 0, 0, 0, 0)), true, 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 414L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(1752), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 415L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(2079), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 416L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(2377), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 417L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(2650), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 418L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(2937), new TimeSpan(0, 0, 0, 0, 0)), true, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 419L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(3163), new TimeSpan(0, 0, 0, 0, 0)), 26L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 420L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(3439), new TimeSpan(0, 0, 0, 0, 0)), 8L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 421L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(3666), new TimeSpan(0, 0, 0, 0, 0)), false, 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 422L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(3943), new TimeSpan(0, 0, 0, 0, 0)), false, 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 423L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(4170), new TimeSpan(0, 0, 0, 0, 0)), 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 424L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(4449), new TimeSpan(0, 0, 0, 0, 0)), true, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 425L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(4671), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 426L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(4949), new TimeSpan(0, 0, 0, 0, 0)), 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 427L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(5171), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 428L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(5454), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 429L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(5724), new TimeSpan(0, 0, 0, 0, 0)), 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 430L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(5958), new TimeSpan(0, 0, 0, 0, 0)), false, 22L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 431L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(6251), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 432L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(6480), new TimeSpan(0, 0, 0, 0, 0)), false, 40L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 433L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(6757), new TimeSpan(0, 0, 0, 0, 0)), 35L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 434L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(6983), new TimeSpan(0, 0, 0, 0, 0)), false, 44L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 435L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(7261), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 436L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(7488), new TimeSpan(0, 0, 0, 0, 0)), 24L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 437L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(7765), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 438L,
                columns: new[] { "BirthDate", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(7990), new TimeSpan(0, 0, 0, 0, 0)), 31L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 439L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(8320), new TimeSpan(0, 0, 0, 0, 0)), true, 4L });

            migrationBuilder.UpdateData(
                table: "JackSlater",
                keyColumn: "Id",
                keyValue: 440L,
                columns: new[] { "BirthDate", "IsActive", "SinjulMSBHId" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 672, DateTimeKind.Unspecified).AddTicks(8545), new TimeSpan(0, 0, 0, 0, 0)), true, 31L });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 1L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 647, DateTimeKind.Unspecified).AddTicks(9779), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 648, DateTimeKind.Unspecified).AddTicks(8177), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 3L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 648, DateTimeKind.Unspecified).AddTicks(8715), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 648, DateTimeKind.Unspecified).AddTicks(9059), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 648, DateTimeKind.Unspecified).AddTicks(9279), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 6L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 648, DateTimeKind.Unspecified).AddTicks(9561), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 7L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 648, DateTimeKind.Unspecified).AddTicks(9773), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(40), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 9L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(246), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 10L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(511), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 11L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(720), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 12L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(1124), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 13L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(1357), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(1616), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(1837), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(2036), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(2304), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(2511), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 19L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(2941), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 20L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(3155), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(3419), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 22L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(3630), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 23L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(3892), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 24L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(4103), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(4361), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(4570), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 27L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(4868), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 28L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(5137), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(5344), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(5651), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 31L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(5860), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(6120), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(6328), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(6592), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(6802), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 36L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(7062), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(7271), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 38L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(7531), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(7744), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(7998), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 41L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(8212), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(8414), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(8678), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(8885), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 45L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(9148), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(9357), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(9723), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 649, DateTimeKind.Unspecified).AddTicks(9947), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(212), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(427), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(683), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 52L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(896), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 53L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(1097), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(1362), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 55L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(1565), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(1830), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(2036), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(2293), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(2500), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(2804), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 61L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(3020), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 62L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(3279), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(3487), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 64L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(3688), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(3978), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 66L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(4234), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(4447), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(4646), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 69L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(4910), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(5115), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(5379), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 72L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(5583), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 73L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(5837), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(6045), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(6353), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(6574), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 77L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(6829), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(7041), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 79L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(7241), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(7510), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 81L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(7712), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(7997), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 83L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(8207), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 84L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(8463), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(8672), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 86L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(8931), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 87L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(9140), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(9392), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(9604), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 650, DateTimeKind.Unspecified).AddTicks(9806), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(67), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 92L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(269), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 93L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(534), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(739), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(995), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 96L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(1204), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(1461), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 98L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(1670), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(1947), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(2160), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(2361), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 102L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(2660), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(2873), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(3189), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(3397), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(3660), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 107L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(3867), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 108L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(4123), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 109L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(4333), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 110L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(4589), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 111L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(4801), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 112L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(5053), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 113L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(5267), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 114L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(5468), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(5732), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 116L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(5936), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(6237), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(6532), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 119L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(6742), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(7006), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(7475), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 123L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(7684), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(7885), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(8153), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(8354), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(8616), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 128L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(8821), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 129L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(9080), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(9289), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 131L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(9553), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 651, DateTimeKind.Unspecified).AddTicks(9756), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(17), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(220), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 135L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(504), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 136L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(715), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 138L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(1182), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(1439), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 140L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(1648), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 141L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(1937), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(2167), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(2671), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 145L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(2883), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(3147), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(3355), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(3611), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(3818), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 150L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(4073), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(4281), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 152L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(4554), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(4770), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 154L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(4971), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 155L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(5240), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 156L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(5443), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 157L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(5707), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(5912), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(6171), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(6379), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 161L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(6641), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 162L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(6851), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 163L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(7107), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 164L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(7317), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 165L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(7518), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 166L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(7779), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 167L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(7981), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 168L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(8246), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(8450), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(8793), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 171L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(9015), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(9283), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 173L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(9494), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 174L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(9752), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 652, DateTimeKind.Unspecified).AddTicks(9964), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(165), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 177L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(431), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(632), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(897), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 180L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(1102), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(1362), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(1570), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(1828), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 184L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(2035), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 185L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(2291), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 186L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(2499), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(2812), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 188L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(3043), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(3245), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 190L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(3510), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(3716), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(3977), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(4188), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(4445), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 195L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(4654), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(4912), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(5119), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 198L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(5433), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 199L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(5662), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(5864), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(6138), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 202L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(6343), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(6608), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 204L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(6814), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(7097), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 206L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(7309), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 207L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(7566), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(7777), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(8032), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(8244), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 211L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(8445), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(8710), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 213L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(8915), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(9180), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(9388), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(9646), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 217L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 653, DateTimeKind.Unspecified).AddTicks(9854), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 218L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(115), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 219L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(323), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 220L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(583), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 221L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(792), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 222L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(996), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(1286), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 224L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(1490), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(1755), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 226L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(1960), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(2260), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 228L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(2477), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 229L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(2782), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(3391), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 231L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(3762), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 232L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(3993), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(4200), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 234L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(4476), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(4679), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(4953), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(5161), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(5429), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 239L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(5638), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 240L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(5936), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 241L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(6152), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 242L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(6412), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(6623), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 244L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(6877), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 245L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(7091), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 246L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(7294), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(7562), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(7768), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 249L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(8030), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(8236), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 251L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(8493), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 252L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(8702), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 253L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(8962), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 254L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(9172), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 255L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(9486), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 256L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(9718), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 257L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 654, DateTimeKind.Unspecified).AddTicks(9921), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 258L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(227), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 259L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(496), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 260L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(702), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 261L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(960), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 262L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(1166), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 263L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(1427), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 264L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(1638), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 265L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(1895), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 266L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(2106), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 267L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(2362), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 268L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(2574), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 269L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(2836), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 270L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(3110), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 271L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(3313), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 272L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(3577), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 273L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(3783), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 274L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(4103), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 275L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(4326), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 276L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(4589), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 277L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(4799), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 278L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(5054), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 279L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(5267), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 280L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(5469), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 281L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(5741), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 282L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(5944), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 283L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(6259), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 284L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(6472), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 285L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(6736), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 286L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(6944), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 287L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(7204), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 288L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(7414), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 289L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 290L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(7897), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 291L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(8097), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 292L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(8394), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 293L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(8598), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 294L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(8862), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 295L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(9067), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 296L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(9328), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 297L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(9535), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 298L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 655, DateTimeKind.Unspecified).AddTicks(9795), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 299L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(6), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 300L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(263), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 301L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(474), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 302L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(677), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 303L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(943), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 304L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(1147), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 305L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 306L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(1618), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 307L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(1875), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 308L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(2084), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 309L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(2365), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 310L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(2580), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 311L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(2960), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 312L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(3184), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 313L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(3439), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 314L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(3659), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 315L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(3860), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 316L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(4122), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 317L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(4327), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 318L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(4589), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 319L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(4796), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 320L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(5055), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 321L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(5265), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 322L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(5525), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 323L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(5737), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 324L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(5994), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 325L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(6207), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 326L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(6412), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 327L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(6705), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 328L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(6907), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 329L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(7171), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 330L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(7378), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 331L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(7638), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 332L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(7848), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 333L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(8108), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 334L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(8320), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 335L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(8584), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 336L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(8796), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 337L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(8998), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 338L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(9270), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 339L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(9475), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 340L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 656, DateTimeKind.Unspecified).AddTicks(9808), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 341L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(18), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 342L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(280), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 343L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(491), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 344L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(775), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 345L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(991), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 346L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(1249), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 347L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(1463), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 348L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(1665), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 349L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(1932), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 350L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(2137), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 351L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(2400), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 352L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(2639), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 353L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(2914), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 354L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(3124), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 355L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(3386), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 356L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(3593), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 357L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(3852), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 358L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(4063), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 359L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(4315), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 360L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(4529), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 361L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(4733), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 362L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(5023), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 363L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(5230), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 364L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(5494), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 365L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(5701), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 366L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(5961), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 367L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(6174), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 368L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(6480), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 369L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(6700), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 370L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(6959), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 371L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 372L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(7376), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 373L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(7643), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 374L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(7845), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 375L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(8110), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 376L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(8315), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 377L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(8574), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 378L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(8785), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 379L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(9068), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 380L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(9284), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 381L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(9540), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 382L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(9756), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 383L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 657, DateTimeKind.Unspecified).AddTicks(9956), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 384L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(222), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 385L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(425), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 386L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(690), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 387L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(895), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 388L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(1152), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 389L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(1364), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 390L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(1622), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 391L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(1832), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 392L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(2087), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 393L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(2297), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 394L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(2499), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 395L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(2803), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 396L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(3008), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 397L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(3350), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 398L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(3558), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 399L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(3820), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 400L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(4029), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 401L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(4292), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 402L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(4501), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 403L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(4761), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 404L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(4969), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 405L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(5225), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 406L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(5438), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 407L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(5637), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 408L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(5901), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 409L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(6105), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 410L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(6386), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 411L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(6676), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 412L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(6888), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 413L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(7150), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 414L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(7356), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 415L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(7613), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 416L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(7821), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 417L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(8072), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 418L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(8286), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 419L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(8489), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 420L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(8748), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 421L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(8953), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 422L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(9211), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 423L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(9417), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 424L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(9672), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 425L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 658, DateTimeKind.Unspecified).AddTicks(9879), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 426L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 659, DateTimeKind.Unspecified).AddTicks(134), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 427L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 659, DateTimeKind.Unspecified).AddTicks(340), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 428L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 659, DateTimeKind.Unspecified).AddTicks(609), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 429L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 659, DateTimeKind.Unspecified).AddTicks(822), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 430L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 659, DateTimeKind.Unspecified).AddTicks(1026), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 431L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 659, DateTimeKind.Unspecified).AddTicks(1292), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 432L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 659, DateTimeKind.Unspecified).AddTicks(1492), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 433L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 659, DateTimeKind.Unspecified).AddTicks(1751), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 434L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 659, DateTimeKind.Unspecified).AddTicks(1955), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 435L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 659, DateTimeKind.Unspecified).AddTicks(2259), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 436L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 659, DateTimeKind.Unspecified).AddTicks(2475), new TimeSpan(0, 0, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 437L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 659, DateTimeKind.Unspecified).AddTicks(2771), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 438L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 659, DateTimeKind.Unspecified).AddTicks(2985), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 439L,
                column: "BirthDate",
                value: new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 659, DateTimeKind.Unspecified).AddTicks(3238), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SinjulMSBH",
                keyColumn: "Id",
                keyValue: 440L,
                columns: new[] { "BirthDate", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 4, 17, 10, 8, 1, 659, DateTimeKind.Unspecified).AddTicks(3450), new TimeSpan(0, 0, 0, 0, 0)), false });

            migrationBuilder.AddForeignKey(
                name: "FK_JackSlater_SinjulMSBH_SinjulMSBHId",
                table: "JackSlater",
                column: "SinjulMSBHId",
                principalTable: "SinjulMSBH",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
