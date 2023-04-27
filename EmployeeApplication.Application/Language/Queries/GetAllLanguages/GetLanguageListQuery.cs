using EmployeeApplication.Application.Employees.Queries.GetAllEmployees;
using EmployeeApplication.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Application.Language.Queries.GetAllLanguages
{
    public class GetLanguageListQuery : IRequest<EmployeeListVm>
    {
    }
}
