using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RSys.CQRS.Command;
using RSys.CQRS.Handler;
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
    public class QnaireController : BaseController<QnaireController>
    {
        public QnaireController(IMediator mediator, ILogger<QnaireController> logger)
            : base(mediator, logger) { }

        [HttpGet]
        public async Task<ActionResult<List<Questionnaire>>> GetAsync()
        {
            try
            {
                return await this.mediator.Send(new AllQnairesRequest());
            }
            catch (Exception e)
            {
                this.logger.LogError(e.ToString());
                return BadRequest(e.Message);
            }
        }

        [HttpPost()]
        public async Task<ActionResult<Questionnaire>> CreateTheaterAsync(Questionnaire questionnaire)
        {
            try
            {
                return await this.mediator.Send(new InsertQnaireCommand
                {
                    Item = questionnaire
                }); ;
            }
            catch (Exception e)
            {
                this.logger.LogError(e.ToString());
                return BadRequest(e.Message);
            }
        }
    }
}
