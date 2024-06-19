using CarAuctionEntities.Entities.Identity;

namespace CarAuctionApplication.Contracts
{
    public interface IJwtGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
    }
}
