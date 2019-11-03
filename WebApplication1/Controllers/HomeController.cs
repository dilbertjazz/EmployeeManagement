using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
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

        public ViewResult Index()
        {
            var model = _employeeRespository.GetAllEmployee();
            return View(model);
        }

        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRespository.GetEmployee(id??1),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee) 
        {
            if (ModelState.IsValid)
            {
                Employee newEmployee = _employeeRespository.Add(employee);
            }

            return View();
        }
    }
}