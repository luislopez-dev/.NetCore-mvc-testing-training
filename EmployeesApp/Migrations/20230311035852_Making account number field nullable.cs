using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeesApp.Migrations
{
    public partial class Makingaccountnumberfieldnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("07e57250-5443-4bdc-be13-59239ada918e"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("195430d1-9227-451e-8378-65df427be580"));

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "AccountNumber", "Age", "Name" },
                values: new object[] { new Guid("0745c54d-b969-4a30-b581-4429fb5e78a1"), "123-3452134543-32", 30, "Mark" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "AccountNumber", "Age", "Name" },
                values: new object[] { new Guid("960df825-ffe5-4873-b828-c6efb80a7785"), "123-9384613085-55", 28, "Evelin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("0745c54d-b969-4a30-b581-4429fb5e78a1"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("960df825-ffe5-4873-b828-c6efb80a7785"));

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "AccountNumber", "Age", "Name" },
                values: new object[] { new Guid("07e57250-5443-4bdc-be13-59239ada918e"), "123-3452134543-32", 30, "Mark" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "AccountNumber", "Age", "Name" },
                values: new object[] { new Guid("195430d1-9227-451e-8378-65df427be580"), "123-9384613085-55", 28, "Evelin" });
        }
    }
}
