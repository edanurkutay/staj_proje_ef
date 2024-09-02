using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace staj_proje_ef.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"
                CREATE VIEW vm_StaffInfo
                AS
                SELECT staffId AS 'PersonelNo',staffname AS 'Ad',staffsurname AS 'Soyad', unitname AS 'Birim', rolename AS 'Rol',jobname AS 'İş', address AS 'Adres', stafftel AS 'Tel', stafftc AS 'TC'
                FROM staffs s inner join jobs j ON s.jobId = j.jobId  
                              inner join units u ON  s.unitId =u.unitId
                              inner join roles r On s.roleId = r.roleId
                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"DROP VIEW vm_StaffInfo");

        }
    }
}
