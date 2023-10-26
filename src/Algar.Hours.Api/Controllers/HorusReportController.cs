using Algar.Hours.Application.DataBase.Country.Commands;
using Algar.Hours.Application.DataBase.HorusReport.Commands;
using Algar.Hours.Application.Exceptions;
using Algar.Hours.Application.Feature;
using Microsoft.AspNetCore.Mvc;

namespace Algar.Hours.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [TypeFilter(typeof(ExceptionManager))]
    public class HorusReportController : Controller
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create(
        [FromBody] CreateHorusReportModel model, [FromServices] ICreateHorusReportCommand createHorusReportCommand)
        {
            var data = await createHorusReportCommand.Execute(model);
            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data));

        }
    }
}
