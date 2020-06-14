using Microsoft.EntityFrameworkCore;
using PM_Model.Models;

namespace PM_Model
{
    public class PMContext : DbContext
    {
        public DbSet<Employee> Contacts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // when used https://docs.microsoft.com/en-us/ef/core/modeling/entity-types?tabs=data-annotations
            //modelBuilder.HasDefaultSchema("PMSchema");             
        }
    }

}