using KritikalSolutions.EmployeeManagement.Domain.Entities;

namespace KritikalSolutions.EmployeeManagement.Application.Contracts.Persistence
{
    public interface IEmployeeRepository : IAsyncRepository<Employee>
    {
    }
}
