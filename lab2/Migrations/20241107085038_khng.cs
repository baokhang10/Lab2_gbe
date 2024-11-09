﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace lab2.Migrations
{
    /// <inheritdoc />
    public partial class khng : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Gamelevels",
                columns: new[] { "LevelId", "description", "title" },
                values: new object[,]
                {
                    { 1, null, "Cấp độ 1" },
                    { 2, null, "Cấp độ 2" },
                    { 3, null, "Cấp độ 3" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Answer", "ContentQuestion", "Option1", "Option2", "Option3", "Option4", "levelId" },
                values: new object[,]
                {
                    { 1, "Đáp án 1", "Câu hỏi 1", "Đáp án 1", "Đáp án 2", "Đáp án 3", "Đáp án 4", 1 },
                    { 2, "Đáp án 2", "Câu hỏi 2", "Đáp án 1", "Đáp án 2", "Đáp án 3", "Đáp án 4", 2 }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "Name" },
                values: new object[,]
                {
                    { 1, "Đồng bằng sông hồng" },
                    { 2, "Đồng bằng sông cuu long" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gamelevels",
                keyColumn: "LevelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gamelevels",
                keyColumn: "LevelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gamelevels",
                keyColumn: "LevelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "RegionId",
                keyValue: 2);
        }
    }
}
