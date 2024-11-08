using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KursovaProject.Migrations
{
    public partial class Work : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "a9516054-afe8-4c10-a3c5-684b4977559f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb546cc6-440c-489d-bf8d-c186dc681874", "AQAAAAEAACcQAAAAEDHl92LFY9OJBo13nfIxuE1IHvkgFpRUQcL7TtJ2qr3bTqhgAjzvzap7am+55SnQIA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 7, 1, 17, 719, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 7, 1, 17, 718, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 7, 1, 17, 719, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a278b"),
                column: "DateAdded",
                value: new DateTime(2023, 6, 3, 7, 1, 17, 719, DateTimeKind.Utc).AddTicks(4134));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "77364172-160d-4516-8714-6806b16fa9c0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2874a896-cd95-4d77-8e76-075583b50100", "AQAAAAEAACcQAAAAEO8Cmf80i//uECk1I9z2lxwWo0yPFf1sxw15/XlgKS4hd9bK4akXvbS2LcPFH25mag==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2023, 6, 2, 9, 14, 50, 362, DateTimeKind.Utc).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2023, 6, 2, 9, 14, 50, 361, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2023, 6, 2, 9, 14, 50, 362, DateTimeKind.Utc).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a278b"),
                column: "DateAdded",
                value: new DateTime(2023, 6, 2, 9, 14, 50, 362, DateTimeKind.Utc).AddTicks(1634));
        }
    }
}
