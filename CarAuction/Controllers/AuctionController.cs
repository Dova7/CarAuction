using Azure;
using CarAuctionApplication.Contracts.IServices;
using CarAuctionApplication.Models.Main.Dtos.CarAuction;
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
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<AuctionForGettingDtoAllLive>>> GetAllLiveAuctions()
        {
            var result = await _auctionService.GetAllLiveAuctionsAsync();

            return result;
        }
        [HttpGet("{auctionId:guid}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<AuctionForGettingDtoSingle>> GetSingleTopic([FromRoute] Guid auctionId)
        {
            var result = await _auctionService.GetSingleAuctionAsync(auctionId);           

            return result;
        }
    }
}
