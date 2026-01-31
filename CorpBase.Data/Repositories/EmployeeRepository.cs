using System.Data;
using CorpBase.Common;
using CorpBase.Common.Interfaces;
using CorpBase.Data.DataAccess;
using Microsoft.Data.SqlClient;

namespace CorpBase.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        // get all employees in connected mode
        public List<Employee> GetAll()
        {
            var emps = new List<Employee>();
            using SqlConnection con = DbConnectionFactory.Create();
            using SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT e.Id, e.FullName, e.JobTitle, e.Salary, e.IsActive, e.DepartmentId From Employees e";
            cmd.Connection = con;
            con.Open();

            // excute the command 
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var emp = new Employee()
                {
                    Id = (int)reader["Id"],
                    FullName= (string)reader["FullName"],
                    JobTitle = (string)reader["JobTitle"],
                    Salary = (decimal)reader["Salary"],
                    IsActive = (bool)reader["IsActive"],
                    DepartmentId = (int)reader["DepartmentId"]
                };
                emps.Add(emp);
            }
            return emps;
            
        }
        
        // get all employees in disconnected mode
        public DataTable GetAllAsTable(bool isActive)
        {
            using var con = DbConnectionFactory.Create();
            using var cmd = new SqlCommand
            {
                Connection = con,
                CommandText = "SELECT e.Id, e.FullName, e.JobTitle, e.Salary, e.IsActive, e.DepartmentId " +
                "FROM Employees e INNER JOIN Departments d ON e.DepartmentId = d.Id " +
                "WHERE e.IsActive = @isActive"
            };
            cmd.Parameters.Add("@isActive", SqlDbType.Bit).Value = isActive;

            var dt = new DataTable();
            using var da = new SqlDataAdapter(cmd);
            // SqlDataAdapter.Fill will open the connection if it's closed, then close it when done.
            da.Fill(dt);
            return dt;
        }
   
        // insert an employee
        public void Insert(Employee em)
        {
            using var con = DbConnectionFactory.Create();
            using var cmd = con.CreateCommand();
            
            cmd.CommandText = @"INSERT INTO Employees (FullName, JobTitle, Salary, IsActive, DepartmentId) VALUES (@FullName, @JobTitle, @Salary, @IsActive, @DepartmentId)";

            cmd.Parameters.AddWithValue("@FullName",em.FullName);
            cmd.Parameters.AddWithValue("@JobTitle",em.JobTitle ?? "");
            cmd.Parameters.AddWithValue("@Salary",em.Salary);
            cmd.Parameters.AddWithValue("@IsActive",em.IsActive);
            cmd.Parameters.AddWithValue("@DepartmentId",em.DepartmentId);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        // update an employee
        public void Update(Employee em)
        {
            using var con = DbConnectionFactory.Create();
            using var cmd = con.CreateCommand();
            
            cmd.CommandText = @"
                                UPDATE Employees 
                                SET FullName= @FullName, JobTitle= @JobTitle, Salary= @Salary, IsActive= @IsActive, DepartmentId= @DepartmentId 
                                WHERE Id = @Id";
            
            cmd.Parameters.AddWithValue("@Id", em.Id);
            cmd.Parameters.AddWithValue("@FullName", em.FullName);
            cmd.Parameters.AddWithValue("@JobTitle", em.JobTitle ?? "");
            cmd.Parameters.AddWithValue("@Salary", em.Salary);
            cmd.Parameters.AddWithValue("@IsActive", em.IsActive);
            cmd.Parameters.AddWithValue("@DepartmentId", em.DepartmentId);
            
            con.Open();
            int affected = cmd.ExecuteNonQuery();
            if (affected == 0) throw new Exception("Update Failed!");
        }

        // delete an employee
        public void Delete(int Id)
        {
            using var con = DbConnectionFactory.Create();
            using var cmd = con.CreateCommand();
            cmd.CommandText = @"Delete From Employees Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            int affected = cmd.ExecuteNonQuery();
            if (affected == 0) throw new Exception("Nothing is deleted!");
        }

        // search for an employee
        public List<Employee> Search(string keyword)
        {
            throw new Exception();
        }

    }
}