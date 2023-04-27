using AutoMapper;
using AutoMapper.QueryableExtensions;
using EmployeeApplication.Application.Employees.Queries.GetAllEmployees;
using EmployeeApplication.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Application.Departments.Queries.GetAllDepartments
{
    public class GetDepartmentListQueryHandler : IRequestHandler<GetDepartmentListQuery, EmployeeListVm>
    {
        private readonly IEmployeeApplicationDbContext context;
        private readonly IMapper mapper;
        public GetDepartmentListQueryHandler(IEmployeeApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<EmployeeListVm> Handle(GetDepartmentListQuery request, CancellationToken cancellationToken)
        {
            var empQuery = await context.Department.ProjectTo<DepartmentLookupDto>(mapper.ConfigurationProvider)
                 .ToListAsync(cancellationToken);
            return new EmployeeListVm { Lookupsd = empQuery };
        }
    }
}
