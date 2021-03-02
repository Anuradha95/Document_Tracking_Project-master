using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class form1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0ad24672-f6a2-4adf-a88c-336564f160c8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7a0521ba-5b14-4adc-b985-abaefc52536f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "bbb5ae01-96b4-4cb4-8387-cc51aeb2a5d6");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e44c53e1-65e6-4f4f-9d4c-c4357be5e3d8");

            migrationBuilder.DropColumn(
                name: "isProvided",
                table: "RisograghForm");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "VehicleReservationForms",
                newName: "InitDateTime");

            migrationBuilder.RenameColumn(
                name: "PageCount",
                table: "RisograghForm",
                newName: "NumberOfPage");

            migrationBuilder.RenameColumn(
                name: "DocTitle",
                table: "RisograghForm",
                newName: "SizeOfCopies");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "RisograghForm",
                newName: "InitDateTime");

            migrationBuilder.RenameColumn(
                name: "CopyCount",
                table: "RisograghForm",
                newName: "NumberOfCopies");

            migrationBuilder.AddColumn<string>(
                name: "FormModelName",
                table: "VehicleReservationForms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentTitle",
                table: "RisograghForm",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FinalLevelUser",
                table: "RisograghForm",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FinalUserDateTime",
                table: "RisograghForm",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FormModelName",
                table: "RisograghForm",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormStatus",
                table: "RisograghForm",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaperProvided",
                table: "RisograghForm",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "757aa414-8495-4f42-91c8-8d474c98f325", "8ea5206b-d855-4eaf-9320-46a4b22d3018", "Visitor", "VISITOR" },
                    { "57c469fa-821d-4010-9e96-6d105702f6d1", "33e2c2cc-cf6d-4d56-9ffe-c026ce53a78e", "Dean", "DEAN" },
                    { "4854a862-5250-4f8f-b044-485dc6d0f511", "4213d8b1-87c4-4c29-816d-8262914b6d9b", "Hod", "HOD" },
                    { "02ceb1ca-0722-4775-bb08-7be086f2a371", "deee2655-c462-44ec-ac6f-c79e17df035e", "Administrator", "ADMINISTRATOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "02ceb1ca-0722-4775-bb08-7be086f2a371");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4854a862-5250-4f8f-b044-485dc6d0f511");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "57c469fa-821d-4010-9e96-6d105702f6d1");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "757aa414-8495-4f42-91c8-8d474c98f325");

            migrationBuilder.DropColumn(
                name: "FormModelName",
                table: "VehicleReservationForms");

            migrationBuilder.DropColumn(
                name: "DocumentTitle",
                table: "RisograghForm");

            migrationBuilder.DropColumn(
                name: "FinalLevelUser",
                table: "RisograghForm");

            migrationBuilder.DropColumn(
                name: "FinalUserDateTime",
                table: "RisograghForm");

            migrationBuilder.DropColumn(
                name: "FormModelName",
                table: "RisograghForm");

            migrationBuilder.DropColumn(
                name: "FormStatus",
                table: "RisograghForm");

            migrationBuilder.DropColumn(
                name: "PaperProvided",
                table: "RisograghForm");

            migrationBuilder.RenameColumn(
                name: "InitDateTime",
                table: "VehicleReservationForms",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "SizeOfCopies",
                table: "RisograghForm",
                newName: "DocTitle");

            migrationBuilder.RenameColumn(
                name: "NumberOfPage",
                table: "RisograghForm",
                newName: "PageCount");

            migrationBuilder.RenameColumn(
                name: "NumberOfCopies",
                table: "RisograghForm",
                newName: "CopyCount");

            migrationBuilder.RenameColumn(
                name: "InitDateTime",
                table: "RisograghForm",
                newName: "DateTime");

            migrationBuilder.AddColumn<bool>(
                name: "isProvided",
                table: "RisograghForm",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7a0521ba-5b14-4adc-b985-abaefc52536f", "611c4b85-42f6-486f-b666-9cc3a37d2ec5", "Visitor", "VISITOR" },
                    { "bbb5ae01-96b4-4cb4-8387-cc51aeb2a5d6", "ac7f5305-1528-4a89-a314-5aa22ad6bfea", "Dean", "DEAN" },
                    { "0ad24672-f6a2-4adf-a88c-336564f160c8", "39dcb269-ab15-4bd8-a14f-2af70f612668", "Hod", "HOD" },
                    { "e44c53e1-65e6-4f4f-9d4c-c4357be5e3d8", "0faf9bd5-a837-46a6-b0a0-f954aa41a345", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
