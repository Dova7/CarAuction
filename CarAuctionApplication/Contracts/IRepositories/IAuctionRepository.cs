using CarAuctionApplication.Contracts.Interfaces;
using CarAuctionEntities.Entities;

namespace CarAuctionApplication.Contracts.IRepositories
{
    public interface IAuctionRepository : IBaseRepository<Auction>, IFullyUpdatable<Auction>, ISavable
    {

    }
}
