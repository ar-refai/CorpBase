using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorpBase.Common;
using CorpBase.Common.Interfaces;
using CorpBase.Data.DataAccess;

namespace CorpBase.Business
{
    public class CompanyService
    {
        private readonly IDepartmentRepository _deptRepo;
        private readonly IEmployeeRepository _empRepo;
        public CompanyService(IDepartmentRepository deptRepo,IEmployeeRepository empRepo)
        {
            _deptRepo = deptRepo;
            _empRepo = empRepo;
        }

        // transaction operation (Department => Employees)
        public void CreateDepartmentWithEmployees(Department dept, List<Employee> emps)
        {
            using var con = DbConnectionFactory.Create();
        using var tx = con.BeginTransaction();
            // Continue coding .. not done yey .. bye ..
            try
            {
                // add emp
                int deptId = _deptRepo.Insert(dept,con,tx);
                foreach(Employee emp in emps)
                {
                    emp.DepartmentId = deptId;
                    _empRepo.Insert(emp, con, tx);
                }
                // commit changes 
                tx.Commit();
                
                // commit 
            }catch(Exception ex)
            {
                tx.Rollback();
                throw;
            }
        }
    }
}
