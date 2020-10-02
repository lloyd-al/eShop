using System;
using Microsoft.AspNetCore.Mvc;
using eShop.Common.Core.Interfaces;


namespace eShop.Basket.Api.Controllers
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
