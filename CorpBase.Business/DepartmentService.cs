using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorpBase.Common;
using CorpBase.Common.Interfaces;

namespace CorpBase.Business
{
    public class DepartmentService
    {
        private readonly IDepartmentRepository _deptRepo;
        public DepartmentService(IDepartmentRepository deptRepo)
        {
            _deptRepo = deptRepo;
        }
        
        public List<Department> GetDepartments() => _deptRepo.GetAll();
        public DataTable GetDepartmentsAsTable() => _deptRepo.GetDepartmentsAsTable();
        
        public void InsertDepartment(Department dept)
        {
            _deptRepo.Insert(dept);
        }
        public void UpdateDepartment(Department dept) {
            _deptRepo.Update(dept);
        }

        private void Validate(Department dept)
        {
            if (string.IsNullOrEmpty(dept.DeptName))
                throw new Exception("Department name is required.");
            if (dept.DeptName.Length <= 2)
                throw new Exception("Department name should be longer.");
        }
    }
}
