using DX.Blazor.Data;
using DX.BlazorWASM.Shared;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DX.BlazorServer.Data
{
	public class WeatherForecastService : IWeatherForecastService
	{
		public WeatherForecastService(WeatherForecastStore store)
		{
			this.store = store;
		}
		readonly WeatherForecastStore store;

		public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
		{
			var results = await store.GetForecastAsync(startDate);
			return results;
		}
	}
}
