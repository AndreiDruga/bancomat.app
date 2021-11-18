using Microsoft.EntityFrameworkCore.Migrations;

namespace bancomat.app.Data.Migrations
{
    public partial class AddChangeAmountTo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TransferTo",
                table: "AmountTo",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransferTo",
                table: "AmountTo");
        }
    }
}
