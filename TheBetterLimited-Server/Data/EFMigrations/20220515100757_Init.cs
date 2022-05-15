using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBetterLimited_Server.Data.EFMigrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "menus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menus", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "positions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _departmentId = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jobTitle = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_positions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_positions_departments__departmentId",
                        column: x => x._departmentId,
                        principalTable: "departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "permissions",
                columns: table => new
                {
                    _menuId = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _positionId = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    read = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    write = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    delete = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permissions", x => new { x._menuId, x._positionId });
                    table.ForeignKey(
                        name: "FK_permissions_menus__menuId",
                        column: x => x._menuId,
                        principalTable: "menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_permissions_positions__positionId",
                        column: x => x._positionId,
                        principalTable: "positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginFailedCount = table.Column<int>(type: "int(1)", nullable: false),
                    LoginFailedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastLogin = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    unlockDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UserName = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailAddress = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "char(1)", maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _StaffId = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Remarks = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accounts", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "staffs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _AccountId = table.Column<string>(type: "char(5)", maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _departmentId = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _positionId = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lastName = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sex = table.Column<string>(type: "char(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    age = table.Column<int>(type: "integer(2)", nullable: true),
                    phone = table.Column<string>(type: "varchar(15)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_staffs_accounts__AccountId",
                        column: x => x._AccountId,
                        principalTable: "accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_staffs_departments__departmentId",
                        column: x => x._departmentId,
                        principalTable: "departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_staffs_positions__positionId",
                        column: x => x._positionId,
                        principalTable: "positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_accounts__StaffId",
                table: "accounts",
                column: "_StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_permissions__positionId",
                table: "permissions",
                column: "_positionId");

            migrationBuilder.CreateIndex(
                name: "IX_positions__departmentId",
                table: "positions",
                column: "_departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_staffs__AccountId",
                table: "staffs",
                column: "_AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_staffs__departmentId",
                table: "staffs",
                column: "_departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_staffs__positionId",
                table: "staffs",
                column: "_positionId");

            migrationBuilder.AddForeignKey(
                name: "FK_accounts_staffs__StaffId",
                table: "accounts",
                column: "_StaffId",
                principalTable: "staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_accounts_staffs__StaffId",
                table: "accounts");

            migrationBuilder.DropTable(
                name: "permissions");

            migrationBuilder.DropTable(
                name: "menus");

            migrationBuilder.DropTable(
                name: "staffs");

            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropTable(
                name: "positions");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
