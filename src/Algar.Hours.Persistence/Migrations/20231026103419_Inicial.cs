using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Algar.Hours.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientEntity",
                columns: table => new
                {
                    IdClient = table.Column<Guid>(type: "uuid", nullable: false),
                    NameClient = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientEntity", x => x.IdClient);
                });

            migrationBuilder.CreateTable(
                name: "CountryEntity",
                columns: table => new
                {
                    IdCounty = table.Column<Guid>(type: "uuid", nullable: false),
                    NameCountry = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryEntity", x => x.IdCounty);
                });

            migrationBuilder.CreateTable(
                name: "MenuEntity",
                columns: table => new
                {
                    IdMenu = table.Column<Guid>(type: "uuid", nullable: false),
                    NameMenu = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuEntity", x => x.IdMenu);
                });

            migrationBuilder.CreateTable(
                name: "RoleEntity",
                columns: table => new
                {
                    IdRole = table.Column<Guid>(type: "uuid", nullable: false),
                    NameRole = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleEntity", x => x.IdRole);
                });

            migrationBuilder.CreateTable(
                name: "ParametersEntity",
                columns: table => new
                {
                    IdParametersEntity = table.Column<Guid>(type: "uuid", nullable: false),
                    TargetTimeDay = table.Column<double>(type: "double precision", nullable: false),
                    TargetHourWeek = table.Column<double>(type: "double precision", nullable: false),
                    TargetHourMonth = table.Column<double>(type: "double precision", nullable: false),
                    TypeLimits = table.Column<int>(type: "integer", nullable: false),
                    CountryEntityId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParametersEntity", x => x.IdParametersEntity);
                    table.ForeignKey(
                        name: "FK_ParametersEntity_CountryEntity_CountryEntityId",
                        column: x => x.CountryEntityId,
                        principalTable: "CountryEntity",
                        principalColumn: "IdCounty",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleMenuEntity",
                columns: table => new
                {
                    IdRoleMenu = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    MenuEntityId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenuEntity", x => x.IdRoleMenu);
                    table.ForeignKey(
                        name: "FK_RoleMenuEntity_MenuEntity_MenuEntityId",
                        column: x => x.MenuEntityId,
                        principalTable: "MenuEntity",
                        principalColumn: "IdMenu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleMenuEntity_RoleEntity_RoleId",
                        column: x => x.RoleId,
                        principalTable: "RoleEntity",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEntity",
                columns: table => new
                {
                    IdUser = table.Column<Guid>(type: "uuid", nullable: false),
                    NameUser = table.Column<string>(type: "text", nullable: false),
                    surnameUser = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    EmployeeCode = table.Column<string>(type: "text", nullable: false),
                    RoleEntityId = table.Column<Guid>(type: "uuid", nullable: false),
                    CountryEntityId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEntity", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_UserEntity_CountryEntity_CountryEntityId",
                        column: x => x.CountryEntityId,
                        principalTable: "CountryEntity",
                        principalColumn: "IdCounty",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEntity_RoleEntity_RoleEntityId",
                        column: x => x.RoleEntityId,
                        principalTable: "RoleEntity",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HorusReportEntity",
                columns: table => new
                {
                    IdHorusReport = table.Column<Guid>(type: "uuid", nullable: false),
                    UserEntityId = table.Column<Guid>(type: "uuid", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    StartTime = table.Column<string>(type: "text", nullable: false),
                    EndTime = table.Column<string>(type: "text", nullable: false),
                    ClientEntityId = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TipoReporte = table.Column<int>(type: "integer", nullable: false),
                    DateApprovalSystem = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorusReportEntity", x => x.IdHorusReport);
                    table.ForeignKey(
                        name: "FK_HorusReportEntity_ClientEntity_ClientEntityId",
                        column: x => x.ClientEntityId,
                        principalTable: "ClientEntity",
                        principalColumn: "IdClient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HorusReportEntity_UserEntity_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "UserEntity",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersExceptions",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    IdUsersExceptions = table.Column<Guid>(type: "uuid", nullable: false),
                    AssignedUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersExceptions", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UsersExceptions_UserEntity_UserId",
                        column: x => x.UserId,
                        principalTable: "UserEntity",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "assignmentReports",
                columns: table => new
                {
                    IdAssignmentReport = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    HorusReportId = table.Column<Guid>(type: "uuid", nullable: false),
                    State = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DateApprovalCancellation = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assignmentReports", x => x.IdAssignmentReport);
                    table.ForeignKey(
                        name: "FK_assignmentReports_HorusReportEntity_HorusReportId",
                        column: x => x.HorusReportId,
                        principalTable: "HorusReportEntity",
                        principalColumn: "IdHorusReport",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_assignmentReports_UserEntity_UserId",
                        column: x => x.UserId,
                        principalTable: "UserEntity",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_assignmentReports_HorusReportId",
                table: "assignmentReports",
                column: "HorusReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_assignmentReports_UserId",
                table: "assignmentReports",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HorusReportEntity_ClientEntityId",
                table: "HorusReportEntity",
                column: "ClientEntityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HorusReportEntity_UserEntityId",
                table: "HorusReportEntity",
                column: "UserEntityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ParametersEntity_CountryEntityId",
                table: "ParametersEntity",
                column: "CountryEntityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenuEntity_MenuEntityId",
                table: "RoleMenuEntity",
                column: "MenuEntityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenuEntity_RoleId",
                table: "RoleMenuEntity",
                column: "RoleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserEntity_CountryEntityId",
                table: "UserEntity",
                column: "CountryEntityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserEntity_RoleEntityId",
                table: "UserEntity",
                column: "RoleEntityId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "assignmentReports");

            migrationBuilder.DropTable(
                name: "ParametersEntity");

            migrationBuilder.DropTable(
                name: "RoleMenuEntity");

            migrationBuilder.DropTable(
                name: "UsersExceptions");

            migrationBuilder.DropTable(
                name: "HorusReportEntity");

            migrationBuilder.DropTable(
                name: "MenuEntity");

            migrationBuilder.DropTable(
                name: "ClientEntity");

            migrationBuilder.DropTable(
                name: "UserEntity");

            migrationBuilder.DropTable(
                name: "CountryEntity");

            migrationBuilder.DropTable(
                name: "RoleEntity");
        }
    }
}
