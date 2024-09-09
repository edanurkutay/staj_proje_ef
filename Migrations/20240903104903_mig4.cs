using Microsoft.EntityFrameworkCore.Migrations;
using staj_proje_ef.classes;
using static System.ComponentModel.Design.ObjectSelectorEditor;

#nullable disable

namespace staj_proje_ef.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"
                CREATE VIEW vm_JobInfo
                AS
                SELECT jobname, u.unitId,jobId FROM jobs j inner join units u ON j.unitId = u.unitId");
                
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"DROP VIEW vm_JobInfo");

        }
    }
}
