using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class fixingFactoriesToCustomer2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factories_Groups_GroupCode1",
                table: "Factories");

            migrationBuilder.DropIndex(
                name: "IX_Factories_GroupCode1",
                table: "Factories");

            migrationBuilder.DropColumn(
                name: "GroupCode1",
                table: "Factories");

            migrationBuilder.CreateIndex(
                name: "IX_Factories_GroupCode",
                table: "Factories",
                column: "GroupCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Factories_Groups_GroupCode",
                table: "Factories",
                column: "GroupCode",
                principalTable: "Groups",
                principalColumn: "GroupCode",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factories_Groups_GroupCode",
                table: "Factories");

            migrationBuilder.DropIndex(
                name: "IX_Factories_GroupCode",
                table: "Factories");

            migrationBuilder.AddColumn<int>(
                name: "GroupCode1",
                table: "Factories",
                type: "int",
                nullable: true);

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
    }
}
