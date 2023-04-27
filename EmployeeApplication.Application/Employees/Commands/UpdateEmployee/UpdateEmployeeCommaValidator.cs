using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Application.Employees.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommaValidator : AbstractValidator<UpdateEmployeeCommand>
    {
        public UpdateEmployeeCommaValidator()
        {
            
            RuleFor(upe => upe.Name).NotEmpty();
            RuleFor(upe => upe.DepartmentId).NotEmpty();
            RuleFor(upe => upe.Surname).NotEmpty();
            RuleFor(upe => upe.Gender).NotEmpty();
            RuleFor(upe => upe.ProgrammingLanguageId).NotEmpty();
        }
    }
}
