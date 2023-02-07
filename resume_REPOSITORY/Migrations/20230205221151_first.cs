using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace resumeREPOSITORY.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "headings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    work = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    education = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    awards = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    skills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    projects = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_headings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "basics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    locationId = table.Column<int>(type: "int", nullable: false),
                    website = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_basics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_basics_location_locationId",
                        column: x => x.locationId,
                        principalTable: "location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "roots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    selectedTemplate = table.Column<int>(type: "int", nullable: false),
                    headingsId = table.Column<int>(type: "int", nullable: false),
                    basicsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_roots_basics_basicsId",
                        column: x => x.basicsId,
                        principalTable: "basics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_roots_headings_headingsId",
                        column: x => x.headingsId,
                        principalTable: "headings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "awards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    awarder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RootDTOId = table.Column<int>(name: "Root_DTOId", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_awards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_awards_roots_Root_DTOId",
                        column: x => x.RootDTOId,
                        principalTable: "roots",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    institution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    endDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    startDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RootDTOId = table.Column<int>(name: "Root_DTOId", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_educations_roots_Root_DTOId",
                        column: x => x.RootDTOId,
                        principalTable: "roots",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RootDTOId = table.Column<int>(name: "Root_DTOId", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_projects_roots_Root_DTOId",
                        column: x => x.RootDTOId,
                        principalTable: "roots",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    section = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RootDTOId = table.Column<int>(name: "Root_DTOId", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sections_roots_Root_DTOId",
                        column: x => x.RootDTOId,
                        principalTable: "roots",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RootDTOId = table.Column<int>(name: "Root_DTOId", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_skills_roots_Root_DTOId",
                        column: x => x.RootDTOId,
                        principalTable: "roots",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "work",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    startDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RootDTOId = table.Column<int>(name: "Root_DTOId", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_work", x => x.Id);
                    table.ForeignKey(
                        name: "FK_work_roots_Root_DTOId",
                        column: x => x.RootDTOId,
                        principalTable: "roots",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "keywords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    keyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectsDTOId = table.Column<int>(name: "Projects_DTOId", type: "int", nullable: true),
                    SkillsDTOId = table.Column<int>(name: "Skills_DTOId", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_keywords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_keywords_projects_Projects_DTOId",
                        column: x => x.ProjectsDTOId,
                        principalTable: "projects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_keywords_skills_Skills_DTOId",
                        column: x => x.SkillsDTOId,
                        principalTable: "skills",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "highlights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    highlight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkDTOId = table.Column<int>(name: "Work_DTOId", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_highlights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_highlights_work_Work_DTOId",
                        column: x => x.WorkDTOId,
                        principalTable: "work",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_awards_Root_DTOId",
                table: "awards",
                column: "Root_DTOId");

            migrationBuilder.CreateIndex(
                name: "IX_basics_locationId",
                table: "basics",
                column: "locationId");

            migrationBuilder.CreateIndex(
                name: "IX_educations_Root_DTOId",
                table: "educations",
                column: "Root_DTOId");

            migrationBuilder.CreateIndex(
                name: "IX_highlights_Work_DTOId",
                table: "highlights",
                column: "Work_DTOId");

            migrationBuilder.CreateIndex(
                name: "IX_keywords_Projects_DTOId",
                table: "keywords",
                column: "Projects_DTOId");

            migrationBuilder.CreateIndex(
                name: "IX_keywords_Skills_DTOId",
                table: "keywords",
                column: "Skills_DTOId");

            migrationBuilder.CreateIndex(
                name: "IX_projects_Root_DTOId",
                table: "projects",
                column: "Root_DTOId");

            migrationBuilder.CreateIndex(
                name: "IX_roots_basicsId",
                table: "roots",
                column: "basicsId");

            migrationBuilder.CreateIndex(
                name: "IX_roots_headingsId",
                table: "roots",
                column: "headingsId");

            migrationBuilder.CreateIndex(
                name: "IX_sections_Root_DTOId",
                table: "sections",
                column: "Root_DTOId");

            migrationBuilder.CreateIndex(
                name: "IX_skills_Root_DTOId",
                table: "skills",
                column: "Root_DTOId");

            migrationBuilder.CreateIndex(
                name: "IX_work_Root_DTOId",
                table: "work",
                column: "Root_DTOId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "awards");

            migrationBuilder.DropTable(
                name: "educations");

            migrationBuilder.DropTable(
                name: "highlights");

            migrationBuilder.DropTable(
                name: "keywords");

            migrationBuilder.DropTable(
                name: "sections");

            migrationBuilder.DropTable(
                name: "work");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "skills");

            migrationBuilder.DropTable(
                name: "roots");

            migrationBuilder.DropTable(
                name: "basics");

            migrationBuilder.DropTable(
                name: "headings");

            migrationBuilder.DropTable(
                name: "location");
        }
    }
}
