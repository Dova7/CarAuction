using CarAuctionApplication.Contracts.IRepositories;
using CarAuctionDomain.Entities.Bidding;
using CarAuctionInfrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CarAuctionInfrastructure.Repositories
{
    public class BidRepository : BaseRepository<Bid>, IBidRepository
    {
        private readonly CarAuctionDbContext _context;
        public BidRepository(CarAuctionDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<Bid> Update(Bid entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            var entityFromDb = await _context.Bids.FirstOrDefaultAsync(x => x.Id == entity.Id);
            if (entityFromDb != null)
            {
                foreach (var property in typeof(Bid).GetProperties())
                {
                    if (property.Name != "Id" && property != null)
                    {
                        var newValue = property.GetValue(entity);

                        property.SetValue(entityFromDb, newValue);
                    }
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
            _context.Bids.Update(entityFromDb);
            return entityFromDb;
        }
    }
}
