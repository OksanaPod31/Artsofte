using EmployeeApplication.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Application.Interfaces
{
    public interface IEmployeeApplicationDbContext
    {
        DbSet<Employee> Employees { get; set; }
        DbSet<Department> Department { get; set; }
        DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set;}
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}
