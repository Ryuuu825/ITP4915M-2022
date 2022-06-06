using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBetterLimited_Server.Data.EFMigrations
{
    public partial class CleanUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Catalogue",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogue", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Loc = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sessionSetting",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StartTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NumOfAppointments = table.Column<sbyte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sessionSetting", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Contact = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _catalogueId = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<int>(type: "MEDIUMINT", nullable: false),
                    GTINCode = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Size = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int(1)", nullable: false),
                    Photo = table.Column<byte[]>(type: "longblob", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goods_Catalogue__catalogueId",
                        column: x => x._catalogueId,
                        principalTable: "Catalogue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _locationID = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Store_Location__locationID",
                        column: x => x._locationID,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _locationID = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Warehouse_Location__locationID",
                        column: x => x._locationID,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DisplayItem",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _goodsId = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _locationId = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _supplierId = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "char(1)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisplayItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DisplayItem_Goods__goodsId",
                        column: x => x._goodsId,
                        principalTable: "Goods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DisplayItem_Location__locationId",
                        column: x => x._locationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DisplayItem_Supplier__supplierId",
                        column: x => x._supplierId,
                        principalTable: "Supplier",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Supplier_Goods",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(9)", maxLength: 9, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _supplierId = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _goodsId = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "DECIMAL(7,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier_Goods", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Supplier_Goods_Goods__goodsId",
                        column: x => x._goodsId,
                        principalTable: "Goods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Supplier_Goods_Supplier__supplierId",
                        column: x => x._supplierId,
                        principalTable: "Supplier",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Supplier_Goods_Stock",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _locationId = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _supplierGoodsId = table.Column<string>(type: "char(9)", maxLength: 9, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Quantity = table.Column<int>(type: "MEDIUMINT", nullable: false),
                    MaxLimit = table.Column<int>(type: "MEDIUMINT", nullable: false),
                    MinLimit = table.Column<int>(type: "MEDIUMINT", nullable: false),
                    ReorderLevel = table.Column<int>(type: "MEDIUMINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier_Goods_Stock", x => new { x.Id, x._supplierGoodsId, x._locationId });
                    table.UniqueConstraint("AK_Supplier_Goods_Stock__supplierGoodsId__locationId", x => new { x._supplierGoodsId, x._locationId });
                    table.UniqueConstraint("AK_Supplier_Goods_Stock_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Supplier_Goods_Stock_Location__locationId",
                        column: x => x._locationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Supplier_Goods_Stock_Supplier_Goods__supplierGoodsId",
                        column: x => x._supplierGoodsId,
                        principalTable: "Supplier_Goods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "char(15)", maxLength: 15, nullable: false)
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
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginFailedCount = table.Column<int>(type: "int(1)", nullable: false),
                    LoginFailedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastLogin = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    unlockDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Icon = table.Column<byte[]>(type: "longblob", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _senderId = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Content = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SentDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Message_Account__senderId",
                        column: x => x._senderId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Staff_Message",
                columns: table => new
                {
                    _messageId = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _receiverId = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff_Message", x => new { x._messageId, x._receiverId });
                    table.ForeignKey(
                        name: "FK_Staff_Message_Account__receiverId",
                        column: x => x._receiverId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staff_Message_Message__messageId",
                        column: x => x._messageId,
                        principalTable: "Message",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _sessionId = table.Column<string>(type: "char(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _departmentId = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _teamId = table.Column<string>(type: "char(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BookingOrder",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _customerId = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _appointmentId = table.Column<string>(type: "char(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Remarks = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingOrder", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BookingOrder_Appointment__appointmentId",
                        column: x => x._appointmentId,
                        principalTable: "Appointment",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BookingOrder_Customer__customerId",
                        column: x => x._customerId,
                        principalTable: "Customer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Budget",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _operatorId = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<decimal>(type: "DECIMAL(7,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ResetDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budget", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _budgetId = table.Column<string>(type: "char(3)", maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_Budget__budgetId",
                        column: x => x._budgetId,
                        principalTable: "Budget",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _departmentId = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    jobTitle = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Position_Department__departmentId",
                        column: x => x._departmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _departmentId = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StartTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NumOfAppointments = table.Column<sbyte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Session_Department__departmentId",
                        column: x => x._departmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _departmentId = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Team_Department__departmentId",
                        column: x => x._departmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Permission",
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
                    table.PrimaryKey("PK_Permission", x => new { x._menuId, x._positionId });
                    table.ForeignKey(
                        name: "FK_Permission_Menu__menuId",
                        column: x => x._menuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permission_Position__positionId",
                        column: x => x._positionId,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Staff",
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
                    _warehouseId = table.Column<string>(type: "char(3)", maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _storeId = table.Column<string>(type: "char(3)", maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _teamId = table.Column<string>(type: "char(3)", maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sex = table.Column<string>(type: "char(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Age = table.Column<int>(type: "integer(2)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(15)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.CheckConstraint("age_cc", "age >= 18 and age <= 60");
                    table.CheckConstraint("sex_cc", "sex in ('M' , 'F') ");
                    table.ForeignKey(
                        name: "FK_Staff_Account__AccountId",
                        column: x => x._AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staff_Department__departmentId",
                        column: x => x._departmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staff_Position__positionId",
                        column: x => x._positionId,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staff_Store__storeId",
                        column: x => x._storeId,
                        principalTable: "Store",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Staff_Team__teamId",
                        column: x => x._teamId,
                        principalTable: "Team",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Staff_Warehouse__warehouseId",
                        column: x => x._warehouseId,
                        principalTable: "Warehouse",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DayOffRecord",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _staffID = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OffDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Reason = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayOffRecord", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DayOffRecord_Staff__staffID",
                        column: x => x._staffID,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _createrId = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _operatorId = table.Column<string>(type: "char(5)", maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _warehouseId = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    OperateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Staff__createrId",
                        column: x => x._createrId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Staff__operatorId",
                        column: x => x._operatorId,
                        principalTable: "Staff",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Warehouse__warehouseId",
                        column: x => x._warehouseId,
                        principalTable: "Warehouse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RestockRequest",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _createrId = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _operatorId = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _storeId = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    OperateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestockRequest", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RestockRequest_Location__storeId",
                        column: x => x._storeId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestockRequest_Staff__createrId",
                        column: x => x._createrId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestockRequest_Staff__operatorId",
                        column: x => x._operatorId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SalesOrder",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _creatorId = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _operatorId = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _storeId = table.Column<string>(type: "char(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createdAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrder", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SalesOrder_Staff__creatorId",
                        column: x => x._creatorId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrder_Staff__operatorId",
                        column: x => x._operatorId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrder_Store__storeId",
                        column: x => x._storeId,
                        principalTable: "Store",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PurchaseOrder_Supplier_Goods",
                columns: table => new
                {
                    _purchaseOrderId = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _supplierGoodsId = table.Column<string>(type: "char(9)", maxLength: 9, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Quantity = table.Column<short>(type: "SMALLINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder_Supplier_Goods", x => new { x._purchaseOrderId, x._supplierGoodsId });
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Supplier_Goods_PurchaseOrder__purchaseOrderId",
                        column: x => x._purchaseOrderId,
                        principalTable: "PurchaseOrder",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Supplier_Goods_Supplier_Goods__supplierGoodsId",
                        column: x => x._supplierGoodsId,
                        principalTable: "Supplier_Goods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RestockRequest_Supplier_Goods",
                columns: table => new
                {
                    _restockRequestId = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _supplierGoodsId = table.Column<string>(type: "char(9)", maxLength: 9, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _quantity = table.Column<int>(type: "MEDIUMINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestockRequest_Supplier_Goods", x => new { x._restockRequestId, x._supplierGoodsId });
                    table.ForeignKey(
                        name: "FK_RestockRequest_Supplier_Goods_RestockRequest__restockRequest~",
                        column: x => x._restockRequestId,
                        principalTable: "RestockRequest",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestockRequest_Supplier_Goods_Supplier_Goods__supplierGoodsId",
                        column: x => x._supplierGoodsId,
                        principalTable: "Supplier_Goods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DefectItemRecord",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _supplierGoodsStockId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SupplierGoodsStock_supplierGoodsId = table.Column<string>(type: "char(9)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SupplierGoodsStock_locationId = table.Column<string>(type: "char(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _salesOrderId = table.Column<string>(type: "char(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _creatorId = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _operatorId = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Remark = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefectItemRecord", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DefectItemRecord_SalesOrder__salesOrderId",
                        column: x => x._salesOrderId,
                        principalTable: "SalesOrder",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DefectItemRecord_Staff__creatorId",
                        column: x => x._creatorId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DefectItemRecord_Staff__operatorId",
                        column: x => x._operatorId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DefectItemRecord_Supplier_Goods_Stock_SupplierGoodsStock_sup~",
                        columns: x => new { x.SupplierGoodsStock_supplierGoodsId, x.SupplierGoodsStock_locationId },
                        principalTable: "Supplier_Goods_Stock",
                        principalColumns: new[] { "_supplierGoodsId", "_locationId" });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SalesOrderItem",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _salesOrderId = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _supplierGoodsStockId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Quantity = table.Column<sbyte>(type: "TINYINT", nullable: false),
                    _bookingOrderId = table.Column<string>(type: "char(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesOrderItem_BookingOrder__bookingOrderId",
                        column: x => x._bookingOrderId,
                        principalTable: "BookingOrder",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SalesOrderItem_SalesOrder__salesOrderId",
                        column: x => x._salesOrderId,
                        principalTable: "SalesOrder",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderItem_Supplier_Goods_Stock__supplierGoodsStockId",
                        column: x => x._supplierGoodsStockId,
                        principalTable: "Supplier_Goods_Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _salesOrderId = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<decimal>(type: "DECIMAL(7,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Transaction_SalesOrder__salesOrderId",
                        column: x => x._salesOrderId,
                        principalTable: "SalesOrder",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "saleOrderItem_Appointment",
                columns: table => new
                {
                    _salesOrderItemId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    _appointmentId = table.Column<string>(type: "char(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saleOrderItem_Appointment", x => new { x._salesOrderItemId, x._appointmentId });
                    table.ForeignKey(
                        name: "FK_saleOrderItem_Appointment_Appointment__appointmentId",
                        column: x => x._appointmentId,
                        principalTable: "Appointment",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_saleOrderItem_Appointment_SalesOrderItem__salesOrderItemId",
                        column: x => x._salesOrderItemId,
                        principalTable: "SalesOrderItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Account__StaffId",
                table: "Account",
                column: "_StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment__departmentId",
                table: "Appointment",
                column: "_departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment__sessionId",
                table: "Appointment",
                column: "_sessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment__teamId",
                table: "Appointment",
                column: "_teamId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingOrder__appointmentId",
                table: "BookingOrder",
                column: "_appointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingOrder__customerId",
                table: "BookingOrder",
                column: "_customerId");

            migrationBuilder.CreateIndex(
                name: "IX_Budget__operatorId",
                table: "Budget",
                column: "_operatorId");

            migrationBuilder.CreateIndex(
                name: "IX_DayOffRecord__staffID",
                table: "DayOffRecord",
                column: "_staffID");

            migrationBuilder.CreateIndex(
                name: "IX_DefectItemRecord__creatorId",
                table: "DefectItemRecord",
                column: "_creatorId");

            migrationBuilder.CreateIndex(
                name: "IX_DefectItemRecord__operatorId",
                table: "DefectItemRecord",
                column: "_operatorId");

            migrationBuilder.CreateIndex(
                name: "IX_DefectItemRecord__salesOrderId",
                table: "DefectItemRecord",
                column: "_salesOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_DefectItemRecord_SupplierGoodsStock_supplierGoodsId_Supplier~",
                table: "DefectItemRecord",
                columns: new[] { "SupplierGoodsStock_supplierGoodsId", "SupplierGoodsStock_locationId" });

            migrationBuilder.CreateIndex(
                name: "IX_Department__budgetId",
                table: "Department",
                column: "_budgetId");

            migrationBuilder.CreateIndex(
                name: "IX_DisplayItem__goodsId",
                table: "DisplayItem",
                column: "_goodsId");

            migrationBuilder.CreateIndex(
                name: "IX_DisplayItem__locationId",
                table: "DisplayItem",
                column: "_locationId");

            migrationBuilder.CreateIndex(
                name: "IX_DisplayItem__supplierId",
                table: "DisplayItem",
                column: "_supplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Goods__catalogueId",
                table: "Goods",
                column: "_catalogueId");

            migrationBuilder.CreateIndex(
                name: "IX_Message__senderId",
                table: "Message",
                column: "_senderId");

            migrationBuilder.CreateIndex(
                name: "IX_Permission__positionId",
                table: "Permission",
                column: "_positionId");

            migrationBuilder.CreateIndex(
                name: "IX_Position__departmentId",
                table: "Position",
                column: "_departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder__createrId",
                table: "PurchaseOrder",
                column: "_createrId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder__operatorId",
                table: "PurchaseOrder",
                column: "_operatorId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder__warehouseId",
                table: "PurchaseOrder",
                column: "_warehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_Supplier_Goods__supplierGoodsId",
                table: "PurchaseOrder_Supplier_Goods",
                column: "_supplierGoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_RestockRequest__createrId",
                table: "RestockRequest",
                column: "_createrId");

            migrationBuilder.CreateIndex(
                name: "IX_RestockRequest__operatorId",
                table: "RestockRequest",
                column: "_operatorId");

            migrationBuilder.CreateIndex(
                name: "IX_RestockRequest__storeId",
                table: "RestockRequest",
                column: "_storeId");

            migrationBuilder.CreateIndex(
                name: "IX_RestockRequest_Supplier_Goods__supplierGoodsId",
                table: "RestockRequest_Supplier_Goods",
                column: "_supplierGoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_saleOrderItem_Appointment__appointmentId",
                table: "saleOrderItem_Appointment",
                column: "_appointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_saleOrderItem_Appointment__salesOrderItemId",
                table: "saleOrderItem_Appointment",
                column: "_salesOrderItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrder__creatorId",
                table: "SalesOrder",
                column: "_creatorId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrder__operatorId",
                table: "SalesOrder",
                column: "_operatorId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrder__storeId",
                table: "SalesOrder",
                column: "_storeId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderItem__bookingOrderId",
                table: "SalesOrderItem",
                column: "_bookingOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderItem__salesOrderId",
                table: "SalesOrderItem",
                column: "_salesOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderItem__supplierGoodsStockId",
                table: "SalesOrderItem",
                column: "_supplierGoodsStockId");

            migrationBuilder.CreateIndex(
                name: "IX_Session__departmentId",
                table: "Session",
                column: "_departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff__AccountId",
                table: "Staff",
                column: "_AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff__departmentId",
                table: "Staff",
                column: "_departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff__positionId",
                table: "Staff",
                column: "_positionId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff__storeId",
                table: "Staff",
                column: "_storeId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff__teamId",
                table: "Staff",
                column: "_teamId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff__warehouseId",
                table: "Staff",
                column: "_warehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_Message__receiverId",
                table: "Staff_Message",
                column: "_receiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Store__locationID",
                table: "Store",
                column: "_locationID");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_Goods__goodsId",
                table: "Supplier_Goods",
                column: "_goodsId");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_Goods__supplierId",
                table: "Supplier_Goods",
                column: "_supplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_Goods_Stock__locationId",
                table: "Supplier_Goods_Stock",
                column: "_locationId");

            migrationBuilder.CreateIndex(
                name: "IX_Team__departmentId",
                table: "Team",
                column: "_departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction__salesOrderId",
                table: "Transaction",
                column: "_salesOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse__locationID",
                table: "Warehouse",
                column: "_locationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Staff__StaffId",
                table: "Account",
                column: "_StaffId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Department__departmentId",
                table: "Appointment",
                column: "_departmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Session__sessionId",
                table: "Appointment",
                column: "_sessionId",
                principalTable: "Session",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Team__teamId",
                table: "Appointment",
                column: "_teamId",
                principalTable: "Team",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Budget_Staff__operatorId",
                table: "Budget",
                column: "_operatorId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Staff__StaffId",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Budget_Staff__operatorId",
                table: "Budget");

            migrationBuilder.DropTable(
                name: "DayOffRecord");

            migrationBuilder.DropTable(
                name: "DefectItemRecord");

            migrationBuilder.DropTable(
                name: "DisplayItem");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "PurchaseOrder_Supplier_Goods");

            migrationBuilder.DropTable(
                name: "RestockRequest_Supplier_Goods");

            migrationBuilder.DropTable(
                name: "saleOrderItem_Appointment");

            migrationBuilder.DropTable(
                name: "sessionSetting");

            migrationBuilder.DropTable(
                name: "Staff_Message");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropTable(
                name: "RestockRequest");

            migrationBuilder.DropTable(
                name: "SalesOrderItem");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "BookingOrder");

            migrationBuilder.DropTable(
                name: "SalesOrder");

            migrationBuilder.DropTable(
                name: "Supplier_Goods_Stock");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Supplier_Goods");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Catalogue");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Budget");
        }
    }
}
