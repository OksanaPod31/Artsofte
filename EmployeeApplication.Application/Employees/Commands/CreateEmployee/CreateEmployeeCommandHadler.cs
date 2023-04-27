using EmployeeApplication.Application.Interfaces;
using EmployeeApplication.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Application.Employees.Commands.CreateEmployee
{
    public class CreateEmployeeCommandHadler : IRequestHandler<CreateEmployeeCommand, Guid>
    {
        private readonly IEmployeeApplicationDbContext context;

        public CreateEmployeeCommandHadler(IEmployeeApplicationDbContext context) { this.context = context; }
        public async Task<Guid> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Employee
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Surname = request.Surname,
                Age = request.Age,
                DepartmentId = request.DepartmentId,
                Gender = request.Gender,
                ProgrammingLanguageId = request.ProgrammingLanguageId,
            };

            await context.Employees.AddAsync(employee);
            await context.SaveChangesAsync(cancellationToken);
            return employee.Id;
        }
    }
}
