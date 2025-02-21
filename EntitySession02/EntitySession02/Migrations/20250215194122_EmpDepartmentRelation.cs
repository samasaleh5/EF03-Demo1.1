using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntitySession02.Migrations
{
    /// <inheritdoc />
    public partial class EmpDepartmentRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HamadaId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_HamadaId",
                table: "Employees",
                column: "HamadaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_HamadaId",
                table: "Employees",
                column: "HamadaId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_HamadaId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_HamadaId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "HamadaId",
                table: "Employees");
        }
    }
}
