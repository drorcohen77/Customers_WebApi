using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class fixingGroupEntity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Groups_groupsgroupCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropIndex(
                name: "IX_FactoriesToCustomer_groupsgroupCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropColumn(
                name: "groupsgroupCode",
                table: "FactoriesToCustomer");

            migrationBuilder.AlterColumn<int>(
                name: "groupCode",
                table: "FactoriesToCustomer",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Groups_groupCode",
                table: "FactoriesToCustomer",
                column: "groupCode",
                principalTable: "Groups",
                principalColumn: "groupCode",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Groups_groupCode",
                table: "FactoriesToCustomer");

            migrationBuilder.AlterColumn<int>(
                name: "groupCode",
                table: "FactoriesToCustomer",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "groupsgroupCode",
                table: "FactoriesToCustomer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FactoriesToCustomer_groupsgroupCode",
                table: "FactoriesToCustomer",
                column: "groupsgroupCode");

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Groups_groupsgroupCode",
                table: "FactoriesToCustomer",
                column: "groupsgroupCode",
                principalTable: "Groups",
                principalColumn: "groupCode");
        }
    }
}
