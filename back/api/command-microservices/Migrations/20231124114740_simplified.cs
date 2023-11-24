using System;
using System.Numerics;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace command_microservices.Migrations
{
    /// <inheritdoc />
    public partial class simplified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Commands",
                type: "integer",
                nullable: false,
                oldClrType: typeof(BigInteger),
                oldType: "numeric");

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Commands",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Commands",
                type: "integer",
                nullable: false,
                oldClrType: typeof(BigInteger),
                oldType: "numeric")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<BigInteger>(
                name: "UserID",
                table: "Commands",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "Commands",
                type: "date",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<BigInteger>(
                name: "ID",
                table: "Commands",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }
    }
}
