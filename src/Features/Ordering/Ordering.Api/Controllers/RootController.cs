using System;
using eShop.Common.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace eShop.Ordering.Api.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class RootController : ControllerBase
    {
        protected readonly ILoggerManager _logger;
        public RootController(ILoggerManager logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
