using AutoMapper;
using KritikalSolutions.EmployeeManagement.Application.Contracts.Persistence;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KritikalSolutions.EmployeeManagement.Application.Features.Employee.Query
{
    public class GetEmployeeListQueryHandler : IRequestHandler<GetEmployeeListQuery, List<EmployeeListVm>>
    {
        private readonly IMapper mapper;
        private readonly IAsyncRepository<KritikalSolutions.EmployeeManagement.Domain.Entities.Employee> employeeRepository;

        public GetEmployeeListQueryHandler(IMapper mapper, IAsyncRepository<KritikalSolutions.EmployeeManagement.Domain.Entities.Employee> employeeRepository)
        {
            this.mapper = mapper;
            this.employeeRepository = employeeRepository;
        }
        public async Task<List<EmployeeListVm>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            var employees = await employeeRepository.ListAllAsync();
            return mapper.Map<List<EmployeeListVm>>(employees);
        }
    }
}
