using Prison_Management_System.Entities;
using Prison_Management_System.Interface;
using Prison_Management_System.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison_Management_System.Services
{
    class EmployeeService
    {
        EmployeeRepo empr;
        IEmployeeRepo<Employee> emp;

        public EmployeeService()
        {
            empr = new EmployeeRepo();
            this.emp = new EmployeeRepo();
        }
        //public int GetByEmpID(string empid)
        //{
        //    return empr.searchEmployee(new Employee() { EmpId = empid });
        //}
        public List<Employee> GetByEmpId(string id)
        {
            var data = emp.searchEmployee(id);
            Employee e = new Employee();
            e.EmpId = data.EmpId;
            e.Name = data.Name;
            e.Designation = data.Designation;
            e.Salary = data.Salary;

            List<Employee> list = new List<Employee>();
            list.Add(e);
            return list;
        }
        public List<Employee> getAllEmployee()
        {
            return emp.GetAll();
        }
        public int insertEmployee(string id, string name, string designation, double salary)
        {
            return empr.insert(new Employee() { EmpId = id, Name = name, Designation = designation, Salary = salary }); ;
        }
        public int deleteEmployee(string id)
        {
            int result = empr.Delete(id);
            return result;
        }
        public int UpdateDetails(string id,string name,string designation,double salary)
        {
            int result = empr.Update(new Employee() { EmpId = id, Name = name, Designation = designation, Salary = salary });
            return result;
        }
    }
}
