using CI_CD_App.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CI_CD_App.Interface
{
    public interface IEmployeeService
    {
        EmployeeViewModel AddEmployee(EmployeeViewModel model);
        List<EmployeeViewModel> GetEmployee(int employeeId = 0);
    }
}
