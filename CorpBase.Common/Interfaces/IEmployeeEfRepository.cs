using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorpBase.Common.Interfaces
{
    public interface IEmployeeEfRepository
    {
        List<Employee> GetAll();
        List<Employee> Search(string keyword);

        void Insert(Employee employee);
        void Update(Employee employee);
        void Delete(int Id);
    }
}
