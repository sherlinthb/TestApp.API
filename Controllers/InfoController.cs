using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TestApp.API.Models;


namespace TestApp.API.Controllers
{
    [Route("api/[Controller]")]
    public class InfoController: Controller
    {
        private readonly ApiContext _ctx;

        public InfoController(ApiContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _ctx.Infos.OrderBy(c => c.Id);
            return Ok(data);
        }

        [HttpGet("{id}", Name = "GetInfo")]
        public IActionResult Get(int id)
        {
            var info = _ctx.Infos.Find(id);
            return Ok(info);
        }

        [HttpPost]
        public IActionResult Post ([FromBody] Info info)
        {
            if(info == null)
            {
                return BadRequest();
            }

            _ctx.Infos.Add(info);
            _ctx.SaveChanges();

            return CreatedAtRoute("GetInfo", new {id = info.Id}, info);
        }
    }
}