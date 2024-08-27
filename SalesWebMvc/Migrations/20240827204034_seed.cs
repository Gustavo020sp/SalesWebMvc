using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalesWebMvc.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Computers" },
                    { 5, "Games" }
                });

            migrationBuilder.InsertData(
                table: "Seller",
                columns: new[] { "Id", "BaseSalary", "BirthDate", "DepartmentId", "Email", "Name" },
                values: new object[,]
                {
                    { 1, 2500.0, new DateTime(1995, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "maria@gmail.com", "Maria Betania" },
                    { 2, 3509.52, new DateTime(1997, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "angelafreeman@hotmail.com", "Noah Taylor" },
                    { 4, 2286.02, new DateTime(1993, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "maryhill@sims.com", "Joseph Gallegos" },
                    { 5, 3134.9099999999999, new DateTime(2003, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "qlara@costa.com", "Randall Chapman" },
                    { 6, 2327.9499999999998, new DateTime(1995, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "juan97@yahoo.com", "Jason Ortiz" },
                    { 7, 2142.6700000000001, new DateTime(1989, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "sampsondarin@adams-armstrong.net", "Carl Roberts" },
                    { 8, 2459.52, new DateTime(1973, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "paulvaldez@maxwell.org", "Austin Smith" },
                    { 12, 2520.3800000000001, new DateTime(1993, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "kelseycastaneda@gmail.com", "Sara Burke" },
                    { 14, 3184.5, new DateTime(1999, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "hfrank@perez-smith.com", "Michael Freeman" },
                    { 15, 4813.7399999999998, new DateTime(1985, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "mitchell21@yahoo.com", "Alicia Martinez" },
                    { 17, 4064.5500000000002, new DateTime(1996, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "lydia44@duncan-bush.info", "Brandon Young" },
                    { 18, 2538.6700000000001, new DateTime(1994, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "ianderson@hotmail.com", "Nicholas Reed" },
                    { 20, 3923.1900000000001, new DateTime(1984, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "dhudson@hotmail.com", "Amanda Bell" },
                    { 21, 4293.6300000000001, new DateTime(1978, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "nmorris@gmail.com", "David Johnson" },
                    { 23, 4185.0, new DateTime(1989, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "kenneth66@hotmail.com", "Amanda Murphy" },
                    { 24, 2975.6100000000001, new DateTime(1979, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "kgriffin@hotmail.com", "Robyn Hobbs" },
                    { 27, 3662.0700000000002, new DateTime(1979, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "rreed@carroll.com", "Amber Gonzalez" }
                });

            migrationBuilder.InsertData(
                table: "SalesRecord",
                columns: new[] { "Id", "Amount", "Date", "SellerId", "Status" },
                values: new object[,]
                {
                    { 1, 100.90000000000001, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 3, 882.50999999999999, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 },
                    { 4, 575.08000000000004, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 5, 486.29000000000002, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 6, 412.94, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 9, 103.36, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 1 },
                    { 11, 538.44000000000005, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 2 }
                });

            migrationBuilder.InsertData(
                table: "Seller",
                columns: new[] { "Id", "BaseSalary", "BirthDate", "DepartmentId", "Email", "Name" },
                values: new object[,]
                {
                    { 3, 3468.9400000000001, new DateTime(1969, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "williamscarl@yahoo.com", "Michelle Fischer" },
                    { 9, 4726.29, new DateTime(1979, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "melissa87@mooney.com", "Thomas Rodriguez" },
                    { 10, 2367.1700000000001, new DateTime(1997, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "shawn91@weaver.com", "Kelly Salas" },
                    { 11, 3926.3600000000001, new DateTime(1983, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "osmith@scott-lucas.com", "James Garcia" },
                    { 13, 2743.77, new DateTime(1961, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "brett72@blake.com", "Carol Miller" },
                    { 16, 3666.5500000000002, new DateTime(1984, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "nicholasharmon@cruz-evans.biz", "Sandra Anderson" },
                    { 19, 2408.5599999999999, new DateTime(1998, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "robert49@yahoo.com", "John Cook" },
                    { 22, 2558.6700000000001, new DateTime(1982, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "jacobpatrick@moses.com", "Paul Evans" },
                    { 25, 4133.3299999999999, new DateTime(1986, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "kevinmcfarland@rice.org", "Ann Berry" },
                    { 26, 3575.8899999999999, new DateTime(1996, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "valerie71@johnston-mitchell.com", "Karen Clark" }
                });

            migrationBuilder.InsertData(
                table: "SalesRecord",
                columns: new[] { "Id", "Amount", "Date", "SellerId", "Status" },
                values: new object[,]
                {
                    { 2, 947.62, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 7, 919.79999999999995, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 1 },
                    { 8, 852.85000000000002, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1 },
                    { 10, 536.45000000000005, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
