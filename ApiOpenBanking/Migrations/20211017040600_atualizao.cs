using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiOpenBanking.Migrations
{
    public partial class atualizao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Contacts_contactsID",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Documents_documentID",
                table: "Accounts");

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

            migrationBuilder.DropIndex(
                name: "IX_OtherDocuments_AccountpersonalID",
                table: "OtherDocuments");

            migrationBuilder.DropIndex(
                name: "IX_Nationalities_AccountpersonalID",
                table: "Nationalities");

            migrationBuilder.DropIndex(
                name: "IX_Filiations_AccountpersonalID",
                table: "Filiations");

            migrationBuilder.DropIndex(
                name: "IX_CompanyCNPJs_AccountpersonalID",
                table: "CompanyCNPJs");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_contactsID",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_documentID",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "AccountpersonalID",
                table: "OtherDocuments");

            migrationBuilder.DropColumn(
                name: "AccountpersonalID",
                table: "Nationalities");

            migrationBuilder.DropColumn(
                name: "AccountpersonalID",
                table: "Filiations");

            migrationBuilder.DropColumn(
                name: "AccountpersonalID",
                table: "CompanyCNPJs");

            migrationBuilder.DropColumn(
                name: "contactsID",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "documentID",
                table: "Accounts");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "additionalInfo",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "additionalInfoAdress",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "additionalInfoPhone1",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "additionalInfoPhone2",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "areaCodePhone1",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "areaCodePhone2",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "checkDigit",
                table: "Accounts",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "civilNameFiliation",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "companyCnpj",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "country",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "countryAdress",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "countryCallingCode1",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "countryCallingCode2",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "countryCode",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "countrySubDivision",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "districtName",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "expirationDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ibgeTownCode",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "issueDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "numberDocument",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "numberPhone1",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "numberPhone2",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "otherNationalitiesInfo",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phoneExtension1",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phoneExtension2",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "postCode",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "socialNameFiliation",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "townName",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "typeAdditionalInfo",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "typeDocument",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "typeFiliation",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "typePhone1",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "typePhone2",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "additionalInfo",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "additionalInfoAdress",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "additionalInfoPhone1",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "additionalInfoPhone2",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "address",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "areaCodePhone1",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "areaCodePhone2",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "checkDigit",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "civilNameFiliation",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "companyCnpj",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "country",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "countryAdress",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "countryCallingCode1",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "countryCallingCode2",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "countryCode",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "countrySubDivision",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "districtName",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "expirationDate",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "ibgeTownCode",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "issueDate",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "numberDocument",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "numberPhone1",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "numberPhone2",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "otherNationalitiesInfo",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "phoneExtension1",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "phoneExtension2",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "postCode",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "socialNameFiliation",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "townName",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "typeAdditionalInfo",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "typeDocument",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "typeFiliation",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "typePhone1",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "typePhone2",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "AccountpersonalID",
                table: "OtherDocuments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountpersonalID",
                table: "Nationalities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountpersonalID",
                table: "Filiations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountpersonalID",
                table: "CompanyCNPJs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "contactsID",
                table: "Accounts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "documentID",
                table: "Accounts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OtherDocuments_AccountpersonalID",
                table: "OtherDocuments",
                column: "AccountpersonalID");

            migrationBuilder.CreateIndex(
                name: "IX_Nationalities_AccountpersonalID",
                table: "Nationalities",
                column: "AccountpersonalID");

            migrationBuilder.CreateIndex(
                name: "IX_Filiations_AccountpersonalID",
                table: "Filiations",
                column: "AccountpersonalID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyCNPJs_AccountpersonalID",
                table: "CompanyCNPJs",
                column: "AccountpersonalID");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_contactsID",
                table: "Accounts",
                column: "contactsID");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_documentID",
                table: "Accounts",
                column: "documentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Contacts_contactsID",
                table: "Accounts",
                column: "contactsID",
                principalTable: "Contacts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Documents_documentID",
                table: "Accounts",
                column: "documentID",
                principalTable: "Documents",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

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
    }
}
