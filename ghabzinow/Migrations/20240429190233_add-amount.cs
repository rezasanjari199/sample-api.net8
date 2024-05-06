﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ghabzinow.Migrations
{
    /// <inheritdoc />
    public partial class addamount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Amount",
                schema: "Cor",
                table: "Transactions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                schema: "Cor",
                table: "Transactions");
        }
    }
}
