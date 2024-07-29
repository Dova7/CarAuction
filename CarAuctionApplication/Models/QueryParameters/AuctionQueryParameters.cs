namespace CarAuctionApplication.Models.QueryParameters
{
    public class AuctionQueryParameters
    {
        public SortParameters SortParameters { get; set; } = new SortParameters();
        public SearchParameters SearchParameters { get; set; } = new SearchParameters();
        public PageParameters PageParameters { get; set; } = new PageParameters();
    }
}
