using CorpBase.Business;
using CorpBase.Common.Interfaces;
using CorpBase.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CorpBase.WinUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            // Register dependencies
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<EmployeeService>();

            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<DepartmentService>();

            // Register Forms
            services.AddScoped<EmployeesForm>();

            using var provider = services.BuildServiceProvider();

            var mainForm = provider.GetRequiredService<EmployeesForm>();

            Application.Run(mainForm);
        }
    }
}
