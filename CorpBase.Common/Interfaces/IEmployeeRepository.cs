using System;
using System.Data;

namespace CorpBase.Common.Interfaces;

public interface IEmployeeRepository
{
    List<Employee> GetAll();                    // connected mode
    DataTable GetAllAsTable(bool isActive);     // disconnected mode
    List<Employee> Search(string keyword);      // 

    void Insert(Employee employee);
    void Update(Employee employee);
    void Delete(int Id);
}
