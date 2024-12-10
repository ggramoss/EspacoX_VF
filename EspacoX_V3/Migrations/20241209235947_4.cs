using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EspacoX_V3.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Room");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Room",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Room",
                newName: "Descrição");

            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "Room",
                newName: "Capacidade");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Building",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Building",
                newName: "Estado");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Building",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Building",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Building");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Building");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Room",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Descrição",
                table: "Room",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Capacidade",
                table: "Room",
                newName: "Capacity");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Building",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Building",
                newName: "Address");

            migrationBuilder.AddColumn<bool>(
                name: "Availability",
                table: "Room",
                type: "bit",
                nullable: true);
        }
    }
}
