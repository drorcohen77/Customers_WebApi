using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class updateculomns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factories_Groups_GroupCode1",
                table: "Factories");

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
                newName: "actoryCode");

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
                name: "CustomerID",
                table: "Customers",
                newName: "customerId");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Customers",
                newName: "address");

            migrationBuilder.AddForeignKey(
                name: "FK_Factories_Groups_groupCode1",
                table: "Factories",
                column: "groupCode1",
                principalTable: "Groups",
                principalColumn: "groupCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factories_Groups_groupCode1",
                table: "Factories");

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
                name: "actoryCode",
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
                name: "customerId",
                table: "Customers",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Customers",
                newName: "Adress");

            migrationBuilder.AddForeignKey(
                name: "FK_Factories_Groups_GroupCode1",
                table: "Factories",
                column: "GroupCode1",
                principalTable: "Groups",
                principalColumn: "GroupCode");
        }
    }
}
