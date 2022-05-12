using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CI_CD_App.DBModels
{
    public partial class TblEmployees
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public int? SkillId { get; set; }
        public int YearsExperience { get; set; }
    }
}
