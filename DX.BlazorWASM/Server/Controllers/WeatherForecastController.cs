using DX.BlazorWASM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DX.Blazor.Data;

namespace DX.BlazorWASM.Server.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private readonly ILogger<WeatherForecastController> logger;
		readonly WeatherForecastStore store;

		public WeatherForecastController(ILogger<WeatherForecastController> logger, WeatherForecastStore store)
		{
			this.logger = logger;
			this.store = store;
		}

		[HttpGet]
		public async Task<IEnumerable<WeatherForecast>> Get()
		{
			var results = await store.GetForecastAsync(DateTime.Now);
			return results;
		}
	}
}
