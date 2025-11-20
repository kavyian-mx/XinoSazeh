using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xino.DEL.Migrations
{
    /// <inheritdoc />
    public partial class configindexer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GalleryImageProjects_ProjectId",
                table: "GalleryImageProjects");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Projects",
                type: "varchar(300)",
                unicode: false,
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "InteriorDecorations",
                type: "varchar(300)",
                unicode: false,
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Blugs",
                type: "varchar(300)",
                unicode: false,
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_IsDeleted_BuildDate",
                table: "Projects",
                columns: new[] { "IsDeleted", "BuildDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_Slug",
                table: "Projects",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_YearProject",
                table: "Projects",
                column: "YearProject");

            migrationBuilder.CreateIndex(
                name: "IX_InteriorDecorations_IsDeleted_BuildDate",
                table: "InteriorDecorations",
                columns: new[] { "IsDeleted", "BuildDate" });

            migrationBuilder.CreateIndex(
                name: "IX_InteriorDecorations_Slug",
                table: "InteriorDecorations",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GalleryImageProjects_ProjectId_Order",
                table: "GalleryImageProjects",
                columns: new[] { "ProjectId", "Order" });

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumVitaes_IsChacket_BuildDate",
                table: "CurriculumVitaes",
                columns: new[] { "IsChacket", "BuildDate" });

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumVitaes_PhoneNumber",
                table: "CurriculumVitaes",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Consultations_IsChacket_BuildDate",
                table: "Consultations",
                columns: new[] { "IsChacket", "BuildDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Consultations_PhoneNumber",
                table: "Consultations",
                column: "PhoneNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Blugs_blugCategory",
                table: "Blugs",
                column: "blugCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Blugs_IsDeleted_BuildDate",
                table: "Blugs",
                columns: new[] { "IsDeleted", "BuildDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Blugs_Slug",
                table: "Blugs",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Admins_Name",
                table: "Admins",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Projects_IsDeleted_BuildDate",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_Slug",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_YearProject",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_InteriorDecorations_IsDeleted_BuildDate",
                table: "InteriorDecorations");

            migrationBuilder.DropIndex(
                name: "IX_InteriorDecorations_Slug",
                table: "InteriorDecorations");

            migrationBuilder.DropIndex(
                name: "IX_GalleryImageProjects_ProjectId_Order",
                table: "GalleryImageProjects");

            migrationBuilder.DropIndex(
                name: "IX_CurriculumVitaes_IsChacket_BuildDate",
                table: "CurriculumVitaes");

            migrationBuilder.DropIndex(
                name: "IX_CurriculumVitaes_PhoneNumber",
                table: "CurriculumVitaes");

            migrationBuilder.DropIndex(
                name: "IX_Consultations_IsChacket_BuildDate",
                table: "Consultations");

            migrationBuilder.DropIndex(
                name: "IX_Consultations_PhoneNumber",
                table: "Consultations");

            migrationBuilder.DropIndex(
                name: "IX_Blugs_blugCategory",
                table: "Blugs");

            migrationBuilder.DropIndex(
                name: "IX_Blugs_IsDeleted_BuildDate",
                table: "Blugs");

            migrationBuilder.DropIndex(
                name: "IX_Blugs_Slug",
                table: "Blugs");

            migrationBuilder.DropIndex(
                name: "IX_Admins_Name",
                table: "Admins");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Projects",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldUnicode: false,
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "InteriorDecorations",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldUnicode: false,
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Blugs",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldUnicode: false,
                oldMaxLength: 300);

            migrationBuilder.CreateIndex(
                name: "IX_GalleryImageProjects_ProjectId",
                table: "GalleryImageProjects",
                column: "ProjectId");
        }
    }
}
