using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Factories_FactoryCode1",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_FactoryCode1",
                table: "Groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FactoriesToCustomers",
                table: "FactoriesToCustomers");

            migrationBuilder.DropColumn(
                name: "FactoryCode",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "FactoryCode1",
                table: "Groups");

            migrationBuilder.AlterColumn<int>(
                name: "GroupCode",
                table: "FactoriesToCustomers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "GroupCode1",
                table: "Factories",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FactoriesToCustomers",
                table: "FactoriesToCustomers",
                column: "GroupCode");

            migrationBuilder.CreateIndex(
                name: "IX_FactoriesToCustomers_FactoryCode",
                table: "FactoriesToCustomers",
                column: "FactoryCode");

            migrationBuilder.CreateIndex(
                name: "IX_Factories_GroupCode1",
                table: "Factories",
                column: "GroupCode1");

            migrationBuilder.AddForeignKey(
                name: "FK_Factories_Groups_GroupCode1",
                table: "Factories",
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_FactoriesToCustomers",
                table: "FactoriesToCustomers");

            migrationBuilder.DropIndex(
                name: "IX_FactoriesToCustomers_FactoryCode",
                table: "FactoriesToCustomers");

            migrationBuilder.DropIndex(
                name: "IX_Factories_GroupCode1",
                table: "Factories");

            migrationBuilder.DropColumn(
                name: "GroupCode1",
                table: "Factories");

            migrationBuilder.AddColumn<int>(
                name: "FactoryCode",
                table: "Groups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FactoryCode1",
                table: "Groups",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GroupCode",
                table: "FactoriesToCustomers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FactoriesToCustomers",
                table: "FactoriesToCustomers",
                column: "FactoryCode");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_FactoryCode1",
                table: "Groups",
                column: "FactoryCode1");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Factories_FactoryCode1",
                table: "Groups",
                column: "FactoryCode1",
                principalTable: "Factories",
                principalColumn: "FactoryCode");
        }
    }
}
