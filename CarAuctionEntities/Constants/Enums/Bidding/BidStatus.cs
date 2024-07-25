using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuctionDomain.Constants.Enums.Bidding
{
    public enum BidStatus
    {

        BelowReserve = 0,
        BidPlaced = 1,
        InvalidBid = 2,
        AuctionClosed = 3,
    }
}
