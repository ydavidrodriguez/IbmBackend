using Algar.Hours.Application.DataBase.Menu.Commands;
using Algar.Hours.Application.DataBase.Rol.Commands;
using Algar.Hours.Application.Exceptions;
using Algar.Hours.Application.Feature;
using Microsoft.AspNetCore.Mvc;

namespace Algar.Hours.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [TypeFilter(typeof(ExceptionManager))]

    public class MenuController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create(
          [FromBody] CreateMenuModel model, [FromServices] ICreateMenuCommand createMenuCommand)
        {
            var data = await createMenuCommand.Execute(model);
            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data));

        }
    }
}
