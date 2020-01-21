using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankService.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankMasters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    LastTransactionDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankMasters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankLedger",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BatchId = table.Column<int>(nullable: false),
                    BankMasterId = table.Column<int>(nullable: false),
                    TransactionTypeId = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankLedger", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankLedger_BankMasters_BankMasterId",
                        column: x => x.BankMasterId,
                        principalTable: "BankMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankLedger_TransactionTypes_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TransactionTypes",
                columns: new[] { "Id", "TypeName" },
                values: new object[] { 1, "Debit" });

            migrationBuilder.InsertData(
                table: "TransactionTypes",
                columns: new[] { "Id", "TypeName" },
                values: new object[] { 2, "Credit" });

            migrationBuilder.CreateIndex(
                name: "IX_BankLedger_BankMasterId",
                table: "BankLedger",
                column: "BankMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_BankLedger_TransactionTypeId",
                table: "BankLedger",
                column: "TransactionTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankLedger");

            migrationBuilder.DropTable(
                name: "BankMasters");

            migrationBuilder.DropTable(
                name: "TransactionTypes");
        }
    }
}
