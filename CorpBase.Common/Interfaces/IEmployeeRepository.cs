using System;
using System.Data;

namespace CorpBase.Common.Interfaces;

public interface IEmployeeRepository
{
    List<Employee> GetAll();                    // connected mode
    DataTable GetAllAsTable(bool isActive);     // disconnected mode
    void SaveEmployeesTable(DataTable table);
    List<Employee> Search(string keyword);      // Filter FullName and JobTitle

    void Insert(Employee employee);
    void Update(Employee employee);
    void Delete(int Id);
}
