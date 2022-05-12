using CI_CD_App.Interface;
using CI_CD_App.Models;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CI_CD_App.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EditEmployee(EmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var res = _employeeService.AddEmployee(model);
            }
            return PartialView("_ListEmployees");
        }

        public IActionResult GetEmployee(int EmpId)
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            if (ModelState.IsValid)
            {
                employeeViewModel = _employeeService.GetEmployee(EmpId).FirstOrDefault();
            }
            return PartialView("_EditEmployee", employeeViewModel);
        }
    }
}
