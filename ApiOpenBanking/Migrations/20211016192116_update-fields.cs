using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiOpenBanking.Migrations
{
    public partial class updatefields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyCNPJs_Accounts_AccountID",
                table: "CompanyCNPJs");

            migrationBuilder.DropForeignKey(
                name: "FK_Filiations_Accounts_AccountID",
                table: "Filiations");

            migrationBuilder.DropForeignKey(
                name: "FK_Nationalities_Accounts_AccountID",
                table: "Nationalities");

            migrationBuilder.DropForeignKey(
                name: "FK_OtherDocuments_Accounts_AccountID",
                table: "OtherDocuments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phones",
                table: "Phones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OtherDocuments",
                table: "OtherDocuments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Filiations",
                table: "Filiations");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "OtherDocuments");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Filiations");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "OtherDocuments",
                newName: "AccountpersonalID");

            migrationBuilder.RenameIndex(
                name: "IX_OtherDocuments_AccountID",
                table: "OtherDocuments",
                newName: "IX_OtherDocuments_AccountpersonalID");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "Nationalities",
                newName: "AccountpersonalID");

            migrationBuilder.RenameIndex(
                name: "IX_Nationalities_AccountID",
                table: "Nationalities",
                newName: "IX_Nationalities_AccountpersonalID");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "Filiations",
                newName: "AccountpersonalID");

            migrationBuilder.RenameIndex(
                name: "IX_Filiations_AccountID",
                table: "Filiations",
                newName: "IX_Filiations_AccountpersonalID");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "CompanyCNPJs",
                newName: "AccountpersonalID");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyCNPJs_AccountID",
                table: "CompanyCNPJs",
                newName: "IX_CompanyCNPJs_AccountpersonalID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Accounts",
                newName: "personalID");

            migrationBuilder.AlterColumn<string>(
                name: "number",
                table: "Phones",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                name: "civilName",
                table: "Filiations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phones",
                table: "Phones",
                column: "number");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OtherDocuments",
                table: "OtherDocuments",
                column: "number");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filiations",
                table: "Filiations",
                column: "civilName");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyCNPJs_Accounts_AccountpersonalID",
                table: "CompanyCNPJs",
                column: "AccountpersonalID",
                principalTable: "Accounts",
                principalColumn: "personalID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Filiations_Accounts_AccountpersonalID",
                table: "Filiations",
                column: "AccountpersonalID",
                principalTable: "Accounts",
                principalColumn: "personalID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Nationalities_Accounts_AccountpersonalID",
                table: "Nationalities",
                column: "AccountpersonalID",
                principalTable: "Accounts",
                principalColumn: "personalID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OtherDocuments_Accounts_AccountpersonalID",
                table: "OtherDocuments",
                column: "AccountpersonalID",
                principalTable: "Accounts",
                principalColumn: "personalID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyCNPJs_Accounts_AccountpersonalID",
                table: "CompanyCNPJs");

            migrationBuilder.DropForeignKey(
                name: "FK_Filiations_Accounts_AccountpersonalID",
                table: "Filiations");

            migrationBuilder.DropForeignKey(
                name: "FK_Nationalities_Accounts_AccountpersonalID",
                table: "Nationalities");

            migrationBuilder.DropForeignKey(
                name: "FK_OtherDocuments_Accounts_AccountpersonalID",
                table: "OtherDocuments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phones",
                table: "Phones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OtherDocuments",
                table: "OtherDocuments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Filiations",
                table: "Filiations");

            migrationBuilder.RenameColumn(
                name: "AccountpersonalID",
                table: "OtherDocuments",
                newName: "AccountID");

            migrationBuilder.RenameIndex(
                name: "IX_OtherDocuments_AccountpersonalID",
                table: "OtherDocuments",
                newName: "IX_OtherDocuments_AccountID");

            migrationBuilder.RenameColumn(
                name: "AccountpersonalID",
                table: "Nationalities",
                newName: "AccountID");

            migrationBuilder.RenameIndex(
                name: "IX_Nationalities_AccountpersonalID",
                table: "Nationalities",
                newName: "IX_Nationalities_AccountID");

            migrationBuilder.RenameColumn(
                name: "AccountpersonalID",
                table: "Filiations",
                newName: "AccountID");

            migrationBuilder.RenameIndex(
                name: "IX_Filiations_AccountpersonalID",
                table: "Filiations",
                newName: "IX_Filiations_AccountID");

            migrationBuilder.RenameColumn(
                name: "AccountpersonalID",
                table: "CompanyCNPJs",
                newName: "AccountID");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyCNPJs_AccountpersonalID",
                table: "CompanyCNPJs",
                newName: "IX_CompanyCNPJs_AccountID");

            migrationBuilder.RenameColumn(
                name: "personalID",
                table: "Accounts",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "number",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Phones",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

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
                name: "civilName",
                table: "Filiations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Filiations",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phones",
                table: "Phones",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OtherDocuments",
                table: "OtherDocuments",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filiations",
                table: "Filiations",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyCNPJs_Accounts_AccountID",
                table: "CompanyCNPJs",
                column: "AccountID",
                principalTable: "Accounts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Filiations_Accounts_AccountID",
                table: "Filiations",
                column: "AccountID",
                principalTable: "Accounts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Nationalities_Accounts_AccountID",
                table: "Nationalities",
                column: "AccountID",
                principalTable: "Accounts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OtherDocuments_Accounts_AccountID",
                table: "OtherDocuments",
                column: "AccountID",
                principalTable: "Accounts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
