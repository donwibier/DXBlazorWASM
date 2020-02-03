using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DX.BlazorWASM.Shared
{
	public class WeatherForecast
	{
		public DateTime Date { get; set; }

		public int TemperatureC { get; set; }

		public string Summary { get; set; }

		public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
	}

	public interface IWeatherForecastService
	{
		Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
	}
}
