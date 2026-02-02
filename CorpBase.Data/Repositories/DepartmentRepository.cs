using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorpBase.Common;
using CorpBase.Common.Interfaces;
using CorpBase.Data.DataAccess;
using Microsoft.Data.SqlClient;
namespace CorpBase.Data.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public List<Department> GetAll()
        {
            // Define A List
            var departmentList = new List<Department>();
            // Define DB Connection
            using var con = DbConnectionFactory.Create();
            // Create Command Through Connection
            using var cmd = con.CreateCommand();
            cmd.CommandText = @"
                SELECT 
                    d.Id,
                    d.DeptName,
                    d.Location
                FROM Departments d";
            cmd.Connection = con;
            con.Open();
            // Define Sql DataReader Using Command
            using SqlDataReader reader = cmd.ExecuteReader();
            // Loop Over Using The Reader & Fill The List
            while (reader.Read())
            {
                departmentList.Add(new Department()
                {
                    Id = (int)reader["Id"],
                    DeptName = (string)reader["DeptName"],
                    //Location = (string)reader["Location"] ?? "" // Error
                    Location = reader["Location"] == DBNull.Value ? "" : reader["Location"].ToString()
                });
            }
            // Return The List
            return departmentList;            
        }

        public DataTable GetDepartmentsAsTable()
        {
            // Define A DataTable
            DataTable dt = new DataTable();
            
            // Define The Connection
            using var con = DbConnectionFactory.Create();

            // Define The Command 
            using var cmd = con.CreateCommand();
            cmd.CommandText = @"
                SELECT 
                    d.Id,
                    d.DeptName,
                    d.Location
                FROM Departments d";
            cmd.Connection = con;
            
            // Define A SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // The SqlDataAdapter Fills The DataTable
            da.Fill(dt);
            
            return dt;
        }

        public void Insert(Department dept)
        {
            using var con = DbConnectionFactory.Create();
            using var cmd = con.CreateCommand();
            cmd.CommandText = @"Insert Into Departments (DeptName, Location) Values (@DeptName, @Location)";
            cmd.Parameters.AddWithValue("@DeptName", dept.DeptName);
            cmd.Parameters.AddWithValue("@Location", string.IsNullOrEmpty(dept.Location) ? DBNull.Value : dept.Location);
            cmd.ExecuteNonQuery();  // This is for insert, update and delete (e.g DML 
        }

        public void Update(Department dept)
        {
            using var con = DbConnectionFactory.Create();
            using var cmd = con.CreateCommand();


            cmd.CommandText = @"Update Departments Set DeptName=@DeptName , Location= @Location Where Id = @Id";
            
            cmd.Parameters.AddWithValue("@Id", dept.Id);
            cmd.Parameters.AddWithValue("@DeptName", dept.DeptName);
            cmd.Parameters.AddWithValue("@Location", string.IsNullOrEmpty(dept.Location) ? DBNull.Value : dept.Location);

            cmd.ExecuteNonQuery();
        }

        // transaction operation
        public int Insert(Department dept, SqlConnection con, SqlTransaction tx) 
        {
            using var cmd = con.CreateCommand();
            cmd.Transaction = tx;
            cmd.CommandText = @"Insert Into Departments (DeptName, Location) Values (@Name,@Location); Select SCOPE_IDENTITY(); ";
            // SCOPE_IDENTITY() returns the new PK safley
            cmd.Parameters.AddWithValue("@Name" , dept.DeptName);
            cmd.Parameters.AddWithValue("@Location",dept.Location);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
