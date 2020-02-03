using DX.BlazorWASM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DX.BlazorWASM.Client.Services
{
	public class WeatherForecastService : IWeatherForecastService
	{
		readonly HttpClient http;
		public WeatherForecastService(HttpClient http)
		{
			this.http = http;
		}
		public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
		{
			var results = await http.GetJsonAsync<WeatherForecast[]>("WeatherForecast");
			return results;
		}		
	}
}
