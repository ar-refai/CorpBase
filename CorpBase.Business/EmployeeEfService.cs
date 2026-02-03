using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorpBase.Common;
using CorpBase.Common.Interfaces;

namespace CorpBase.Business
{
    public class EmployeeEfService
    {
        private readonly IEmployeeEfRepository repo;
        public EmployeeEfService(IEmployeeEfRepository repo)
        {
            this.repo = repo;
        }
    
        public List<Employee> GetAll() => repo.GetAll();
        public List<Employee> Search(string keyword)
        {
            if (string.IsNullOrEmpty(keyword)) return repo.GetAll();
            return repo.Search(keyword);
        }

        public void Insert(Employee employee)
        {
            Validate(employee);
            repo.Insert(employee);
        }

        public void Update(Employee employee)
        {
            if (employee.Id <= 0) throw new Exception($"Id : {employee.Id} is not valid!");
            Validate(employee);
            repo.Update(employee);
        }

        public void Delete(int Id)
        {
            if (Id <= 0) throw new ArgumentException("Id is not valid for deleting!");
            repo.Delete(Id);
        }

        private static void Validate(Employee emp)
        {
            if (emp.Salary <= 0) throw new Exception("Salary should be a valid positive number.");
            if (string.IsNullOrEmpty(emp.FullName)) throw new Exception("Employee name is not valid!");
        }
    
    }
}
