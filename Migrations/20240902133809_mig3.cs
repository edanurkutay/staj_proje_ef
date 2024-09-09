using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace staj_proje_ef.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"
                CREATE VIEW vm_CustomerInfo
                AS
                SELECT customerId AS 'MüşteriNo',customername AS 'Ad',customersurname AS 'Soyad',customerstate AS KayıtDurumu, unitname AS 'KayıtBirimi',s.staffId AS 'PersonelNo', staffname AS 'PersonelAd',staffsurname AS 'PersonelSoyad',  email AS 'Mail' ,customertel AS 'Tel', customertc AS 'TC'
                FROM customers c inner join units u ON c.unitId = u.unitId 
                inner join staffs s ON  c.staffId =s.staffId
                   
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"DROP VIEW vm_CustomerInfo");

        }
    }
}