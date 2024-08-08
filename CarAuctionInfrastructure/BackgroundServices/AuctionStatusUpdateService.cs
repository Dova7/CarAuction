using CarAuctionApplication.Contracts.IRepositories;
using CarAuctionEntities.Constants.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CarAuctionInfrastructure.BackgroundServices
{
    public class AuctionStatusUpdateService : BackgroundService
    {
        private readonly ILogger<AuctionStatusUpdateService> _logger;
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public AuctionStatusUpdateService(ILogger<AuctionStatusUpdateService> logger, IServiceScopeFactory serviceScopeFactory)
        {
            _logger = logger;
            _serviceScopeFactory = serviceScopeFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = _serviceScopeFactory.CreateScope())
                {
                    var auctionRepo = scope.ServiceProvider.GetRequiredService<IAuctionRepository>();

                    try
                    {
                        var auctions = await auctionRepo.GetAllAsync();

                        foreach (var auction in auctions)
                        {
                            if (auction.AuctionEnd <= DateTime.UtcNow)
                            {
                                if (auction.CurrentHighBid < auction.ReservePrice)
                                {
                                    auction.Status = Status.ReserveNotMet;
                                }
                                else
                                {
                                    auction.Status = Status.Finished;
                                }
                                await auctionRepo.Save();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "An error occurred while updating auction statuses.");
                    }
                }
                _logger.LogInformation("BackgroundService is running");
                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
    }
}