using Entities.Domain.Google;
using Microsoft.AspNetCore.SignalR.Client;
using Shared.DTOs.SignalR;


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
			_hubProxy.On<LocationRequestParamsDto>(Shared.SignalR.SignalR.Events.UserRequestSearchLocation, (dto) =>
			{
				_logger.LogInformation($"User: {dto.User} have send request for location lat: {dto.Circle.Center.Latitude} lng: {dto.Circle.Center.Longitude} inside radius {dto.Circle.Radius} on time: {dto.Timestamp.ToString("g")}");
			});
		}
	}
}
