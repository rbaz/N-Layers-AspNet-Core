using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PM_Model.Models;

namespace PM_Model.Mapping
{

    // I can't use IEntity TypeConfiguration because is not existing in EF Core
    // I will move all mapping to OnModelCreating(ModelBuilder modelBuilder) fuinction 
    //public class EmployeeMap : IEntityTypeConfiguration<Employee>


    //{
    //    public EmployeeMap()
    //    {
    //        // Table
    //        ToTable("Employee");

    //        // Primary Key
    //        HasKey(t => t.EmployeeId);

    //        //// Properties
    //        Property(t => t.EmployeName);
    //        //IsRequired();
    //        //HasMaxLength(100);

    //        // Column Mappings

    //        Property(t => t.EmployeeId)
    //            .HasColumnName("EmployeeId");

    //        Property(t => t.EmployeName)
    //            .HasColumnName("EmployeName");

    //        Property(t => t.Designation)
    //            .HasColumnName("Designation");

    //        Property(t => t.ManagedId)
    //            .HasColumnName("ManagedId");

    //        Property(t => t.ContactNum)
    //            .HasColumnName("ContactNum");

    //        Property(t => t.EmailId)
    //            .HasColumnName("EmailId");

    //    }
    //}
}
