using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApplication.WebApi.Controllers
{
    public class BaseController : ControllerBase
    {
        private IMediator mediator;
        protected IMediator Mediator =>
            mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
