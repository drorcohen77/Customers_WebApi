using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class fixingFactoriesToCustomer1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FactoriesToCustomer_CustomerId",
                table: "FactoriesToCustomer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FactoriesToCustomer",
                table: "FactoriesToCustomer",
                columns: new[] { "CustomerId", "FactoryCode" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FactoriesToCustomer",
                table: "FactoriesToCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_FactoriesToCustomer_CustomerId",
                table: "FactoriesToCustomer",
                column: "CustomerId");
        }
    }
}
