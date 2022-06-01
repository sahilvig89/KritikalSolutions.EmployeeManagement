using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using KritikalSolutions.EmployeeManagement.Application.Contracts.Persistence;
using KritikalSolutions.EmployeeManagement.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KritikalSolutions.EmployeeManagement.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EmployeeManagementDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("EmployeeManagementConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            return services;
        }
    }
}
