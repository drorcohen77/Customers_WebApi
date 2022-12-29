using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class fixingGroupEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomers_Customers_customerId",
                table: "FactoriesToCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomers_Factories_factoryCode",
                table: "FactoriesToCustomers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FactoriesToCustomers",
                table: "FactoriesToCustomers");

            migrationBuilder.RenameTable(
                name: "FactoriesToCustomers",
                newName: "FactoriesToCustomer");

            migrationBuilder.RenameIndex(
                name: "IX_FactoriesToCustomers_factoryCode",
                table: "FactoriesToCustomer",
                newName: "IX_FactoriesToCustomer_factoryCode");

            migrationBuilder.RenameIndex(
                name: "IX_FactoriesToCustomers_customerId",
                table: "FactoriesToCustomer",
                newName: "IX_FactoriesToCustomer_customerId");

            migrationBuilder.AddColumn<int>(
                name: "groupsgroupCode",
                table: "FactoriesToCustomer",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FactoriesToCustomer",
                table: "FactoriesToCustomer",
                column: "groupCode");

            migrationBuilder.CreateIndex(
                name: "IX_FactoriesToCustomer_groupsgroupCode",
                table: "FactoriesToCustomer",
                column: "groupsgroupCode");

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Customers_customerId",
                table: "FactoriesToCustomer",
                column: "customerId",
                principalTable: "Customers",
                principalColumn: "customerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Factories_factoryCode",
                table: "FactoriesToCustomer",
                column: "factoryCode",
                principalTable: "Factories",
                principalColumn: "factoryCode",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_FactoriesToCustomer_Customers_customerId",
                table: "FactoriesToCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Factories_factoryCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Groups_groupsgroupCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FactoriesToCustomer",
                table: "FactoriesToCustomer");

            migrationBuilder.DropIndex(
                name: "IX_FactoriesToCustomer_groupsgroupCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropColumn(
                name: "groupsgroupCode",
                table: "FactoriesToCustomer");

            migrationBuilder.RenameTable(
                name: "FactoriesToCustomer",
                newName: "FactoriesToCustomers");

            migrationBuilder.RenameIndex(
                name: "IX_FactoriesToCustomer_factoryCode",
                table: "FactoriesToCustomers",
                newName: "IX_FactoriesToCustomers_factoryCode");

            migrationBuilder.RenameIndex(
                name: "IX_FactoriesToCustomer_customerId",
                table: "FactoriesToCustomers",
                newName: "IX_FactoriesToCustomers_customerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FactoriesToCustomers",
                table: "FactoriesToCustomers",
                column: "groupCode");

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomers_Customers_customerId",
                table: "FactoriesToCustomers",
                column: "customerId",
                principalTable: "Customers",
                principalColumn: "customerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomers_Factories_factoryCode",
                table: "FactoriesToCustomers",
                column: "factoryCode",
                principalTable: "Factories",
                principalColumn: "factoryCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
