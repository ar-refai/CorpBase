using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorpBase.Common.Interfaces
{
    public interface IDepartmentRepository
    {
        List<Department> GetAll();
        DataTable GetDepartmentsAsTable();

        void Insert(Department dept);
        void Update(Department dept); 
    }
}
