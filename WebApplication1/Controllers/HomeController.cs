using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRespository _employeeRespository;

        public HomeController(IEmployeeRespository employeeRespository)
        {
            _employeeRespository = employeeRespository;
        }

        public string Index()
        {
            return _employeeRespository.GetEmployee(1).Name;
        }

        public ViewResult Details()
        {
            Employee model = _employeeRespository.GetEmployee(1);
            return View(model);
        }
    }
}