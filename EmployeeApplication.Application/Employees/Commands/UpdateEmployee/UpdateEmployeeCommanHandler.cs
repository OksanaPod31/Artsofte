using EmployeeApplication.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Application.Employees.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommanHandler : IRequestHandler<UpdateEmployeeCommand>
    {
        private readonly IEmployeeApplicationDbContext context;
        public UpdateEmployeeCommanHandler(IEmployeeApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var entity = await context.Employees.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (entity == null) { }
            entity.Name = request.Name;
            entity.Surname = request.Surname;
            entity.DepartmentId = request.DepartmentId;
            entity.Gender = request.Gender;
            entity.Age = request.Age;
            entity.ProgrammingLanguageId = request.ProgrammingLanguageId;

            await context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
