using AutoMapper;
using KritikalSolutions.EmployeeManagement.Application.Features.Employee.Query;
using KritikalSolutions.EmployeeManagement.Domain.Entities;

namespace KritikalSolutions.EmployeeManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeListVm>().ReverseMap();
        }
    }
}
