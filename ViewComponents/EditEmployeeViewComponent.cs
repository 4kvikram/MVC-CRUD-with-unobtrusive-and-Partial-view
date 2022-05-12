using CI_CD_App.Interface;
using CI_CD_App.Models;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CI_CD_App.ViewComponents
{

    public class EmployeeViewComponent : ViewComponent
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeViewComponent(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int EmployeeId = 0)
        {
            var res = _employeeService.GetEmployee(EmployeeId);
            return await Task.FromResult((IViewComponentResult)View("Employee", res));

            //string answer = "";
            //string str = "ABCDEFGHI";
            //string str1 = "ECDF";
            //int strLen = str.Length;
            //int str1Len = str1.Length;
            //for (int i = 0; i < strLen- str1Len+1; i++)
            //{
            //    string temp = str.Substring(i, str1Len);
            //    int count = 0;
            //    foreach (var item in str1)
            //    {
            //        if (temp.Contains(item))
            //        {
            //            count++;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    if (count== str1Len)
            //    {
            //        answer = temp;
            //    }
            //}


        }

    }

}

