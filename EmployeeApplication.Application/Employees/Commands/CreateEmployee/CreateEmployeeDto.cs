using AutoMapper;
using EmployeeApplication.Application.Common.Mapping;
using EmployeeApplication.Application.Employees.Queries.GetAllEmployees;
using EmployeeApplication.Domain;

namespace EmployeeApplication.Application.Employees.Commands.CreateEmployee
{
    public class CreateEmployeeDto : IMapWith<CreateEmployeeCommand>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid ProgrammingLanguageId { get; set; }

        public void Mapping(Profile profile)
        {

            profile.CreateMap<CreateEmployeeDto, CreateEmployeeCommand>().ForMember(cre => cre.Name, opt => opt.MapFrom(dto => dto.Name))
                .ForMember(cre => cre.Surname, opt => opt.MapFrom(dto => dto.Surname))
                .ForMember(cre => cre.Gender, opt => opt.MapFrom(dto => dto.Gender))
                .ForMember(cre => cre.Age, opt => opt.MapFrom(dto => dto.Age))
                .ForMember(cre => cre.DepartmentId, opt => opt.MapFrom(dto => dto.DepartmentId))
                .ForMember(cre => cre.ProgrammingLanguageId, opt => opt.MapFrom(dto => dto.ProgrammingLanguageId));
        }
    }
}
