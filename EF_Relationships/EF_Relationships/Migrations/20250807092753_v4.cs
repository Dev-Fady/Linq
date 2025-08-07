using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_Relationships.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "أجهزة إلكترونية وتقنية متطورة", "إلكترونيات" },
                    { 2, "كتب علمية وثقافية منوعة", "كتب" },
                    { 3, "ملابس عصرية للرجال والنساء", "ملابس" },
                    { 4, "معدات وأدوات رياضية", "رياضة" },
                    { 5, "أدوات منزلية ومعدات حديقة", "منزل وحديقة" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Title" },
                values: new object[,]
                {
                    { 1, 3, "البرمجة بـ C#" },
                    { 2, 4, "قواعد البيانات" },
                    { 3, 3, "تطوير الويب" },
                    { 4, 4, "هندسة البرمجيات" },
                    { 5, 3, "الذكاء الاصطناعي" },
                    { 6, 3, "أمن المعلومات" },
                    { 7, 4, "الشبكات والاتصالات" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "ali.mohamed@student.edu", "علي محمد" },
                    { 2, "nour.ahmed@student.edu", "نور أحمد" },
                    { 3, "hosam.khaled@student.edu", "حسام خالد" },
                    { 4, "reem.saad@student.edu", "ريم سعد" },
                    { 5, "youssef.abdullah@student.edu", "يوسف عبدالله" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "ahmed@example.com", "أحمد محمد" },
                    { 2, "fatima@example.com", "فاطمة علي" },
                    { 3, "mohamed@example.com", "محمد حسن" },
                    { 4, "sara@example.com", "سارة أحمد" },
                    { 5, "omar@example.com", "عمر خالد" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "لابتوب Dell XPS", 25000m },
                    { 2, 1, "هاتف iPhone 15", 18000m },
                    { 3, 1, "تابلت Samsung Galaxy", 8000m },
                    { 4, 1, "سماعات Sony WH-1000XM4", 3500m },
                    { 5, 2, "Clean Code", 150m },
                    { 6, 2, "Design Patterns", 200m },
                    { 7, 2, "The Pragmatic Programmer", 180m },
                    { 8, 3, "قميص قطني أزرق", 120m },
                    { 9, 3, "جينز كلاسيكي", 300m },
                    { 10, 3, "حذاء رياضي Nike", 800m },
                    { 11, 4, "دراجة هوائية", 2500m },
                    { 12, 4, "أوزان حديد", 500m },
                    { 13, 5, "مكنسة كهربائية", 1200m },
                    { 14, 5, "أدوات حديقة", 350m }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId", "EnrollmentDate", "Grade", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 85.5m, "Completed" },
                    { 2, 1, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 92.0m, "Completed" },
                    { 3, 1, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Active" },
                    { 4, 1, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Active" },
                    { 1, 2, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 78.5m, "Completed" },
                    { 5, 2, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 88.0m, "Completed" },
                    { 6, 2, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Active" },
                    { 2, 3, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 90.5m, "Completed" },
                    { 3, 3, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 87.0m, "Completed" },
                    { 7, 3, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Active" },
                    { 4, 4, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 95.0m, "Completed" },
                    { 5, 4, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Active" },
                    { 6, 5, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 82.5m, "Completed" },
                    { 7, 5, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Active" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "UserId", "Bio", "DateOfBirth", "proFilePicture" },
                values: new object[,]
                {
                    { 1, "مطور برمجيات متخصص في .NET", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahmed_profile.jpg" },
                    { 2, "مصممة UI/UX مبدعة", new DateTime(1992, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatima_profile.jpg" },
                    { 3, "محلل بيانات وخبير في Machine Learning", new DateTime(1988, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "mohamed_profile.jpg" },
                    { 4, "مديرة مشاريع تقنية", new DateTime(1991, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "sara_profile.jpg" },
                    { 5, "مهندس DevOps ومختص في Cloud Computing", new DateTime(1989, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "omar_profile.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
