using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiOpenBanking.Migrations
{
    public partial class updatecontacts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostalAdresses_Contacts_ContactsID",
                table: "PostalAdresses");

            migrationBuilder.DropIndex(
                name: "IX_PostalAdresses_ContactsID",
                table: "PostalAdresses");

            migrationBuilder.DropColumn(
                name: "ContactsID",
                table: "PostalAdresses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContactsID",
                table: "PostalAdresses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PostalAdresses_ContactsID",
                table: "PostalAdresses",
                column: "ContactsID");

            migrationBuilder.AddForeignKey(
                name: "FK_PostalAdresses_Contacts_ContactsID",
                table: "PostalAdresses",
                column: "ContactsID",
                principalTable: "Contacts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
