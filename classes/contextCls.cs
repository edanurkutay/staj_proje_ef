using Microsoft.EntityFrameworkCore;


public class CompanySystemContext : DbContext
{


}


public class Staff
{
    public int staffID { get; set; }
    public string? staffName { get; set; }
    public string? staffSurname { get; set; }
    public int unitID {  get; set; } // unit tablosundan gelen FK 
    public int roleID { get; set; } // role tablosundan gelen FK 
    public int jobID {  get; set; } // job tablosundan gelen FK 
    public int stafftel {  get; set; }
    public int TC { get; set; }
    public string? Address { get; set; }
    public string? username {  get; set; }
    public string? password { get; set; }
    public Unit Unit { get; set; }
    public Job Job { get; set; }
    public Role Role  { get; set; }

}

public class Customer
{
    public int customerID { get; set; }
    public string? customerName { get; set; }
    public string? customerSurname { get; set; }
    public string? customerState { get; set; }
    public string? Email { get; set; }
    public string? customerTel { get; set; }
    public int staffID { get; set; } // staff tablosundan gelen FK
    public int unitID { get; set; } // unit tablosundan gelen FK


}

public class Unit
{
    public int unitID { get; set; }
    public string? unitName { get; set; }
    public int staffID { get; set; } // staff tablosundan gelen FK birim yöneticileri
    public ICollection<Staff> Staffs { get; set; }
    public ICollection<Job> Jobs { get; set; }

}

public class Job
{
    public int jobID { get; set;}
    public string? JobName { get; set; }
    public int unitID { get; set; } // unit tablosundan gelen FK
    public Unit Unit { get; set; }
}

public class Role
{

}