using CarAuctionApplication.Contracts.IServices;
using CarAuctionApplication.Models.Main.Dtos.Bid;
using CarAuctionApplication.Service.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace CarAuction.Controllers
{
    public class BidController : ControllerBase
    {
        private readonly IBidService _bidService;
        public BidController(IBidService bidService)
        {
            _bidService = bidService;
        }

        [HttpPost("{auctionId:guid}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> AddAmount([FromRoute] Guid auctionId, [FromBody] AddBidDto addBidDto)
        {
            await _bidService.AddAmountAsync(auctionId, addBidDto);

            return Ok();
        }

        [HttpDelete("{bidId:guid}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteBid([FromRoute] Guid bidId)
        {
            await _bidService.DeleteBidAsync(bidId);

            return Ok();
        }
    }
}
