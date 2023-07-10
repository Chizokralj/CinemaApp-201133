using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaApp.Migrations
{
    public partial class migracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_OwnerId",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCarts_OwnerId",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "SelectedGenre",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TicketDescription",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TicketImage",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TicketName",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TicketPrice",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "ShoppingCarts");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tickets",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ShoppingCarts",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "CenaKarta",
                table: "Tickets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DetaliKarta",
                table: "Tickets",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImeKarta",
                table: "Tickets",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SelektiranZanr",
                table: "Tickets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SlikaKarta",
                table: "Tickets",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GazdaId",
                table: "ShoppingCarts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_GazdaId",
                table: "ShoppingCarts",
                column: "GazdaId",
                unique: true,
                filter: "[GazdaId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_GazdaId",
                table: "ShoppingCarts",
                column: "GazdaId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_GazdaId",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCarts_GazdaId",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "CenaKarta",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "DetaliKarta",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ImeKarta",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "SelektiranZanr",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "SlikaKarta",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "GazdaId",
                table: "ShoppingCarts");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Tickets",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ShoppingCarts",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "SelectedGenre",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TicketDescription",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TicketImage",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TicketName",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TicketPrice",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "ShoppingCarts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_OwnerId",
                table: "ShoppingCarts",
                column: "OwnerId",
                unique: true,
                filter: "[OwnerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_OwnerId",
                table: "ShoppingCarts",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
