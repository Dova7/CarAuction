using CarAuctionApplication.Contracts.Interfaces;
using CarAuctionDomain.Entities.Bidding;

namespace CarAuctionApplication.Contracts.IRepositories
{
    public interface IBidRepository : IBaseRepository<Bid>, IFullyUpdatable<Bid>, ISavable
    {

    }
}
