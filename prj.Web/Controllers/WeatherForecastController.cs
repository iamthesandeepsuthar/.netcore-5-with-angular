using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prj.Helper.Services.MasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prj.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IMasterData _logger;

        public WeatherForecastController(IMasterData logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            try
            {
                var result = await _logger.GetList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
