using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class fixingGroupEntity8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factories_Groups_groupCode1",
                table: "Factories");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Customers_customerId",
                table: "FactoriesToCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Factories_factoryCode1",
                table: "FactoriesToCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Groups_groupCode1",
                table: "FactoriesToCustomer");

            migrationBuilder.RenameColumn(
                name: "groupName",
                table: "Groups",
                newName: "GroupName");

            migrationBuilder.RenameColumn(
                name: "groupCode",
                table: "Groups",
                newName: "GroupCode");

            migrationBuilder.RenameColumn(
                name: "groupCode1",
                table: "FactoriesToCustomer",
                newName: "GroupCode1");

            migrationBuilder.RenameColumn(
                name: "factoryCode1",
                table: "FactoriesToCustomer",
                newName: "FactoryCode1");

            migrationBuilder.RenameColumn(
                name: "factoryCode",
                table: "FactoriesToCustomer",
                newName: "FactoryCode");

            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "FactoriesToCustomer",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "groupCode",
                table: "FactoriesToCustomer",
                newName: "GroupCode");

            migrationBuilder.RenameIndex(
                name: "IX_FactoriesToCustomer_groupCode1",
                table: "FactoriesToCustomer",
                newName: "IX_FactoriesToCustomer_GroupCode1");

            migrationBuilder.RenameIndex(
                name: "IX_FactoriesToCustomer_factoryCode1",
                table: "FactoriesToCustomer",
                newName: "IX_FactoriesToCustomer_FactoryCode1");

            migrationBuilder.RenameIndex(
                name: "IX_FactoriesToCustomer_customerId",
                table: "FactoriesToCustomer",
                newName: "IX_FactoriesToCustomer_CustomerId");

            migrationBuilder.RenameColumn(
                name: "groupCode1",
                table: "Factories",
                newName: "GroupCode1");

            migrationBuilder.RenameColumn(
                name: "groupCode",
                table: "Factories",
                newName: "GroupCode");

            migrationBuilder.RenameColumn(
                name: "factoryName",
                table: "Factories",
                newName: "FactoryName");

            migrationBuilder.RenameColumn(
                name: "factoryCode",
                table: "Factories",
                newName: "FactoryCode");

            migrationBuilder.RenameIndex(
                name: "IX_Factories_groupCode1",
                table: "Factories",
                newName: "IX_Factories_GroupCode1");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Customers",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Customers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Customers",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "Customers",
                newName: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Factories_Groups_GroupCode1",
                table: "Factories",
                column: "GroupCode1",
                principalTable: "Groups",
                principalColumn: "GroupCode");

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Customers_CustomerId",
                table: "FactoriesToCustomer",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Factories_FactoryCode1",
                table: "FactoriesToCustomer",
                column: "FactoryCode1",
                principalTable: "Factories",
                principalColumn: "FactoryCode");

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Groups_GroupCode1",
                table: "FactoriesToCustomer",
                column: "GroupCode1",
                principalTable: "Groups",
                principalColumn: "GroupCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factories_Groups_GroupCode1",
                table: "Factories");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Customers_CustomerId",
                table: "FactoriesToCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Factories_FactoryCode1",
                table: "FactoriesToCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Groups_GroupCode1",
                table: "FactoriesToCustomer");

            migrationBuilder.RenameColumn(
                name: "GroupName",
                table: "Groups",
                newName: "groupName");

            migrationBuilder.RenameColumn(
                name: "GroupCode",
                table: "Groups",
                newName: "groupCode");

            migrationBuilder.RenameColumn(
                name: "GroupCode1",
                table: "FactoriesToCustomer",
                newName: "groupCode1");

            migrationBuilder.RenameColumn(
                name: "FactoryCode1",
                table: "FactoriesToCustomer",
                newName: "factoryCode1");

            migrationBuilder.RenameColumn(
                name: "FactoryCode",
                table: "FactoriesToCustomer",
                newName: "factoryCode");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "FactoriesToCustomer",
                newName: "customerId");

            migrationBuilder.RenameColumn(
                name: "GroupCode",
                table: "FactoriesToCustomer",
                newName: "groupCode");

            migrationBuilder.RenameIndex(
                name: "IX_FactoriesToCustomer_GroupCode1",
                table: "FactoriesToCustomer",
                newName: "IX_FactoriesToCustomer_groupCode1");

            migrationBuilder.RenameIndex(
                name: "IX_FactoriesToCustomer_FactoryCode1",
                table: "FactoriesToCustomer",
                newName: "IX_FactoriesToCustomer_factoryCode1");

            migrationBuilder.RenameIndex(
                name: "IX_FactoriesToCustomer_CustomerId",
                table: "FactoriesToCustomer",
                newName: "IX_FactoriesToCustomer_customerId");

            migrationBuilder.RenameColumn(
                name: "GroupCode1",
                table: "Factories",
                newName: "groupCode1");

            migrationBuilder.RenameColumn(
                name: "GroupCode",
                table: "Factories",
                newName: "groupCode");

            migrationBuilder.RenameColumn(
                name: "FactoryName",
                table: "Factories",
                newName: "factoryName");

            migrationBuilder.RenameColumn(
                name: "FactoryCode",
                table: "Factories",
                newName: "factoryCode");

            migrationBuilder.RenameIndex(
                name: "IX_Factories_GroupCode1",
                table: "Factories",
                newName: "IX_Factories_groupCode1");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Customers",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Customers",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customers",
                newName: "customerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Factories_Groups_groupCode1",
                table: "Factories",
                column: "groupCode1",
                principalTable: "Groups",
                principalColumn: "groupCode");

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Customers_customerId",
                table: "FactoriesToCustomer",
                column: "customerId",
                principalTable: "Customers",
                principalColumn: "customerId",
                onDelete: ReferentialAction.Cascade);

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
    }
}
