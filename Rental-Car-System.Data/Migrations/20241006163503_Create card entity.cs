using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rental_Car_System.Data.Migrations
{
	/// <inheritdoc />
	public partial class Createcardentity : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			// Create the BankCards table
			migrationBuilder.CreateTable(
				name: "BankCards",
				columns: table => new
				{
					Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
					CardNumber = table.Column<string>(type: "longtext", nullable: false)
						.Annotation("MySql:CharSet", "utf8mb4"),
					CVV = table.Column<string>(type: "longtext", nullable: false)
						.Annotation("MySql:CharSet", "utf8mb4"),
					ExpirationDate = table.Column<DateOnly>(type: "date", nullable: false),
					ClientId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
					DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_BankCards", x => x.Id);
					table.ForeignKey(
						name: "FK_BankCards_Clients_ClientId",
						column: x => x.ClientId,
						principalTable: "Clients",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				})
				.Annotation("MySql:CharSet", "utf8mb4");

			// Ensure the foreign key index is created before dropping the existing index
			migrationBuilder.CreateIndex(
				name: "IX_BankCards_ClientId",
				table: "BankCards",
				column: "ClientId");

			// You might want to handle the RentalApplications index properly
			// Drop foreign key constraint if it exists (if you are altering)
			// migrationBuilder.DropForeignKey(...);

			migrationBuilder.CreateIndex(
				name: "IX_RentalApplications_OrderId",
				table: "RentalApplications",
				column: "OrderId",
				unique: true);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			// Drop the BankCards table
			migrationBuilder.DropTable(
				name: "BankCards");

			// Drop the RentalApplications OrderId index
			migrationBuilder.DropIndex(
				name: "IX_RentalApplications_OrderId",
				table: "RentalApplications");

			// Recreate the index for OrderId (if needed, adapt this logic as necessary)
			migrationBuilder.CreateIndex(
				name: "IX_RentalApplications_OrderId",
				table: "RentalApplications",
				column: "OrderId");
		}
	}
}
