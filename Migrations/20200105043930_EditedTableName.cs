using Microsoft.EntityFrameworkCore.Migrations;

namespace BankService.API.Migrations
{
    public partial class EditedTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankLedger_BankMasters_BankMasterId",
                table: "BankLedger");

            migrationBuilder.DropForeignKey(
                name: "FK_BankLedger_TransactionTypes_TransactionTypeId",
                table: "BankLedger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BankLedger",
                table: "BankLedger");

            migrationBuilder.RenameTable(
                name: "BankLedger",
                newName: "BankLedgers");

            migrationBuilder.RenameIndex(
                name: "IX_BankLedger_TransactionTypeId",
                table: "BankLedgers",
                newName: "IX_BankLedgers_TransactionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_BankLedger_BankMasterId",
                table: "BankLedgers",
                newName: "IX_BankLedgers_BankMasterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BankLedgers",
                table: "BankLedgers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BankLedgers_BankMasters_BankMasterId",
                table: "BankLedgers",
                column: "BankMasterId",
                principalTable: "BankMasters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BankLedgers_TransactionTypes_TransactionTypeId",
                table: "BankLedgers",
                column: "TransactionTypeId",
                principalTable: "TransactionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankLedgers_BankMasters_BankMasterId",
                table: "BankLedgers");

            migrationBuilder.DropForeignKey(
                name: "FK_BankLedgers_TransactionTypes_TransactionTypeId",
                table: "BankLedgers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BankLedgers",
                table: "BankLedgers");

            migrationBuilder.RenameTable(
                name: "BankLedgers",
                newName: "BankLedger");

            migrationBuilder.RenameIndex(
                name: "IX_BankLedgers_TransactionTypeId",
                table: "BankLedger",
                newName: "IX_BankLedger_TransactionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_BankLedgers_BankMasterId",
                table: "BankLedger",
                newName: "IX_BankLedger_BankMasterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BankLedger",
                table: "BankLedger",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BankLedger_BankMasters_BankMasterId",
                table: "BankLedger",
                column: "BankMasterId",
                principalTable: "BankMasters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BankLedger_TransactionTypes_TransactionTypeId",
                table: "BankLedger",
                column: "TransactionTypeId",
                principalTable: "TransactionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
