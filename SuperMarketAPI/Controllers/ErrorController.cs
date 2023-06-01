using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SuperMarketAPI;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SuperMarketAPI.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ValuesController : Controller
    {

        [Route("error")]
        public string Error()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var exception = context?.Error;

            if (exception is SupermarketException)
            {
                Response.StatusCode = 500;
                return exception.Message;
            }
            return "";
        }

    }
}

