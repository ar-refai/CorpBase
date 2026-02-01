using System;
using System.Data;
using System.Diagnostics;
using System.Net.Http.Headers;
using CorpBase.Common;
using CorpBase.Common.Interfaces;

namespace CorpBase.Business;

public class EmployeeService
{
    private readonly IEmployeeRepository _repo;
    public EmployeeService(IEmployeeRepository _repo)
    {
        this._repo = _repo;
    } 

    // get all employeese (connected mode)
    public List<Employee> GetEmployees(bool isActive) => _repo.GetAll().Where(e => e.IsActive == isActive).ToList();


    // get all employees (disconnected mode) ready for editting 
    public DataTable GetEmployeesAsTable(bool isActive) => _repo.GetAllAsTable(isActive);

    // save employees table (disconected service)
    public void SaveEmployeesTable(DataTable table) => _repo.SaveEmployeesTable(table);

    // search employees
    public List<Employee> SearchEmployees(string keyword) => _repo.Search(keyword);

    // insert an employee
    public void Create(Employee employee)
    {
        Validate(employee);
        _repo.Insert(employee);
    }

    // update an employee
    public void Update(Employee employee)
    {
        if (employee.Id <= 0) throw new Exception("Employee Id Should be >= 1");
        Validate(employee);
        _repo.Update(employee);
    }

    // delete an employee
    public void Delete(int Id) 
    {
        if (Id <= 0) throw new ArgumentException("Employee Id Must Be Greater Than 0");
        _repo.Delete(Id);
    }

    // search for a keyword in fullname and jobtitle
    public List<Employee> Search(string keyword) 
    {
        if (string.IsNullOrEmpty(keyword)) return _repo.GetAll();
        return _repo.Search(keyword); 
    }
    
    // validate the inputs
    private void Validate(Employee em)
    {
        if (string.IsNullOrEmpty(em.FullName))
            throw new Exception("");
        if (em.Salary <= 0)
            throw new Exception("");
        
    }



}
