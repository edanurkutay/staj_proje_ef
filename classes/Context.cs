using Microsoft.EntityFrameworkCore;
using staj_proje_ef.classes;

public class CompanySystemContext : DbContext
{

    public DbSet<Customer> customers { get; set; }
    public DbSet<Staff> staffs { get; set; }
    public DbSet<Unit> units { get; set; }
    public DbSet<Role> roles { get; set; }
    public DbSet<Job> jobs { get; set; }
    public DbSet<StaffInfo> staffInfos { get; set; }
    public DbSet<CustomerInfo> customerInfos { get; set; }
    public DbSet<JobInfo> jobInfos { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=EDANUR;Database=ECompanyDB;TrustServerCertificate=true;Integrated Security=true;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StaffInfo>()
            .ToView("vm_StaffInfo")
            .HasNoKey();
        modelBuilder.Entity<CustomerInfo>()
          .ToView("vm_CustomerInfo")
          .HasNoKey();
        modelBuilder.Entity<JobInfo>()
            .ToView("vm_JobInfo")
            .HasNoKey();
    }



    //OnConfiguring EF core tool u yapılandırmak için kullanılır context nesnesinde override edilerek kullanılır.
    //Tool a dair davranış  modellemsi çizmemizi sağlayan yapılandırmalar 

}





