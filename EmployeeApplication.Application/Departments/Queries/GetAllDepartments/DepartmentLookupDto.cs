using AutoMapper;
using EmployeeApplication.Application.Common.Mapping;
using EmployeeApplication.Application.Employees.Queries.GetAllEmployees;
using EmployeeApplication.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Application.Departments.Queries.GetAllDepartments
{
    public class DepartmentLookupDto : IMapWith<Department>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Department, DepartmentLookupDto>().ForMember(dto => dto.Name, opt => opt.MapFrom(em => em.Name))
                .ForMember(dto => dto.Id, opt => opt.MapFrom(em => em.Id));
                
        }
    }
}
