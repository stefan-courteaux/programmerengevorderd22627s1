using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetsEfCoreMigrations.Migrations
{
    /// <inheritdoc />
    public partial class UniqueEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "Pets",
                table: "Notes",
                type: "character varying(20000)",
                maxLength: 20000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(5000)",
                oldMaxLength: 5000);

            migrationBuilder.CreateIndex(
                name: "IX_Owners_Email",
                schema: "Pets",
                table: "Owners",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Owners_Email",
                schema: "Pets",
                table: "Owners");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "Pets",
                table: "Notes",
                type: "character varying(5000)",
                maxLength: 5000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20000)",
                oldMaxLength: 20000);
        }
    }
}
