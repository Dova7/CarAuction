using CarAuctionApplication.Contracts.IServices;
using CarAuctionApplication.Models.Main.Dtos.Auction;
using CarAuctionApplication.Models.Main.Dtos.CarAuction;
using CarAuctionApplication.Models.QueryParameters;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CarAuction.Controllers
{
    [Route("api/Auctions")]
    [ApiController]
    public class AuctionController : ControllerBase
    {
        private readonly IAuctionService _auctionService;
        //private APIResponse _response;
        public AuctionController(IAuctionService auctionService)
        {
            _auctionService = auctionService;
        }

        [HttpPost("Get")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<AuctionForGettingDtoAll>>> GetAllAuctions([FromBody] AuctionQueryParameters queryParameters)
        {
            var result = await _auctionService.GetAllAuctionsAsync(queryParameters);

            return result;
        }

        [HttpGet("{auctionId:guid}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<AuctionForGettingDtoSingle>> GetSingleAuction([FromRoute] Guid auctionId)
        {
            var result = await _auctionService.GetSingleAuctionAsync(auctionId);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> AddAuction([FromBody] AuctionForCreatingDto auctionForCreatingDto)
        {
            await _auctionService.CreateAuctionAsync(auctionForCreatingDto);

            return Ok();
        }

        [HttpPut("{auctionId:guid}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateAuction([FromRoute] Guid auctionId, [FromBody] AuctionForUpdatingDtoSeller auctionForUpdatingDtoSeller)
        {
            await _auctionService.UpdateAuctionAsyncSeller(auctionId, auctionForUpdatingDtoSeller);

            return Ok();
        }

        [HttpDelete("{auctionId:guid}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteAuction([FromRoute] Guid auctionId)
        {
            await _auctionService.DeleteAuctionAsync(auctionId);

            return Ok();
        }
    }
}
