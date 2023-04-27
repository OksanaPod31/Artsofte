using EmployeeApplication.Application.Common.Mapping;
using EmployeeApplication.Application.Interfaces;
using EmployeeApplication.Persistence;
using System.Reflection;
using EmployeeApplication.Application;
using EmployeeApplication.WebApi.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(config =>
{
    config.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
    config.AddProfile(new AssemblyMappingProfile(typeof(IEmployeeApplicationDbContext).Assembly));
});
builder.Services.AddApplication();
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    try
    {
        var context = serviceProvider.GetRequiredService<EmployeeApplicationDbContext>();
        DbInitializer.Initialize(context);
    }
    catch (Exception e)
    {

    }
}
app.UseCustomExceptionHandler();
app.UseRouting();
app.UseHttpsRedirection();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=GetAll}/{id?}");

app.Run();
