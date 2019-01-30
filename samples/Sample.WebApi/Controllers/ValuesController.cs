﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sample.Service.Interfaces;
using Uragano.Core;


namespace Sample.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		private IHelloService HelloService { get; }

		public ValuesController(IHelloService helloService)
		{
			HelloService = helloService;
		}

		// GET api/values
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			return Ok(new
			{
				result = await HelloService.SetMeta(("token", "bearer .....")).SayHello(Guid.NewGuid().ToString()),
			});
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public ActionResult<string> Get(int id)
		{
			return "value";
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
