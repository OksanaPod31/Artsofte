using AutoMapper;
using AutoMapper.QueryableExtensions;
using EmployeeApplication.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Application.Employees.Queries.GetAllEmployees
{
    internal class GetEmployeeListQueryHandler : IRequestHandler<GetEmployeeListQuery, EmployeeListVm>
    {
        private readonly IEmployeeApplicationDbContext context;
        private readonly IMapper mapper;
        public GetEmployeeListQueryHandler(IEmployeeApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<EmployeeListVm> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            var empQuery = await context.Employees.ProjectTo<EmployeeLookupDto>(mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
            return new EmployeeListVm { Lookups = empQuery };
        }
    }
}
