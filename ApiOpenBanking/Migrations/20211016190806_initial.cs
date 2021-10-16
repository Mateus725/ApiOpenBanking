using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiOpenBanking.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    cpfNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    passportNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    passportExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    passportIssueDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.cpfNumber);
                });

            migrationBuilder.CreateTable(
                name: "GeographicCoordinates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    longitude = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeographicCoordinates", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    isMain = table.Column<bool>(type: "bit", nullable: false),
                    ContactsID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.email);
                    table.ForeignKey(
                        name: "FK_Emails_Contacts_ContactsID",
                        column: x => x.ContactsID,
                        principalTable: "Contacts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isMain = table.Column<bool>(type: "bit", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    additionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    countryCallingCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    areaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phoneExtension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactsID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Phones_Contacts_ContactsID",
                        column: x => x.ContactsID,
                        principalTable: "Contacts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    civilName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    socialName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    maritalStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maritalStatusAdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    documentcpfNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    hasBrazilianNationality = table.Column<bool>(type: "bit", nullable: false),
                    contactsID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Accounts_Contacts_contactsID",
                        column: x => x.contactsID,
                        principalTable: "Contacts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accounts_Documents_documentcpfNumber",
                        column: x => x.documentcpfNumber,
                        principalTable: "Documents",
                        principalColumn: "cpfNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostalAdresses",
                columns: table => new
                {
                    postCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    isMain = table.Column<bool>(type: "bit", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    additionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    districtName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    townName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ibgeTownCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    countrySubDivision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    countryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    geographicCoordinatesID = table.Column<int>(type: "int", nullable: true),
                    ContactsID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostalAdresses", x => x.postCode);
                    table.ForeignKey(
                        name: "FK_PostalAdresses_Contacts_ContactsID",
                        column: x => x.ContactsID,
                        principalTable: "Contacts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostalAdresses_GeographicCoordinates_geographicCoordinatesID",
                        column: x => x.geographicCoordinatesID,
                        principalTable: "GeographicCoordinates",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyCNPJs",
                columns: table => new
                {
                    CNPJ = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccountID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyCNPJs", x => x.CNPJ);
                    table.ForeignKey(
                        name: "FK_CompanyCNPJs_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Filiations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    civilName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    socialName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Filiations_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    otherNationalitiesInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Nationalities_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OtherDocuments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    typeAdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    checkDigit = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    additionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    expirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    issueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountID = table.Column<int>(type: "int", nullable: true),
                    NationalityID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherDocuments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OtherDocuments_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OtherDocuments_Nationalities_NationalityID",
                        column: x => x.NationalityID,
                        principalTable: "Nationalities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_contactsID",
                table: "Accounts",
                column: "contactsID");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_documentcpfNumber",
                table: "Accounts",
                column: "documentcpfNumber");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyCNPJs_AccountID",
                table: "CompanyCNPJs",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_ContactsID",
                table: "Emails",
                column: "ContactsID");

            migrationBuilder.CreateIndex(
                name: "IX_Filiations_AccountID",
                table: "Filiations",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Nationalities_AccountID",
                table: "Nationalities",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_OtherDocuments_AccountID",
                table: "OtherDocuments",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_OtherDocuments_NationalityID",
                table: "OtherDocuments",
                column: "NationalityID");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_ContactsID",
                table: "Phones",
                column: "ContactsID");

            migrationBuilder.CreateIndex(
                name: "IX_PostalAdresses_ContactsID",
                table: "PostalAdresses",
                column: "ContactsID");

            migrationBuilder.CreateIndex(
                name: "IX_PostalAdresses_geographicCoordinatesID",
                table: "PostalAdresses",
                column: "geographicCoordinatesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyCNPJs");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "Filiations");

            migrationBuilder.DropTable(
                name: "OtherDocuments");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "PostalAdresses");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "GeographicCoordinates");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Documents");
        }
    }
}
