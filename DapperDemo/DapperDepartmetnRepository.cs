using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo
{
    public class DapperDepartmetnRepository : IDepartmentRepository
    {
        private readonly IDbConnection _connection;  // IDB connection to query
        //Constructor  so no one else can change it
        public DapperDepartmetnRepository(IDbConnection connection)// field
        {
            _connection = connection;
        }
        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("SELECT * FROM Departments;");
        }

        public void InsertDepartment(string newDepartmentName)
        {
            _connection.Execute("INSERT INTO DEPARTMENTS (Name) VALUES (@departmentName);",
         new { departmentName = newDepartmentName });// new   connects parameter to value name  departmentName
        }
    }
}
