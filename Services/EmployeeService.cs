using CI_CD_App.DBModels;
using CI_CD_App.Interface;
using CI_CD_App.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CI_CD_App.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationContext _context;

        public EmployeeService(ApplicationContext Context)
        {
            _context = Context;
        }


        public List<EmployeeViewModel> GetEmployee(int employeeId = 0)
        {
            try
            {
                List<EmployeeViewModel> employeeViewModels = new List<EmployeeViewModel>();

                if (employeeId > 0)
                {
                    employeeViewModels = _context.TblEmployees.Where(x => x.EmployeeId == employeeId).
                        Select(x => new EmployeeViewModel()
                        {
                            EmployeeName = x.EmployeeName,
                            EmployeeId = x.EmployeeId,
                            SkillId = (int)x.SkillId,
                            PhoneNumber = x.PhoneNumber,
                            YearsExperience = (int)x.YearsExperience,
                        }).ToList();

                }
                else
                {
                    employeeViewModels = _context.TblEmployees.
                       Select(x => new EmployeeViewModel()
                       {
                           EmployeeName = x.EmployeeName,
                           EmployeeId = x.EmployeeId,
                           SkillId = (int)x.SkillId,
                           PhoneNumber = x.PhoneNumber,
                           YearsExperience = (int)x.YearsExperience,
                       }).ToList();
                }


                return employeeViewModels;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public EmployeeViewModel AddEmployee(EmployeeViewModel model)
        {
            try
            {
                if (model.EmployeeId > 0)
                {
                    var emp = _context.TblEmployees.Where(x => x.EmployeeId == model.EmployeeId).FirstOrDefault();
                    emp.EmployeeName = model.EmployeeName;
                    emp.SkillId = model.SkillId;
                    emp.PhoneNumber = model.PhoneNumber;
                    emp.YearsExperience = model.YearsExperience;
                    _context.TblEmployees.Update(emp);
                    int i = _context.SaveChanges();
                    if (i > 0)
                    {
                        model.EmployeeId = emp.EmployeeId;
                    }
                }
                else
                {
                    TblEmployees tblEmployees = new TblEmployees()
                    {
                        EmployeeName = model.EmployeeName,
                        PhoneNumber = model.PhoneNumber,
                        SkillId = model.SkillId,
                        YearsExperience = model.YearsExperience
                    };
                    _context.TblEmployees.Add(tblEmployees);
                    int i = _context.SaveChanges();
                    if (i > 0)
                    {
                        model.EmployeeId = tblEmployees.EmployeeId;
                    }
                }

                return model;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
