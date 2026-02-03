using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorpBase.Common;
using CorpBase.Common.Interfaces;

namespace CorpBase.Data.Repositories
{
    public class DepartmentEfRepository : IDepartmentEfRepository
    {
        private readonly CorpBaseDbContext context;
        public DepartmentEfRepository(CorpBaseDbContext context)
        {
            this.context = context;
        }

        public List<Department> GetAll() => context.Departments.ToList();

        public List<Department> Search(string keyword) => context.Departments.Where(d => d.DeptName.Contains(keyword)).ToList();

        public void Insert(Department dept)
        {
            context.Departments.Add(dept);
            context.SaveChanges();
        }

        public void Update(Department dept)
        {
            context.Departments.Update(dept);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            if (Id <= 0) throw new ArgumentException("Id Must Be Valid!");
            var dept = context.Departments.Find(Id);
            if (dept == null) return;
            context.Departments.Remove(dept);
            context.SaveChanges();
        }

    }
}
