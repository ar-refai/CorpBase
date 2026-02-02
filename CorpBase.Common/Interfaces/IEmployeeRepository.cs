using System;
using System.Data;
using Microsoft.Data.SqlClient;

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

    void Insert(Employee emp, SqlConnection con, SqlTransaction tx);
}
