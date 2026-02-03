using CorpBase.Data;
using CorpBase.Business;
using CorpBase.Common.Interfaces;
using CorpBase.Data.Repositories;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CorpBase.WinUI
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            var host = Host.CreateDefaultBuilder(args).ConfigureServices((context, services) =>
            {
                var connectionString = context.Configuration.GetConnectionString("CorpBaseDb");
                
                // Register 
                services.AddDbContext<CorpBaseDbContext>(options =>
                    options.UseSqlServer(connectionString));

                services.AddScoped<IEmployeeRepository, EmployeeRepository>();
                services.AddScoped<IEmployeeEfRepository, EmployeeEfRepository>();

                services.AddScoped<EmployeeService>();
                services.AddScoped<EmployeeEfService>();

                services.AddScoped<IDepartmentEfRepository, DepartmentEfRepository>();
                services.AddScoped<IDepartmentRepository, DepartmentRepository>();

                services.AddScoped<DepartmentService>();
                services.AddScoped<DepartmentEfService>();

                //Register Forms
                services.AddScoped<EmployeesForm>();


            }).Build();

            using var scope = host.Services.CreateScope();

            Application.Run(scope.ServiceProvider.GetRequiredService<EmployeesForm>());
        }
    }
}
