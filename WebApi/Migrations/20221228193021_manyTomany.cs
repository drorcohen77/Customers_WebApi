using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class manyTomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomers_Customers_CustomerId",
                table: "FactoriesToCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomers_Factories_FactoryCode",
                table: "FactoriesToCustomers");

            migrationBuilder.RenameColumn(
                name: "FactoryCode",
                table: "FactoriesToCustomers",
                newName: "factoryCode");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "FactoriesToCustomers",
                newName: "customerId");

            migrationBuilder.RenameColumn(
                name: "GroupCode",
                table: "FactoriesToCustomers",
                newName: "groupCode");

            migrationBuilder.RenameIndex(
                name: "IX_FactoriesToCustomers_FactoryCode",
                table: "FactoriesToCustomers",
                newName: "IX_FactoriesToCustomers_factoryCode");

            migrationBuilder.RenameIndex(
                name: "IX_FactoriesToCustomers_CustomerId",
                table: "FactoriesToCustomers",
                newName: "IX_FactoriesToCustomers_customerId");

            migrationBuilder.RenameColumn(
                name: "actoryCode",
                table: "Factories",
                newName: "factoryCode");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomers_Customers_customerId",
                table: "FactoriesToCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomers_Factories_factoryCode",
                table: "FactoriesToCustomers");

            migrationBuilder.RenameColumn(
                name: "factoryCode",
                table: "FactoriesToCustomers",
                newName: "FactoryCode");

            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "FactoriesToCustomers",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "groupCode",
                table: "FactoriesToCustomers",
                newName: "GroupCode");

            migrationBuilder.RenameIndex(
                name: "IX_FactoriesToCustomers_factoryCode",
                table: "FactoriesToCustomers",
                newName: "IX_FactoriesToCustomers_FactoryCode");

            migrationBuilder.RenameIndex(
                name: "IX_FactoriesToCustomers_customerId",
                table: "FactoriesToCustomers",
                newName: "IX_FactoriesToCustomers_CustomerId");

            migrationBuilder.RenameColumn(
                name: "factoryCode",
                table: "Factories",
                newName: "actoryCode");

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomers_Customers_CustomerId",
                table: "FactoriesToCustomers",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "customerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomers_Factories_FactoryCode",
                table: "FactoriesToCustomers",
                column: "FactoryCode",
                principalTable: "Factories",
                principalColumn: "actoryCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
