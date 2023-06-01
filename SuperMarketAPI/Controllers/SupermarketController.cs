using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperMarketAPI.Data;
using SuperMarketAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SuperMarketAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class SupermarketController : ControllerBase
    {
        private readonly ItemContext itemContext;

        public SupermarketController(ItemContext itemContext)
        {
            this.itemContext = itemContext;
        }

        [HttpGet("ping")]
        public string Ping()
        {
            return "pong";
        }

        [HttpGet("dontcall")]
        public string ResponseError()
        {
            throw new SupermarketException("It is a sample error");
        }

        [HttpGet("items")]
        public IEnumerable<Item> GetItems()
        {
            return itemContext.Items.ToList();
        }
    }
}
