using KritikalSolutions.EmployeeManagement.Application.Contracts.Persistence;
using KritikalSolutions.EmployeeManagement.Domain.Entities;

namespace KritikalSolutions.EmployeeManagement.Persistence.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        private readonly EmployeeManagementDbContext dbContext;

        public EmployeeRepository(EmployeeManagementDbContext dbContext) :
            base(dbContext)
        {
            this.dbContext = dbContext;
        }

    }
}
