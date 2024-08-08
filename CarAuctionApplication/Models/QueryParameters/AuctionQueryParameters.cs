namespace CarAuctionApplication.Models.QueryParameters
{
    public class AuctionQueryParameters
    {
        public SortParameters SortParameters { get; set; } = new SortParameters();
        public List<SearchParameters> SearchParameters { get; set; } = new List<SearchParameters>();
        public PageParameters PageParameters { get; set; } = new PageParameters();
    }
}
