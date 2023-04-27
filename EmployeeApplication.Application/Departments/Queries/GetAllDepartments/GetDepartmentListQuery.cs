using EmployeeApplication.Application.Employees.Queries.GetAllEmployees;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Application.Departments.Queries.GetAllDepartments
{
    public class GetDepartmentListQuery : IRequest<EmployeeListVm>
    {
    }
}
