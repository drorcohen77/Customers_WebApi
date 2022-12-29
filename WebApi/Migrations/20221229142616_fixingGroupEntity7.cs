using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class fixingGroupEntity7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Factories_factoriesfactoryCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Groups_groupsgroupCode",
                table: "FactoriesToCustomer");

            migrationBuilder.RenameColumn(
                name: "groupsgroupCode",
                table: "FactoriesToCustomer",
                newName: "groupCode1");

            migrationBuilder.RenameColumn(
                name: "factoriesfactoryCode",
                table: "FactoriesToCustomer",
                newName: "factoryCode1");

            migrationBuilder.RenameIndex(
                name: "IX_FactoriesToCustomer_groupsgroupCode",
                table: "FactoriesToCustomer",
                newName: "IX_FactoriesToCustomer_groupCode1");

            migrationBuilder.RenameIndex(
                name: "IX_FactoriesToCustomer_factoriesfactoryCode",
                table: "FactoriesToCustomer",
                newName: "IX_FactoriesToCustomer_factoryCode1");

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Factories_factoryCode1",
                table: "FactoriesToCustomer",
                column: "factoryCode1",
                principalTable: "Factories",
                principalColumn: "factoryCode");

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Groups_groupCode1",
                table: "FactoriesToCustomer",
                column: "groupCode1",
                principalTable: "Groups",
                principalColumn: "groupCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Factories_factoryCode1",
                table: "FactoriesToCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Groups_groupCode1",
                table: "FactoriesToCustomer");

            migrationBuilder.RenameColumn(
                name: "groupCode1",
                table: "FactoriesToCustomer",
                newName: "groupsgroupCode");

            migrationBuilder.RenameColumn(
                name: "factoryCode1",
                table: "FactoriesToCustomer",
                newName: "factoriesfactoryCode");

            migrationBuilder.RenameIndex(
                name: "IX_FactoriesToCustomer_groupCode1",
                table: "FactoriesToCustomer",
                newName: "IX_FactoriesToCustomer_groupsgroupCode");

            migrationBuilder.RenameIndex(
                name: "IX_FactoriesToCustomer_factoryCode1",
                table: "FactoriesToCustomer",
                newName: "IX_FactoriesToCustomer_factoriesfactoryCode");

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
    }
}
