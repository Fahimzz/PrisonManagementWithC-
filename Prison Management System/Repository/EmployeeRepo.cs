using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Prison_Management_System.Entities;
using Prison_Management_System.Interface;

namespace Prison_Management_System.Repository
{
    class EmployeeRepo:IEmployeeRepo<Employee>
    {
        DataAccess dbc;
        public  EmployeeRepo()
        {
            //dbc = new DataAccess();
        }
		public Employee searchEmployee(string empId)
		{
            dbc = new DataAccess();
			string query = "SELECT * FROM Employees WHERE empId='" + empId + "'";
			SqlDataReader reader = dbc.GetData(query);
			reader.Read();
			Employee emp = new Employee();
			emp.EmpId = reader["empId"].ToString();
			emp.Name= reader["employeeName"].ToString();
			emp.Designation= reader["designation"].ToString();
			emp.Salary= Convert.ToDouble(reader["salary"]);
            dbc.Dispose();

            return emp;
		}
        public List<Employee> GetAll()
        {
            dbc = new DataAccess();
            string sql = "SELECT * FROM Employees";
            SqlDataReader reader = dbc.GetData(sql);
            List<Employee> homelist = new List<Employee>();
            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.EmpId = reader["empId"].ToString();
                emp.Name = reader["employeeName"].ToString();
                emp.Designation = reader["designation"].ToString();
                emp.Salary = Convert.ToDouble(reader["salary"]);

                homelist.Add(emp);
            }
            dbc.Dispose();
            
            return homelist;
        }
        public int insert(Employee employee)
        {
            dbc = new DataAccess();
            string sql = "INSERT INTO Employees(empId,employeeName,designation,salary) VALUES('" + employee.EmpId + "','" + employee.Name + "','" + employee.Designation + "'," +employee.Salary + ")";
            int result = dbc.ExecuteQuery(sql);
            if (result > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        public int Delete(string id)
        {
            dbc = new DataAccess();
            string sql = "DELETE FROM Employees WHERE empId='" + id + "'";
            int result = dbc.ExecuteQuery(sql);
            dbc.Dispose();
            return result;
        }
        public int Update(Employee employee)
        {
            dbc = new DataAccess();
            string sql = "UPDATE employees SET employeeName='" + employee.Name + "', designation = '" + employee.Designation + "', salary = " + employee.Salary + " WHERE empId='" + employee.EmpId + "'";
            int result = dbc.ExecuteQuery(sql);
            return result;
        }

    }
}
