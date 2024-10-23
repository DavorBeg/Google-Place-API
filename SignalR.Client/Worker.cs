using Entities.Domain.Google;
using Microsoft.AspNetCore.SignalR.Client;


namespace SignalR.Client
{
	public class Worker : BackgroundService
	{
		private readonly ILogger<Worker> _logger;
		private string HC_Connection = "http://localhost:5092/";
		private string HC_HubName = "eventHub";
		private readonly HubConnection _hubProxy;

		public Worker(ILogger<Worker> logger)
		{
			_logger = logger;
			_hubProxy = new HubConnectionBuilder().WithUrl(HC_Connection + HC_HubName).Build();

		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			await _hubProxy.StartAsync();
			Console.WriteLine("-----------------------> SignalR Client started <-----------------------");
			_hubProxy.On<string, Location, float, DateTime>("ReportReceive", (user, location, radius, time) =>
			{
				_logger.LogInformation($"User: {user} have send request for location lat: {location.Latitude} lng: {location.Longitude} inside radius {radius} on time: {time.ToString("g")}");
			});
		}
	}
}
