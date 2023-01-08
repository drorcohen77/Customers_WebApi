using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class fixingFactoriesToCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Factories_FactoryCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Groups_GroupCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FactoriesToCustomer",
                table: "FactoriesToCustomer");

            migrationBuilder.DropIndex(
                name: "IX_FactoriesToCustomer_FactoryCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropIndex(
                name: "IX_FactoriesToCustomer_GroupCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropColumn(
                name: "FactoryCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropColumn(
                name: "GroupCode",
                table: "FactoriesToCustomer");

            migrationBuilder.AlterColumn<int>(
                name: "GroupCode",
                table: "FactoriesToCustomer",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_FactoriesToCustomer_FactoryCode",
                table: "FactoriesToCustomer",
                column: "FactoryCode");

            migrationBuilder.CreateIndex(
                name: "IX_FactoriesToCustomer_GroupCode",
                table: "FactoriesToCustomer",
                column: "GroupCode");

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Factories_FactoryCode",
                table: "FactoriesToCustomer",
                column: "FactoryCode",
                principalTable: "Factories",
                principalColumn: "FactoryCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Groups_GroupCode",
                table: "FactoriesToCustomer",
                column: "GroupCode",
                principalTable: "Groups",
                principalColumn: "GroupCode",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Factories_FactoryCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_FactoriesToCustomer_Groups_GroupCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropIndex(
                name: "IX_FactoriesToCustomer_FactoryCode",
                table: "FactoriesToCustomer");

            migrationBuilder.DropIndex(
                name: "IX_FactoriesToCustomer_GroupCode",
                table: "FactoriesToCustomer");

            migrationBuilder.AlterColumn<int>(
                name: "GroupCode",
                table: "FactoriesToCustomer",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "FactoryCode",
                table: "FactoriesToCustomer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupCode",
                table: "FactoriesToCustomer",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FactoriesToCustomer",
                table: "FactoriesToCustomer",
                column: "GroupCode");

            migrationBuilder.CreateIndex(
                name: "IX_FactoriesToCustomer_FactoryCode1",
                table: "FactoriesToCustomer",
                column: "FactoryCode1");

            migrationBuilder.CreateIndex(
                name: "IX_FactoriesToCustomer_GroupCode",
                table: "FactoriesToCustomer",
                column: "GroupCode");

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Factories_FactoryCode",
                table: "FactoriesToCustomer",
                column: "FactoryCode1",
                principalTable: "Factories",
                principalColumn: "FactoryCode");

            migrationBuilder.AddForeignKey(
                name: "FK_FactoriesToCustomer_Groups_GroupCode",
                table: "FactoriesToCustomer",
                column: "GroupCode",
                principalTable: "Groups",
                principalColumn: "GroupCode");
        }
    }
}
