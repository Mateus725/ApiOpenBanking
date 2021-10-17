using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiOpenBanking.Migrations
{
    public partial class testedocumento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Documents_documentcpfNumber",
                table: "Accounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OtherDocuments",
                table: "OtherDocuments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Documents",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_documentcpfNumber",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "documentcpfNumber",
                table: "Accounts");

            migrationBuilder.AlterColumn<string>(
                name: "number",
                table: "OtherDocuments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "OtherDocuments",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "cpfNumber",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Documents",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "documentID",
                table: "Accounts",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OtherDocuments",
                table: "OtherDocuments",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Documents",
                table: "Documents",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_documentID",
                table: "Accounts",
                column: "documentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Documents_documentID",
                table: "Accounts",
                column: "documentID",
                principalTable: "Documents",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Documents_documentID",
                table: "Accounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OtherDocuments",
                table: "OtherDocuments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Documents",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_documentID",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "OtherDocuments");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "documentID",
                table: "Accounts");

            migrationBuilder.AlterColumn<string>(
                name: "number",
                table: "OtherDocuments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cpfNumber",
                table: "Documents",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "documentcpfNumber",
                table: "Accounts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OtherDocuments",
                table: "OtherDocuments",
                column: "number");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Documents",
                table: "Documents",
                column: "cpfNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_documentcpfNumber",
                table: "Accounts",
                column: "documentcpfNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Documents_documentcpfNumber",
                table: "Accounts",
                column: "documentcpfNumber",
                principalTable: "Documents",
                principalColumn: "cpfNumber",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
