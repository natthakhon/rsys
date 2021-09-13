using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RSys.CQRS.Query;
using RSys.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSys.Api.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : BaseController<CountryController>
    {
        public CountryController(IMediator mediator, ILogger<CountryController> logger)
            : base(mediator, logger) { }

        [HttpGet]
        public async Task<ActionResult<List<Country>>> GetAsync()
        {
            try
            {
                return await this.mediator.Send(new AllCountriesRequest());
            }
            catch (Exception e)
            {
                this.logger.LogError(e.ToString());
                return BadRequest(e.Message);
            }
        }
    }
}
