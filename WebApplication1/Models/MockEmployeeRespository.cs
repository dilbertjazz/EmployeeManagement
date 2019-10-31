using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRespository : IEmployeeRespository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRespository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Mary", Email = "mary@pragim.com", Department = "HR" },
                new Employee { Id = 2, Name = "John", Email = "john@pragim.com", Department = "IT" },
                new Employee { Id = 3, Name = "Sam", Email = "sam@pragim.com", Department = "PR" }
            };
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
