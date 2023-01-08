using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class fixingFactoriesToCustomer3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Groups_GroupCode",
                table: "FactoriesToCustomer");

            migrationBuilder.AlterColumn<int>(
                name: "GroupCode",
                table: "FactoriesToCustomer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Groups_GroupCode",
                table: "FactoriesToCustomer",
                column: "GroupCode",
                principalTable: "Groups",
                principalColumn: "GroupCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Groups_GroupCode",
                table: "FactoriesToCustomer");

            migrationBuilder.AlterColumn<int>(
                name: "GroupCode",
                table: "FactoriesToCustomer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Groups_GroupCode",
                table: "FactoriesToCustomer",
                column: "GroupCode",
                principalTable: "Groups",
                principalColumn: "GroupCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
