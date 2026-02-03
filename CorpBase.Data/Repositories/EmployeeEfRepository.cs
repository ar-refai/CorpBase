using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorpBase.Common;
using CorpBase.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CorpBase.Data.Repositories
{
    public class EmployeeEfRepository : IEmployeeEfRepository
    {
        private readonly CorpBaseDbContext context;
        public EmployeeEfRepository(CorpBaseDbContext context)
        {
            this.context = context;
        }

        public List<Employee> GetAll() => context.Employees.ToList();
        


        public List<Employee> Search(string keyword) => context.Employees.Where(e => (e.FullName.Contains(keyword) || e.JobTitle.Contains(keyword)) && e.IsActive).ToList();
        

        public void Insert(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            context.Employees.Update(employee);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            if (Id <= 0) throw new ArgumentException("Id must be valid;");
            var emp = context.Employees.Find(Id);
            if (emp == null)
                return;
            emp.IsActive = false;
            context.SaveChanges();
        }
    }
}
