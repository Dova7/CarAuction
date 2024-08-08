using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CarAuctionInfrastructure.BackgroundServices
{
    public class AuctionStatusUpdateService : BackgroundService
    {
        private readonly ILogger<AuctionStatusUpdateService> _logger;
        public AuctionStatusUpdateService(ILogger<AuctionStatusUpdateService> logger)
        {
            _logger = logger;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}