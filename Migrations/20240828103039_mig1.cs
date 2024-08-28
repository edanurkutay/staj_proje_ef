using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace staj_proje_ef.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    roleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rolename = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.roleId);
                });

            migrationBuilder.CreateTable(
                name: "units",
                columns: table => new
                {
                    unitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    unitname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_units", x => x.unitId);
                });

            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    jobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jobname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    unitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobs", x => x.jobId);
                    table.ForeignKey(
                        name: "FK_jobs_units_unitId",
                        column: x => x.unitId,
                        principalTable: "units",
                        principalColumn: "unitId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "staffs",
                columns: table => new
                {
                    staffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    staffname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    staffsurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stafftel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stafftc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    unitId = table.Column<int>(type: "int", nullable: false),
                    jobId = table.Column<int>(type: "int", nullable: false),
                    roleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffs", x => x.staffId);
                    table.ForeignKey(
                        name: "FK_staffs_jobs_jobId",
                        column: x => x.jobId,
                        principalTable: "jobs",
                        principalColumn: "jobId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_staffs_roles_roleId",
                        column: x => x.roleId,
                        principalTable: "roles",
                        principalColumn: "roleId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_staffs_units_unitId",
                        column: x => x.unitId,
                        principalTable: "units",
                        principalColumn: "unitId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    customerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customersurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customertel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerstate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    staffId = table.Column<int>(type: "int", nullable: false),
                    unitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.customerId);
                    table.ForeignKey(
                        name: "FK_customers_staffs_staffId",
                        column: x => x.staffId,
                        principalTable: "staffs",
                        principalColumn: "staffId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_customers_units_unitId",
                        column: x => x.unitId,
                        principalTable: "units",
                        principalColumn: "unitId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customers_staffId",
                table: "customers",
                column: "staffId");

            migrationBuilder.CreateIndex(
                name: "IX_customers_unitId",
                table: "customers",
                column: "unitId");

            migrationBuilder.CreateIndex(
                name: "IX_jobs_unitId",
                table: "jobs",
                column: "unitId");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_jobId",
                table: "staffs",
                column: "jobId");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_roleId",
                table: "staffs",
                column: "roleId");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_unitId",
                table: "staffs",
                column: "unitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "staffs");

            migrationBuilder.DropTable(
                name: "jobs");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "units");
        }
    }
}
