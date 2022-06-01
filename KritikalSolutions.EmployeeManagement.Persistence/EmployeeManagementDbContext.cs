using KritikalSolutions.EmployeeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace KritikalSolutions.EmployeeManagement.Persistence
{
    public class EmployeeManagementDbContext : DbContext
    {
        public EmployeeManagementDbContext(DbContextOptions<EmployeeManagementDbContext> options)
           : base(options)
        {

        }

        public DbSet<Employee> Employee { get; set; }
    }
}
