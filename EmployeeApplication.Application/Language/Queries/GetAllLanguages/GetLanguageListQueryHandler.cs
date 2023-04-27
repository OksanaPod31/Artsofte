using AutoMapper;
using EmployeeApplication.Application.Employees.Queries.GetAllEmployees;
using EmployeeApplication.Application.Interfaces;
using EmployeeApplication.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Application.Language.Queries.GetAllLanguages
{
    public class GetLanguageListQueryHandler : IRequestHandler<GetLanguageListQuery, EmployeeListVm>
    {
        private readonly IEmployeeApplicationDbContext context;
        private readonly IMapper mapper;
        public GetLanguageListQueryHandler(IEmployeeApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async  Task<EmployeeListVm> Handle(GetLanguageListQuery request, CancellationToken cancellationToken)
        {
            var empQuery = await context.ProgrammingLanguages
                .ToListAsync(cancellationToken);
            return new EmployeeListVm { Lookupp = empQuery };
        }
    }
}
