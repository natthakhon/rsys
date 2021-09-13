using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSys.Api.Api
{
    public abstract class BaseController<TController> : ControllerBase
        where TController : ControllerBase
    {
        protected readonly IMediator mediator;
        protected readonly ILogger<TController> logger;

        protected BaseController(IMediator mediator, ILogger<TController> logger)
        {
            this.mediator = mediator;
            this.logger = logger;
        }


    }
}
