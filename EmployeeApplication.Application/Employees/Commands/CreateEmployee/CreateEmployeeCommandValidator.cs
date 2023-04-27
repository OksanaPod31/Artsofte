using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Application.Employees.Commands.CreateEmployee
{
    public class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
    {
        public CreateEmployeeCommandValidator()
        {
            RuleFor(cre => cre.Name).NotEmpty();
            RuleFor(cre => cre.DepartmentId).NotEmpty();
            RuleFor(cre => cre.Surname).NotEmpty();
            RuleFor(cre => cre.Gender).NotEmpty();
            RuleFor(cre => cre.ProgrammingLanguageId).NotEmpty();

        }

    }
}
