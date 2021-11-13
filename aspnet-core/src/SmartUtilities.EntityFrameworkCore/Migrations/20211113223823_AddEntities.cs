using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartUtilities.Migrations
{
    public partial class AddEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "AbpUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityNo",
                table: "AbpUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AppCitizenProperties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ErfNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Consumption = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCitizenProperties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CitizenPropertyUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyOwnerId = table.Column<long>(type: "bigint", nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitizenPropertyUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CitizenPropertyUser_AbpUsers_PropertyOwnerId",
                        column: x => x.PropertyOwnerId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CitizenPropertyUser_AppCitizenProperties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "AppCitizenProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SmartMeter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeterNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeterModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeterSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceType = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmartMeter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SmartMeter_AppCitizenProperties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "AppCitizenProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppPowerPlants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<double>(type: "float", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPowerPlants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppElectricityUsage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeterNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitizenPropertyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Consumption = table.Column<int>(type: "int", nullable: false),
                    PowerPlantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppElectricityUsage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppElectricityUsage_AppCitizenProperties_CitizenPropertyId",
                        column: x => x.CitizenPropertyId,
                        principalTable: "AppCitizenProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppElectricityUsage_AppPowerPlants_PowerPlantId",
                        column: x => x.PowerPlantId,
                        principalTable: "AppPowerPlants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppSuppliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyRegUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyRegPublicId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyTaxUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyTaxPublicId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyProfileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyProfilePublicId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyBbbeeUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyBbbeePublicId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CsdReportUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CsdReportPublicId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegNumber = table.Column<int>(type: "int", nullable: false),
                    DirectLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSuppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppReservoirs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResourceCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResourceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResourceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<double>(type: "float", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppReservoirs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppReservoirs_AppSuppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "AppSuppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppResources",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResourceCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResourceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResourceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<double>(type: "float", nullable: true),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppResources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppResources_AppSuppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "AppSuppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppWards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardNo = table.Column<int>(type: "int", nullable: false),
                    ReservoirId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PowerPlantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceRate = table.Column<double>(type: "float", nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppWards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppWards_AppPowerPlants_PowerPlantId",
                        column: x => x.PowerPlantId,
                        principalTable: "AppPowerPlants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppWards_AppReservoirs_ReservoirId",
                        column: x => x.ReservoirId,
                        principalTable: "AppReservoirs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppAddress",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Line1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Line2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppAddress_AppWards_WardId",
                        column: x => x.WardId,
                        principalTable: "AppWards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_AddressId",
                table: "AbpUsers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_AppAddress_WardId",
                table: "AppAddress",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCitizenProperties_AddressId",
                table: "AppCitizenProperties",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCitizenProperties_WardId",
                table: "AppCitizenProperties",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_AppElectricityUsage_CitizenPropertyId",
                table: "AppElectricityUsage",
                column: "CitizenPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_AppElectricityUsage_PowerPlantId",
                table: "AppElectricityUsage",
                column: "PowerPlantId");

            migrationBuilder.CreateIndex(
                name: "IX_AppPowerPlants_AddressId",
                table: "AppPowerPlants",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_AppPowerPlants_SupplierId",
                table: "AppPowerPlants",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReservoirs_SupplierId",
                table: "AppReservoirs",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_AppResources_SupplierId",
                table: "AppResources",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_AppSuppliers_AddressId",
                table: "AppSuppliers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_AppWards_PowerPlantId",
                table: "AppWards",
                column: "PowerPlantId");

            migrationBuilder.CreateIndex(
                name: "IX_AppWards_ReservoirId",
                table: "AppWards",
                column: "ReservoirId");

            migrationBuilder.CreateIndex(
                name: "IX_CitizenPropertyUser_PropertyId",
                table: "CitizenPropertyUser",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_CitizenPropertyUser_PropertyOwnerId",
                table: "CitizenPropertyUser",
                column: "PropertyOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_SmartMeter_PropertyId",
                table: "SmartMeter",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_AppAddress_AddressId",
                table: "AbpUsers",
                column: "AddressId",
                principalTable: "AppAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AppCitizenProperties_AppAddress_AddressId",
                table: "AppCitizenProperties",
                column: "AddressId",
                principalTable: "AppAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AppCitizenProperties_AppWards_WardId",
                table: "AppCitizenProperties",
                column: "WardId",
                principalTable: "AppWards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppPowerPlants_AppAddress_AddressId",
                table: "AppPowerPlants",
                column: "AddressId",
                principalTable: "AppAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppPowerPlants_AppSuppliers_SupplierId",
                table: "AppPowerPlants",
                column: "SupplierId",
                principalTable: "AppSuppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppSuppliers_AppAddress_AddressId",
                table: "AppSuppliers",
                column: "AddressId",
                principalTable: "AppAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_AppAddress_AddressId",
                table: "AbpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AppAddress_AppWards_WardId",
                table: "AppAddress");

            migrationBuilder.DropTable(
                name: "AppElectricityUsage");

            migrationBuilder.DropTable(
                name: "AppResources");

            migrationBuilder.DropTable(
                name: "CitizenPropertyUser");

            migrationBuilder.DropTable(
                name: "SmartMeter");

            migrationBuilder.DropTable(
                name: "AppCitizenProperties");

            migrationBuilder.DropTable(
                name: "AppWards");

            migrationBuilder.DropTable(
                name: "AppPowerPlants");

            migrationBuilder.DropTable(
                name: "AppReservoirs");

            migrationBuilder.DropTable(
                name: "AppSuppliers");

            migrationBuilder.DropTable(
                name: "AppAddress");

            migrationBuilder.DropIndex(
                name: "IX_AbpUsers_AddressId",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "IdentityNo",
                table: "AbpUsers");
        }
    }
}
