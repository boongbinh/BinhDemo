using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BinhDemo.Migrations
{
    /// <inheritdoc />
    public partial class Update_FieldForm1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Form");

            migrationBuilder.DropColumn(
                name: "DefaultValue",
                table: "Field");

            migrationBuilder.DropColumn(
                name: "FieldType",
                table: "Field");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Field");

            migrationBuilder.AlterColumn<string>(
                name: "Label",
                table: "Field",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormId",
                table: "Field",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Field",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Field_FormId",
                table: "Field",
                column: "FormId");

            migrationBuilder.AddForeignKey(
                name: "FK_Field_Form_FormId",
                table: "Field",
                column: "FormId",
                principalTable: "Form",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Field_Form_FormId",
                table: "Field");

            migrationBuilder.DropIndex(
                name: "IX_Field_FormId",
                table: "Field");

            migrationBuilder.DropColumn(
                name: "FormId",
                table: "Field");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Field");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Form",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Label",
                table: "Field",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "DefaultValue",
                table: "Field",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FieldType",
                table: "Field",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Field",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
