using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CbsStudentsDotnet.Migrations
{
    public partial class SeededDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "AmountOfComments", "AmountOfLikes", "Created", "Media", "Status", "Text", "Title" },
                values: new object[] { 1, 7, 5, new DateTime(2022, 3, 28, 9, 28, 14, 554, DateTimeKind.Local).AddTicks(290), "Image", 0, "This is the description of my first post", "This is my first post" });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "AmountOfComments", "AmountOfLikes", "Created", "Media", "Status", "Text", "Title" },
                values: new object[] { 2, 12, 10, new DateTime(2022, 3, 28, 9, 28, 14, 554, DateTimeKind.Local).AddTicks(1110), "Video", 0, "This is the description of my second post", "This is my second post" });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "AmountOfComments", "AmountOfLikes", "Created", "Media", "Status", "Text", "Title" },
                values: new object[] { 3, 1, 3, new DateTime(2022, 3, 28, 9, 28, 14, 554, DateTimeKind.Local).AddTicks(1130), "Image", 0, "This is the description of my third post", "This is my third post" });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "PostId", "Text", "TimeStamp" },
                values: new object[] { 1, 1, "This is a comment on post 1", new DateTime(2022, 3, 28, 9, 28, 14, 554, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "PostId", "Text", "TimeStamp" },
                values: new object[] { 2, 1, "This is also a comment on post 1", new DateTime(2022, 3, 28, 9, 28, 14, 554, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "PostId", "Text", "TimeStamp" },
                values: new object[] { 3, 2, "This is a comment on post 2", new DateTime(2022, 3, 28, 9, 28, 14, 554, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "PostId", "Text", "TimeStamp" },
                values: new object[] { 4, 2, "This is also a comment on post 2", new DateTime(2022, 3, 28, 9, 28, 14, 554, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "PostId", "Text", "TimeStamp" },
                values: new object[] { 5, 3, "This is a comment on post 3", new DateTime(2022, 3, 28, 9, 28, 14, 554, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "PostId", "Text", "TimeStamp" },
                values: new object[] { 6, 3, "This is also a comment on post 3", new DateTime(2022, 3, 28, 9, 28, 14, 554, DateTimeKind.Local).AddTicks(3350) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
