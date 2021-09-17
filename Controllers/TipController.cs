using Microsoft.AspNetCore.Mvc;
using TestApp.API.Models;
using System.Linq;

namespace TestApp.API.Controllers
{
    [Route("api/[controller]")]
    public class TipController: Controller
    {
        private readonly ApiContext _ctx;

        public TipController(ApiContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _ctx.Tips.OrderBy(c => c.tipId);
            return Ok(data);
        }

        [HttpGet("{tipId}", Name = "GetTip")]
        public IActionResult Get(int tipId)
        {
            var tip = _ctx.Tips.Find(tipId);
            return Ok(tip);
        }

        [HttpPost]
        public IActionResult Post ([FromBody] Tip tip)
        {
            if(tip == null)
            {
                return BadRequest();
            }

            _ctx.Tips.Add(tip);
            _ctx.SaveChanges();

            return CreatedAtRoute("GetTip", new {tipId = tip.tipId}, tip);
        }

    }
}