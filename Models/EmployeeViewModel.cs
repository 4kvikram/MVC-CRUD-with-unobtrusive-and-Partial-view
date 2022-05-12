using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CI_CD_App.Models
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public int SkillId { get; set; }
        public int YearsExperience { get; set; }
    }
}
