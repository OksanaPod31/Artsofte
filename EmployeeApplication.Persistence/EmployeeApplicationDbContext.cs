using EmployeeApplication.Application.Interfaces;
using EmployeeApplication.Domain;
using EmployeeApplication.Persistence.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.Persistence
{
    public class EmployeeApplicationDbContext : DbContext, IEmployeeApplicationDbContext
    {
        public DbSet<Employee> Employees { get ; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get ; set; }

        public EmployeeApplicationDbContext(DbContextOptions<EmployeeApplicationDbContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProgrammingLanguageConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
