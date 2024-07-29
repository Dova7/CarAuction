using CarAuctionApplication.Contracts.Interfaces;
using CarAuctionEntities.Entities;

namespace CarAuctionApplication.Contracts.IRepositories
{
    public interface IAuctionRepository : IBaseRepository<Auction>, IFullyUpdatable<Auction>, ISavable
    {
        public IQueryable<Auction> GetQuery(params string[] includes);
    }
}
