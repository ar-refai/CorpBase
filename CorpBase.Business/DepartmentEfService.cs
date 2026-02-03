using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorpBase.Common;
using CorpBase.Common.Interfaces;
using Microsoft.Extensions.Options;

namespace CorpBase.Business
{
    public class DepartmentEfService
    {
        private readonly IDepartmentEfRepository repo;
        public DepartmentEfService(IDepartmentEfRepository repo)
        {
            this.repo = repo;
        }

        public List<Department> GetAll() => repo.GetAll();
        public List<Department> Search(string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
                repo.GetAll();
            return repo.Search(keyword);
        }

        public void Insert (Department dept)
        {
            if (string.IsNullOrEmpty(dept.DeptName)) throw new Exception($"Not a valid department name : {dept.DeptName}");
            repo.Insert(dept);
        }

        public void Update (Department dept)
        {
            Validate(dept);
            repo.Update(dept);

        }

        public void Delete(int Id)
        {
            if (Id <= 0) throw new ArgumentException($"Id {Id} is not a valid Id");
            repo.Delete(Id);
        }

        private static void Validate(Department dept)
        {
            if (dept.Id <= 0) throw new Exception("Department must has a valid Id");
            if (string.IsNullOrEmpty(dept.DeptName)) throw new Exception("Department must have a valid Name");
        }
    }
}
