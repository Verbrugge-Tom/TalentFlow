using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TalentFlow.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAuditionDomainEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Auditions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomAuditionRequired = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubmittedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PlatformId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Auditions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Auditions_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AuditionFiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<int>(type: "int", nullable: false),
                    UploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuditionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditionFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditionFiles_Auditions_AuditionId",
                        column: x => x.AuditionId,
                        principalTable: "Auditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuditionFiles_AuditionId",
                table: "AuditionFiles",
                column: "AuditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Auditions_PlatformId",
                table: "Auditions",
                column: "PlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_Auditions_UserId",
                table: "Auditions",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditionFiles");

            migrationBuilder.DropTable(
                name: "Auditions");

            migrationBuilder.DropTable(
                name: "Platforms");
        }
    }
}
