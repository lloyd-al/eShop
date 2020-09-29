using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace eShop.Catalog.Api.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class RootController : ControllerBase
    {
        protected readonly ILogger<RootController> _logger;
        public RootController(ILogger<RootController> logger)
        {
            _logger = logger;
        }
    }
}
