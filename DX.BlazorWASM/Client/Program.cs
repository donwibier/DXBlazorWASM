using DX.BlazorWASM.Client.Services;
using DX.BlazorWASM.Shared;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace DX.BlazorWASM.Client
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);

			//register DI services
			builder.Services.AddSingleton<IWeatherForecastService, WeatherForecastService>();

			builder.RootComponents.Add<App>("app");

			//configure singleton services if needed
			//var weatherService = host.Services.GetRequiredService<WeatherService>();
			//await weatherService.InitializeWeatherAsync();

			await builder.Build().RunAsync();
		}
	}
}
