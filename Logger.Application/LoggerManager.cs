﻿using Contracts.Domain.Services;
using Serilog;

namespace Logger.Application
{
	public class LoggerManager : ILoggerManager
	{
		private static ILogger logger = Serilog.Log.Logger;
		public void LogDebug(string message) => logger.Debug(message);
		public void LogError(string message) => logger.Error(message);
		public void LogInfo(string message) => logger.Information(message);
		public void LogWarn(string message) => logger.Warning(message);
	}
}
