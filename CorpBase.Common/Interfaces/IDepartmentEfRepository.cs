using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorpBase.Common.Interfaces
{
    public interface IDepartmentEfRepository
    {
        List<Department> GetAll();
        List<Department> Search(string keyword);

        void Insert(Department dept);
        void Update(Department dept);
        void Delete(int Id);

    }
}
