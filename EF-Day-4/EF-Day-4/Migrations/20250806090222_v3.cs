using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Day_4.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "deptId",
                schema: "hr",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    deptId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    loaction = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.deptId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_deptId",
                schema: "hr",
                table: "Employees",
                column: "deptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_deptId",
                schema: "hr",
                table: "Employees",
                column: "deptId",
                principalTable: "Department",
                principalColumn: "deptId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_deptId",
                schema: "hr",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Employees_deptId",
                schema: "hr",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "deptId",
                schema: "hr",
                table: "Employees");
        }
    }
}
