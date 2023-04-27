using AutoMapper;
using EmployeeApplication.Application.Common.Mapping;
using EmployeeApplication.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Application.Employees.Queries.GetAllEmployees
{
    public class EmployeeLookupDto : IMapWith<Employee>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Department{ get; set; }
        public string ProgrammingLanguage { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Employee, EmployeeLookupDto>().ForMember(dto => dto.Name, opt => opt.MapFrom(em => em.Name))
                .ForMember(dto => dto.Surname, opt => opt.MapFrom(em => em.Surname))
                .ForMember(dto => dto.Gender, opt => opt.MapFrom(em => em.Gender))
                .ForMember(dto => dto.Age, opt => opt.MapFrom(em => em.Age))
                .ForMember(dto => dto.Department, opt => opt.MapFrom(em => em.Department.Name))
                .ForMember(dto => dto.ProgrammingLanguage, opt => opt.MapFrom(em => em.ProgrammingLanguage.Name))
                .ForMember(dto => dto.Id, opt => opt.MapFrom(em => em.Id));
        }
    }
}
