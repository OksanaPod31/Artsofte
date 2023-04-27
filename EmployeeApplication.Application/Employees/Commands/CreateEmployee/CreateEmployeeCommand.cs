using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Application.Employees.Commands.CreateEmployee
{
    public class CreateEmployeeCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid ProgrammingLanguageId { get; set; }
    }
}
