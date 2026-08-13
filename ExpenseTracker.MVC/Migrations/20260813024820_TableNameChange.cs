using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.MVC.Migrations
{
    /// <inheritdoc />
    public partial class TableNameChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                 name: "Expence",
                 newName: "Expense");

            migrationBuilder.RenameIndex(
                name: "IX_Category_ExpenceId",
                newName: "IX_Category_ExpenseId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_ExpenceId",
                newName: "IX_PaymentMethod_ExpenseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
