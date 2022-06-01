using MediatR;
using System.Collections.Generic;

namespace KritikalSolutions.EmployeeManagement.Application.Features.Employee.Query
{
    public class GetEmployeeListQuery : IRequest<List<EmployeeListVm>>
    {
    }
}
