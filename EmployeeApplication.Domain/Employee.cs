using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Domain
{
    public class Employee
    {
       public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        [ForeignKey(nameof(Department))]
        public Guid DepartmentId { get; set; }
        public Department Department { get; set;}

        [ForeignKey(nameof(ProgrammingLanguage))]
        public Guid ProgrammingLanguageId { get; set; }
        public ProgrammingLanguage ProgrammingLanguage { get; set; }
    }
}
