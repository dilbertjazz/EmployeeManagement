using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class sqlEmployeeRespository : IEmployeeRespository
    {
        private List<Employee> _employeeList;

        public sqlEmployeeRespository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Mary", Email = "mary@pragim.com", Department = "HR" },
                new Employee { Id = 2, Name = "John", Email = "john@pragim.com", Department = "IT" },
                new Employee { Id = 3, Name = "Sam", Email = "sam@pragim.com", Department = "PR" }
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }
    }
}
