using CarAuctionApplication.Contracts.IRepositories;
using CarAuctionEntities.Entities;
using CarAuctionInfrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CarAuctionInfrastructure.Repositories
{
    public class AuctionRepository : BaseRepository<Auction>, IAuctionRepository
    {
        private readonly CarAuctionDbContext _context;

        public AuctionRepository(CarAuctionDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
        public async Task<Auction> Update(Auction entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            var entityFromDb = await _context.Auctions.FirstOrDefaultAsync(x => x.Id == entity.Id);
            if (entityFromDb != null)
            {
                foreach (var property in typeof(Auction).GetProperties())
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
            _context.Auctions.Update(entityFromDb);
            return entityFromDb;
        }
    }
}
