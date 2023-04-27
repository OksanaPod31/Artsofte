using EmployeeApplication.Application.Departments.Queries.GetAllDepartments;
using EmployeeApplication.Application.Employees.Commands.CreateEmployee;
using EmployeeApplication.Domain;
using EmployeeApplication.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Application.Employees.Queries.GetAllEmployees
{
    public class EmployeeListVm
    {
        public CreateEmployeeDto CreateEmployee { get; set; }
        public UpdateEmployeeDto UpdateEmployee { get; set; }
        public IList<EmployeeLookupDto> Lookups { get; set; }
        public IList<DepartmentLookupDto> Lookupsd { get; set; }
        public IList<ProgrammingLanguage> Lookupp { get; set; }
    }
}
