using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class fixingGroupEntity4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Factories_factoryCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Groups_groupCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropIndex(
                name: "IX_FactoriesToCustomer_factoryCode",
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
                name: "factoriesfactoryCode",
                table: "FactoriesToCustomer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "groupsgroupCode",
                table: "FactoriesToCustomer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FactoriesToCustomer_factoriesfactoryCode",
                table: "FactoriesToCustomer",
                column: "factoriesfactoryCode");

            migrationBuilder.CreateIndex(
                name: "IX_FactoriesToCustomer_groupsgroupCode",
                table: "FactoriesToCustomer",
                column: "groupsgroupCode");

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Factories_factoriesfactoryCode",
                table: "FactoriesToCustomer",
                column: "factoriesfactoryCode",
                principalTable: "Factories",
                principalColumn: "factoryCode");

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Groups_groupsgroupCode",
                table: "FactoriesToCustomer",
                column: "groupsgroupCode",
                principalTable: "Groups",
                principalColumn: "groupCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Factories_factoriesfactoryCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Groups_groupsgroupCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropIndex(
                name: "IX_FactoriesToCustomer_factoriesfactoryCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropIndex(
                name: "IX_FactoriesToCustomer_groupsgroupCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropColumn(
                name: "factoriesfactoryCode",
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

            migrationBuilder.CreateIndex(
                name: "IX_FactoriesToCustomer_factoryCode",
                table: "FactoriesToCustomer",
                column: "factoryCode");

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Factories_factoryCode",
                table: "FactoriesToCustomer",
                column: "factoryCode",
                principalTable: "Factories",
                principalColumn: "factoryCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Groups_groupCode",
                table: "FactoriesToCustomer",
                column: "groupCode",
                principalTable: "Groups",
                principalColumn: "groupCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
