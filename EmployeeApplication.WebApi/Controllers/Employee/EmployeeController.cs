using AutoMapper;
using EmployeeApplication.Application.Departments.Queries.GetAllDepartments;
using EmployeeApplication.Application.Employees.Commands.CreateEmployee;
using EmployeeApplication.Application.Employees.Commands.UpdateEmployee;
using EmployeeApplication.Application.Employees.Queries.GetAllEmployees;
using EmployeeApplication.Application.Language.Queries.GetAllLanguages;
using EmployeeApplication.WebApi.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApplication.WebApi.Controllers.Employee
{
    public class EmployeeController : Controller
    {
        private IMediator mediator;
        protected IMediator Mediator => mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        private readonly IMapper mapper;
        public EmployeeController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<Application.Employees.Queries.GetAllEmployees.EmployeeListVm>> GetAll()
        {
            var query = new GetEmployeeListQuery();
            var vm = await Mediator.Send(query);
            return View(vm);
        }

        [HttpGet]
        public async Task<ActionResult> Create()
        {
            var query = new GetDepartmentListQuery();
            var queryp = new GetLanguageListQuery();
            var vm = await Mediator.Send(query);
            var vm2 = await Mediator.Send(queryp);
            vm.Lookupp = vm2.Lookupp;
            vm.CreateEmployee = new CreateEmployeeDto();
            return View(vm);

        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create(EmployeeListVm vm)
        {
            CreateEmployeeDto createEmployeeDto = vm.CreateEmployee;
            var command = mapper.Map<CreateEmployeeCommand>(createEmployeeDto);
            var empId = await Mediator.Send(command);
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public async Task<ActionResult> Update(Guid id)
        {
            var upd = new UpdateEmployeeDto { Id = id };
            var query = new GetEmployeeListQuery();
            var queryd = new GetDepartmentListQuery();
            var queryp = new GetLanguageListQuery();
            var vm = await Mediator.Send(query);
            var vmd = await Mediator.Send(queryd);
            var vmp = await Mediator.Send(queryp);
            vm.Lookupp = vmp.Lookupp;
            vm.Lookupsd = vmd.Lookupsd;

            vm.UpdateEmployee = upd;
            return View(vm);
        }

        [HttpPost]
        public async Task<ActionResult> Update(EmployeeListVm vm)
        {
            UpdateEmployeeDto updateEmployeeDto = vm.UpdateEmployee;
            var command = mapper.Map<UpdateEmployeeCommand>(updateEmployeeDto);
            await Mediator.Send(command);
            return RedirectToAction("GetAll");
        }
    }
}
